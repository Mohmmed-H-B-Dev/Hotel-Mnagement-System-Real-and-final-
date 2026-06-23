using Business_Hotel_Management_System;
using DVLD.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Mnagement_System.Employees.Controls
{
    public partial class ctrlEmployeeInfo : UserControl
    {
      
        int _EmployeeID=-1;
        clsEmployees _EmployeeInfo;
        public clsEmployees EmployeeInfo {
            get
            {
                return _EmployeeInfo;
            }
            set
            {
                _EmployeeInfo = value;
            } }
        public int EmployeeID {
            get { return _EmployeeID; } set { _EmployeeID = value; } 
        }

        public ctrlEmployeeInfo()
        {
            InitializeComponent();
        }

        public void ResetDefaultValue()
        {
            lblEmployeeID.Text = "[????]";
            lblIDNumber.Text= "[????]";
            lblFullName.Text ="[????]";
            lblEmail.Text = "[????]";
            lblContactNumber.Text = "[????]";
            lblNationalty.Text="[????]";
            lblDateOfBirth.Text="[????]";
            lblGendor.Text="[????]";

            pbImagePath.Image=Hotel_Mnagement_System.Properties.Resources.Male_512;
            lbllEditEmployee.Enabled = false;
        }
        public void LoadInfo(int EmployeeID, clsEmployees Emp=null)
        {
            if (EmployeeID <=0)
            {
                MessageBox.Show("There is not ID ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if((_EmployeeInfo=Emp)==null) 
            _EmployeeInfo=clsEmployees.Find(EmployeeID);

            if(_EmployeeInfo == null )
            {
                lbllEditEmployee.Enabled = false;
                MessageBox.Show("We don`t have a employee with this ID : "+EmployeeID.ToString(), "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lbllEditEmployee.Enabled = true;
            _EmployeeID=EmployeeID;

            _LoadData();

        }

        private void _LoadData()
        {
            lblEmployeeID.Text = _EmployeeID.ToString();
            lblIDNumber.Text= _EmployeeInfo.IDNumber;
            lblFullName.Text =_EmployeeInfo.EmployeeFullName;
            lblEmail.Text = _EmployeeInfo.Email;    
            lblContactNumber.Text = _EmployeeInfo.ContactNumber;
            lblNationalty.Text=_EmployeeInfo.CountryInfo.CountryName;
            lblDateOfBirth.Text=clsFormat.DateToShort(_EmployeeInfo.DateOfBirth);
            if (_EmployeeInfo.Gendor==0)
                lblGendor.Text="Male";
            else
                lblGendor.Text="Female";

            _LoadEmployeeImage();
        }

        private void _LoadEmployeeImage()
        {
            if(_EmployeeInfo.Gendor==0)
            {
                pbImagePath.Image=Hotel_Mnagement_System.Properties.Resources.Male_512;

            }
            else
            {
                pbImagePath.Image=Hotel_Mnagement_System.Properties.Resources.Female_512;
            }

            if (!string.IsNullOrEmpty(_EmployeeInfo.ImagePath))
                pbImagePath.ImageLocation=_EmployeeInfo.ImagePath;
        }
        private void lbllEditEmployee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!clsGlobal.CurrentUser.IsAdmin)
            {
                MessageBox.Show("You don`t has a permissions to do this option, Contact Admin..","Wrong",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            frmAddNewEditEmployee frm =new frmAddNewEditEmployee(_EmployeeID);
            frm.ShowDialog();
        }
    }
}
