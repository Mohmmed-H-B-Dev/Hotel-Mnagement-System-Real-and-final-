using Business_Hotel_Management_System;
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
    public partial class ctrlEmployeeFiltering : UserControl
    {
        public event Action<int> OnSelectedEmployee;

        int _EmployeeID = -1;
        public int EmployeeID
        {
            get { return _EmployeeID; }
            set { _EmployeeID = value; }
        }
        public virtual void SelectedEmployee(int EmployeeID)
        {
            if (OnSelectedEmployee!=null) OnSelectedEmployee(EmployeeID);
        } 
        public ctrlEmployeeFiltering()
        {
            InitializeComponent();
            txtFilter.Focus();
            cmbFilterBy.SelectedIndex = 0;
        }

        public bool EmployeeFilter {

            get { return gbFilterEmployee.Enabled; }
            set { gbFilterEmployee.Enabled = value; }
        }
        public void _LoadData(int EmployeeID)
        {
         
            ctrlEmployeeInfo1.LoadInfo(EmployeeID);
            _EmployeeID=EmployeeID;
            if (OnSelectedEmployee!=null) OnSelectedEmployee(EmployeeID);
        }
        private void _LoadData(string IDNumber)
        {
            int EmployeeID = 0;
            clsEmployees ee = clsEmployees.Find(IDNumber);
            if (ee != null)
                EmployeeID = ee.EmployeeID;
            else
                return;
            _EmployeeID=EmployeeID;
              ctrlEmployeeInfo1.LoadInfo(EmployeeID, ee);
            if (OnSelectedEmployee!=null) OnSelectedEmployee(EmployeeID);

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilter.Text))
            {
                txtFilter.Focus();
                return;
            }
            if (cmbFilterBy.Text=="Employee ID")
                _LoadData(Convert.ToInt32(txtFilter.Text));
            else if(cmbFilterBy.Text=="ID Number")
                _LoadData(txtFilter.Text);

        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cmbFilterBy.Text=="Employee ID")
            e.Handled =!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);


            if (e.KeyChar==(int)Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }


        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            frmAddNewEditEmployee frm =new frmAddNewEditEmployee();
            frm.DataBack+=_LoadData;
            frm.ShowDialog();
            gbFilterEmployee.Enabled=false;
            txtFilter.Text=_EmployeeID.ToString();
        }

        private void _DataBackEventReturned(int EmployeeID)
        {
            ctrlEmployeeInfo1.LoadInfo(EmployeeID);
            txtFilter.Text=EmployeeID.ToString();
            gbFilterEmployee.Enabled=false;
        }
        public void TxtFocusFilter()
        {
                    txtFilter.Focus();
        }

        private void ctrlEmployeeFiltering_Load(object sender, EventArgs e)
        {
            cmbFilterBy.SelectedIndex=0;
            txtFilter.Focus();
            
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtFilter.Text="";
            txtFilter.Focus();
        }
       
    }
}
