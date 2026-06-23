using Hotel_Mnagement_System.Properties;
using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;
using Business_Hotel_Management_System;


namespace DVLD.Controls
{
    public partial class ctrlCustomerCard : UserControl
    {
        private clsCustomers _Customer;

        private int _CustomerID = -1;

        public int CustomerID
        {
            get { return _CustomerID; }   
        }

        public clsCustomers SelectedCustomerInfo
        {
            get { return _Customer; }
        }

        public ctrlCustomerCard()
        {
            InitializeComponent();
        }

        public void LoadCustomerInfo(int CustomerID)
        {
            _Customer=clsCustomers.FindCustomer(CustomerID);
            if (_Customer == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Customer with CustomerID = " + CustomerID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
                _FillCustomerInfo();
        }

        public void LoadCustomerInfo(string NationalNo)
        {
            _Customer = clsCustomers.FindCustomer(NationalNo);
            if (_Customer == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with National No. = " + NationalNo.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillCustomerInfo();
        }
        public void LoadCustomerInfo(clsCustomers Customer)
        {
            _Customer = Customer;
            if (_Customer == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Customer . = " , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillCustomerInfo();
        }

        private void _LoaCustomerImage()
        {
            if (_Customer.Gendor == 0)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

     
        }

        private void _FillCustomerInfo()
        {
            llEditCustomerInfo.Enabled = true;
            _CustomerID = _Customer.CustomerID;
            lblCustomerID.Text=_Customer.CustomerID.ToString();
            lblNationalNo.Text = _Customer.IDNumber;
            lblFullName.Text = _Customer.FullName;
            lblGendor.Text = _Customer.Gendor == 0 ? "Male" : "Female";
            if(!string.IsNullOrEmpty( _Customer.Email) ) 
                lblEmail.Text = _Customer.Email;
            else
                lblEmail.Text = "None";
            lblPhone.Text = _Customer.ContactNumber;
            lblDateOfBirth.Text = _Customer.DateOfBirth.ToShortDateString();
            lblCountry.Text= clsCountry.Find(_Customer.CountryID).CountryName ;
            lblVisitNumber.Text= _Customer.NumberVisit.ToString();
            if (!string.IsNullOrEmpty(_Customer.SpecialRequests))
                txtSpecialRequests.Text = _Customer.SpecialRequests;
            else 
                txtSpecialRequests.Text = "None";
                _LoaCustomerImage();

           


        }

        public void ResetPersonInfo()
        {
            _CustomerID = -1;
            lblCustomerID.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblFullName.Text = "[????]";
            pbGendor.Image = Resources.Man_32;
            lblGendor.Text = "[????]";
            lblEmail.Text = "[????]";
            lblPhone.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblCountry.Text = "[????]";
            lblVisitNumber.Text = "[????]";
            txtSpecialRequests.Text ="None";
            pbPersonImage.Image = Resources.Male_512;
        
        }

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //  frmAddUpdatePerson frm = new frmAddUpdatePerson( _PersonID );
            //  frm.ShowDialog();
            MessageBox.Show("This Form is not Completed", "Confirm");
            //refresh
          //  LoadPersonInfo(_CustomerID);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }
    }
}
