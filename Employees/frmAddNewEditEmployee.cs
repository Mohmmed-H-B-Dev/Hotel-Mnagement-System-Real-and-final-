using Business_Hotel_Management_System;
using DVLD.Classes;
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

namespace Hotel_Mnagement_System.Employees
{
    public partial class frmAddNewEditEmployee : Form
    {
        public delegate void DataBackEventEmployeeID(int EmployeeID);

        public event DataBackEventEmployeeID DataBack;
        enum enMode { AddNew = 1, Update = 2 };
        enMode _Mode = enMode.AddNew;
        int _EmployeeID = -1;
        clsEmployees _EmployeeInfo;

        public frmAddNewEditEmployee()
        {
            InitializeComponent();

            _EmployeeInfo=new clsEmployees();
            _Mode = enMode.AddNew;
            this.Text ="Add New Employee";
            lblTitle.Text="Add New Employee";
        }
        public frmAddNewEditEmployee(int EmployeeID)
        {
            InitializeComponent();
            _EmployeeID = EmployeeID;
            _Mode = enMode.Update;
            this.Text ="Update Employee";
            lblTitle.Text="Update Employee";
        }

        private void _LoadCountriesToComboBox()
        {
            DataTable dt = new DataTable();

            dt=clsCountry.GetAllCountries();
        
            foreach (DataRow row in dt.Rows)
            {
                cmbCountries.Items.Add(row["CountryName"].ToString());
            }
        }

        private void Non_Updatable()
        {
            txtIDNumber.Enabled = false;
            cmbCountries.Enabled = false;
            dtpDateOfBirth.Enabled = false;
            rbtnFemale.Enabled = false;
            rbtnMale.Enabled=false;
        }
        void _LoadData()
        {
            _EmployeeInfo=clsEmployees.Find(_EmployeeID);
            if( _EmployeeInfo == null )
            {
                MessageBox.Show("There is not Employee by ID : "+_EmployeeID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblEmployeeID.Text = _EmployeeInfo.EmployeeID.ToString();
            txtFirstName.Text = _EmployeeInfo.FirstName;
            txtSecondName.Text = _EmployeeInfo.SecondName;
            txtThirdName.Text = _EmployeeInfo.ThirdName;
            txtLastName.Text = _EmployeeInfo.LastName;
            txtEmail.Text = _EmployeeInfo.Email;
            txtContactNumber.Text = _EmployeeInfo.ContactNumber;
            txtIDNumber.Text = _EmployeeInfo.IDNumber;
            llblRemoveImage.Enabled=(!string.IsNullOrEmpty(_EmployeeInfo.ImagePath));
            
            dtpDateOfBirth.Value = _EmployeeInfo.DateOfBirth;
            cmbCountries.Text=_EmployeeInfo.CountryInfo.CountryName;
            if(_EmployeeInfo.Gendor==0)
                rbtnMale.Checked=true;
            else
            {
                rbtnFemale.Checked=true;
            }


            pbImagePath.ImageLocation=_EmployeeInfo.ImagePath;
            Non_Updatable();
        }
        private void frmAddNewEditEmployee_Load(object sender, EventArgs e)
        {
            _LoadCountriesToComboBox();
            cmbCountries.SelectedIndex=0;
            dtpDateOfBirth.MaxDate=DateTime.Now.AddYears(-18);
          
            if (_Mode==enMode.Update)
                _LoadData();


            if (rbtnMale.Checked)
                pbImagePath.Image= Hotel_Mnagement_System.Properties.Resources.Man_32;
            else if (rbtnFemale.Checked)
                pbImagePath.Image= Hotel_Mnagement_System.Properties.Resources.Woman_32;


        }

        private void rbtnMale_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnMale.Checked)
                pbImagePath.Image=Hotel_Mnagement_System.Properties.Resources.Man_32;
        }

        private void rbtnFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnFemale.Checked)
                pbImagePath.Image=Hotel_Mnagement_System.Properties.Resources.Woman_32;
        }


        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFirstName, "Enter First Name ..");
            } else
            {
               
                errorProvider1.SetError(txtFirstName, "");
            }


           



        }
        private void txtIDNumber_Validating(object sender, CancelEventArgs e)
        {


            if (string.IsNullOrEmpty(txtIDNumber.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtIDNumber, "Enter ID Number ..");
            }
            else
            {

                errorProvider1.SetError(txtIDNumber, "");
            }

            if (clsEmployees.IsEmployeeExist(txtIDNumber.Text) && _Mode==enMode.AddNew)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtIDNumber, "Error, this ID Number is Exists with other employee  ..");
            }
            else
            {

                errorProvider1.SetError(txtIDNumber, "");
            }

        }
        private void txtContactNumber_Validating(object sender, CancelEventArgs e)
        {




            if (string.IsNullOrEmpty(txtContactNumber.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtContactNumber, "Enter Contact Number ..");
            }
            else
            {

                errorProvider1.SetError(txtContactNumber, "");
            }

        }
        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {

          
        

         
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLastName, "Enter Last Name ..");
            }
            else
            {

                errorProvider1.SetError(txtLastName, "");
            }
          

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Put the mouse in the red icon.", "Validate", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;   
            }
           

            _EmployeeInfo.FirstName = txtFirstName.Text.Trim();
            _EmployeeInfo.LastName = txtLastName.Text.Trim();
            _EmployeeInfo.Email = txtEmail.Text.Trim();
            _EmployeeInfo.ContactNumber = txtContactNumber.Text.Trim();
            _EmployeeInfo.SecondName = txtSecondName.Text.Trim();
            _EmployeeInfo.ThirdName = txtThirdName.Text.Trim();
            _EmployeeInfo.IDNumber = txtIDNumber.Text.Trim();
            _EmployeeInfo.CountryID=clsCountry.Find(cmbCountries.Text).ID;
            _EmployeeInfo.DateOfBirth=dtpDateOfBirth.Value;
            _EmployeeInfo.ImagePath=pbImagePath.ImageLocation;
            if (rbtnMale.Checked)
                _EmployeeInfo.Gendor=0;
            else
                _EmployeeInfo.Gendor=  1;


            if (_EmployeeInfo.Save())
            {
                MessageBox.Show("Employee is saved in successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lblEmployeeID.Text= _EmployeeInfo.EmployeeID.ToString() ;
                Non_Updatable();
                _Mode=enMode.Update;
                DataBack?.Invoke(_EmployeeInfo.EmployeeID);
                return;
            }else
            {
                MessageBox.Show("Employee Failed Save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void llblAddImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex=1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog()==DialogResult.OK )
            {
                if (openFileDialog1.FileName.Length>499)
                {
                    MessageBox.Show("Please Select Short Path for this Image to load it.. ", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                pbImagePath.Load(openFileDialog1.FileName);
                llblRemoveImage.Visible=true;
                
            }
        }

        private void llblRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            pbImagePath.ImageLocation = null;

            if (rbtnMale.Checked)
                pbImagePath.Image=Hotel_Mnagement_System.Properties.Resources.Male_512;
            else
                pbImagePath.Image=Hotel_Mnagement_System.Properties.Resources.Female_512;

            llblRemoveImage.Visible=false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (txtEmail.Text=="")
                return;

            if(!clsValidatoin.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format!");

            }
            else
            {
                errorProvider1.SetError(txtEmail, "");

            }
        }

        private void txtContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
