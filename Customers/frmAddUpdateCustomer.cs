using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_Mnagement_System.Properties;

using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Runtime.ConstrainedExecution;
using Business_Hotel_Management_System;
using DVLD_Buisness;
using DVLD.Classes;

namespace DVLD.People
{
    public partial class frmAddUpdateCustomer : Form
    {

        // Declare a delegate
        public delegate void DataBackEventHandler(object sender, int PersonID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;

        public enum enMode { AddNew = 0, Update = 1 };
        public enum enGendor { Male = 0, Female = 1 };

        private enMode _Mode;
        private int _CustomerID = -1;
        clsCustomers _Customer;

        public frmAddUpdateCustomer()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;

        }

        public frmAddUpdateCustomer(int CustomerID)
        {
            InitializeComponent();

            _Mode = enMode.Update;
            _CustomerID = CustomerID;
        }

        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values
            _FillCountriesInComoboBox();

            if (_Mode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Customer";
                _Customer = new clsCustomers();
            } 
            else
            {
                lblTitle.Text = "Update Customer";
            }

            //set default image for the person.
            //if (rbMale.Checked)
            //    pbPersonImage.Image = Resources.Male_512;
            //else
            //    pbPersonImage.Image = Resources.Female_512;

            //hide/show the remove linke incase there is no image for the person.
           // llRemoveImage.Visible = (pbPersonImage.ImageLocation != null);

            //we set the max date to 18 years from today, and set the default value the same.
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            //should not allow adding age more than 100 years
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            //this will set default country to jordan.
            cbCountry.SelectedIndex = cbCountry.FindString("Yemen");

            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtNationalNo.Text = "";
            rbMale.Checked = true;
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtSpecialRequests.Text = "";


        }

        private void _FillCountriesInComoboBox()
        {
            DataTable dtCountries = clsCountry.GetAllCountries();

            foreach (DataRow row in dtCountries.Rows)
            {
                cbCountry.Items.Add(row["CountryName"]);
            }
        }

        private void _LoadData()
        {
           
            _Customer = clsCustomers.FindCustomer(_CustomerID);

            if (_Customer == null)
            {
                MessageBox.Show("No Customer with ID = " + _CustomerID, "Person Not Found",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            //the following code will not be executed if the person was not found
            lblCustomerID.Text = _CustomerID.ToString();
            txtFirstName.Text = _Customer.FirstName;
            txtSecondName.Text = _Customer.SecondName;
            txtThirdName.Text = _Customer.ThirdName;
            txtLastName.Text = _Customer.LastName;
            txtNationalNo.Text =    _Customer.IDNumber;
            dtpDateOfBirth.Value = _Customer.DateOfBirth;
            
            if (_Customer.Gendor == 0)
                rbMale.Checked= true;
            else
                rbFemale.Checked = true;

            txtSpecialRequests.Text = _Customer.SpecialRequests;
            txtPhone.Text = _Customer.ContactNumber;
            txtEmail.Text = _Customer.Email;
            cbCountry.SelectedIndex = cbCountry.FindString(_Customer.CountryInfo.CountryName);

          
            //load person image incase it was set.
            //if (_Customer.ImagePath != "")
            //{
            //    pbPersonImage.ImageLocation = _Customer.ImagePath;

            //}

            //hide/show the remove linke incase there is no image for the person.
           // llRemoveImage.Visible = (_Customer.ImagePath != ""); 

        }

        private void frmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();

            if(_Mode==enMode.Update)
                _LoadData();
        }

        //private bool _HandleCustomerImage()
        //{

        //    //this procedure will handle the person image,
        //    //it will take care of deleting the old image from the folder
        //    //in case the image changed. and it will rename the new image with guid and 
        //    // place it in the images folder.

          
        //        //_Person.ImagePath contains the old Image, we check if it changed then we copy the new image
        //        if (_Customer.ImagePath != pbPersonImage.ImageLocation)
        //        {
        //            if (_Person.ImagePath != "")
        //            {
        //            //first we delete the old image from the folder in case there is any.

        //                try
        //                {
        //                    File.Delete(_Person.ImagePath);
        //                }
        //                catch (IOException)
        //                {
        //                    // We could not delete the file.
        //                    //log it later   
        //                }
        //        }

        //            if (pbPersonImage.ImageLocation != null)
        //            {
        //                //then we copy the new image to the image folder after we rename it
        //                string SourceImageFile=pbPersonImage.ImageLocation.ToString();

        //                if (clsUtil.CopyImageToProjectImagesFolder(ref SourceImageFile))
        //                {
        //                    pbPersonImage.ImageLocation = SourceImageFile;
        //                     return true;
        //                }
        //                else
        //                {
        //                    MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                    return false;
        //                }
        //            }

        //        }
        //    return true;
        //}

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {
                //Here we dont continue becuase the form is not valid
                MessageBox.Show("Some fields are not valid!, put the mouse over the red icon(s) to see the erro","Validation Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;

            }

           //if (! _HandleCustomerImage())
           //     return;

            int NationalityCountryID = clsCountry.Find(cbCountry.Text).ID;

            _Customer.FirstName = txtFirstName.Text.Trim();
            _Customer.SecondName = txtSecondName.Text.Trim();
            _Customer.ThirdName = txtThirdName.Text.Trim();
            _Customer.LastName = txtLastName.Text.Trim();
            _Customer.IDNumber = txtNationalNo.Text.Trim() ;
            _Customer.Email = txtEmail.Text.Trim();
            _Customer.ContactNumber = txtPhone.Text.Trim();
            _Customer.SpecialRequests = txtSpecialRequests.Text.Trim();
            _Customer.DateOfBirth = dtpDateOfBirth.Value;
            _Customer.CreatedByUserID=clsGlobal.CurrentUser.UserID;
           
            if (rbMale.Checked)
                _Customer.Gendor = (byte) enGendor.Male;
            else
                _Customer.Gendor = (byte) enGendor.Female;

            _Customer.CountryID = NationalityCountryID;
            
            //if (pbPersonImage.ImageLocation != null)
            //    _Customer.ImagePath = pbPersonImage.ImageLocation;
            //else
            //    _Customer.ImagePath = "";

            if (_Customer.Save())
            {
                 lblCustomerID.Text = _Customer.CustomerID.ToString();
                //change form mode to update.
                _Mode = enMode.Update;
                lblTitle.Text = "Update Customer";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled=false;
    
                // Trigger the event to send data back to the caller form.
                DataBack?.Invoke(this, _Customer.CustomerID);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            
            
        }

        //private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        //{
        //    openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
        //    openFileDialog1.FilterIndex = 1;
        //    openFileDialog1.RestoreDirectory = true;

        //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //    {
        //        // Process the selected file
        //        string selectedFilePath = openFileDialog1.FileName;
        //        pbPersonImage.Load(selectedFilePath);
        //        llRemoveImage.Visible = true;
        //        // ...
        //    }
        //}

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
            //pbPersonImage.ImageLocation = null;
          


            //if (rbMale.Checked)
            //    pbPersonImage.Image = Resources.Male_512;
            //else
            //    pbPersonImage.Image = Resources.Female_512;

            //llRemoveImage.Visible = false;
        }

        private void rbFemale_Click(object sender, EventArgs e)
        {
           //change the defualt image to female incase there is no image set.
            //if (pbPersonImage.ImageLocation == null)
            //    pbPersonImage.Image = Resources.Female_512;
        }

        private void rbMale_Click(object sender, EventArgs e)
        {
            //change the defualt image to male incase there is no image set.
            //if (pbPersonImage.ImageLocation == null)
              //  pbPersonImage.Image = Resources.Male_512;
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {

            // First: set AutoValidate property of your Form to EnableAllowFocusChange in designer 
            TextBox Temp = ((TextBox) sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                //e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            //no need to validate the email incase it's empty.
            if (txtEmail.Text.Trim() == "")
                return;

            //validate email format
            if (!clsValidatoin.ValidateEmail(txtEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtEmail, "Invalid Email Address Format!");
            }
           else
            { 
                errorProvider1.SetError(txtEmail, null); 
            };

        }

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(txtNationalNo, null);
            }

            //Make sure the national number is not used by another person
            if (txtNationalNo.Text.Trim() != _Customer.IDNumber && clsCustomers.IsCustomerExist(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNationalNo, "Customer is Exists before !");
                btnSave.Enabled=false;
            }
            else
            {
                btnSave.Enabled=true;
                errorProvider1.SetError(txtNationalNo, null);
            }
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }

    }
