using Business_Hotel_Management_System;
using DVLD.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Mnagement_System.Users
{
    public partial class frmAddEditUser : Form
    {
        int _UserID=-1;
        int _EmployeeID = -1;
        clsUser _UserInfo = null;
        enum enUserMode { AddNew=1,Update=2}
        enUserMode _Mode = enUserMode.AddNew;
        char _PasswordChar;
        public frmAddEditUser()
        {
            InitializeComponent();
            ctrlEmployeeFiltering1.TxtFocusFilter();
            _PasswordChar=txtPassword.PasswordChar;
        }
        public frmAddEditUser(int UserId)
        {
            InitializeComponent();
            _UserID=UserId;
            _UserInfo = clsUser.FindByUserID(UserId);
            _Mode=enUserMode.Update;
            _EmployeeID=_UserInfo.EmployeeID;
            _PasswordChar =txtPassword.PasswordChar;
            txtPassword.PasswordChar = _PasswordChar;
            txtConfirmPassword.PasswordChar = _PasswordChar;
        }

        private void _LoadData()
        {
            
            ctrlEmployeeFiltering1._LoadData(_UserInfo.EmployeeID);
            ctrlEmployeeFiltering1.EmployeeFilter=false;
            txtUserName.Text=_UserInfo.UserName;
            txtPassword.Text=_UserInfo.Password;

            txtConfirmPassword.Text=_UserInfo.Password;
            lblUserID.Text=_UserInfo.UserID.ToString();
            lblEmployeeID.Text=_UserInfo.EmployeeID.ToString();
            if (_UserInfo.IsActive)
                chbIsActive.Checked=true;
            else
                chbIsActive.Checked=false;
            btnSave.Enabled =true;

            _resetValueUser();



        }
        void _resetValueUser()
        {
            txtPassword.Text="******";
            txtConfirmPassword.Text="******";
            txtConfirmPassword.Enabled=false;
            txtPassword.Enabled=false;
            chbHidePassword.Enabled=false;
            txtUserName.Enabled=false;

        }
        private void chbHidePassword_CheckedChanged(object sender, EventArgs e)
        {
          
            if (chbHidePassword.Checked)
                txtPassword.PasswordChar='*';
            else
            {
                txtPassword.PasswordChar=_PasswordChar;
            }
               
        }

        private void ctrlEmployeeFiltering1_OnSelectedEmployee(int obj)
        {
            _EmployeeID = obj;
            if (_EmployeeID==-1)
            {
                MessageBox.Show("Please Select Employee to Make User..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(clsUser.IsUserExistForPersonID(obj)&&_Mode!=enUserMode.Update)
            {
                btnSave.Enabled = false;
                btnNext.Enabled = false;
                ctrlEmployeeFiltering1.TxtFocusFilter();
                MessageBox.Show("This Employee is already User ..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_Mode!=enUserMode.Update)
            {
                btnSave.Enabled=false;
                btnNext.Enabled = true;
            }

        }

       

        private void btnNext_Click(object sender, EventArgs e)
        {

            if (ctrlEmployeeFiltering1.EmployeeID==-1)
            {
                MessageBox.Show("Please Select Employee to Make User..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsUser.IsUserExistForPersonID(_EmployeeID))
            {
                MessageBox.Show("Selected Employee is already User..", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            btnSave.Enabled =true;
            lblEmployeeID.Text=_EmployeeID.ToString();
            tabControl1.SelectedTab=tpAddUserInfo;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Put the Mouse in Red Icon to show Problem..", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_Mode==enUserMode.AddNew)
                _UserInfo =new clsUser();

            _UserInfo.UserName=txtUserName.Text;
            _UserInfo.EmployeeID=_EmployeeID;
            _UserInfo.IsActive=chbIsActive.Checked;


            if (_UserInfo.Save())
            {
                MessageBox.Show("Add New User Is Success.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblUserID.Text=_UserInfo.UserID.ToString() ;
            }
            else
            {
                MessageBox.Show("Add New User Is Filed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



            ctrlEmployeeFiltering1.EmployeeFilter=false;
            btnSave.Enabled=false;
            _resetValueUser();
        }

        private void ctrlEmployeeFiltering1_Load(object sender, EventArgs e)
        {
            if (_Mode==enUserMode.Update)
                _LoadData();
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUserName, "Please Enter New User Name..");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUserName, "");
            }


            if (clsUser.IsUserExist(txtUserName.Text)&&_Mode!=enUserMode.Update)
            {
                
                e.Cancel=true;
                errorProvider1.SetError(txtUserName, "This User Name is already exists.. Select Other User Name.");

            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUserName, "");
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword,"Please Enter Password!!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword,(string)null);
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
    
            if (txtPassword.Text!=txtConfirmPassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPassword, "Password Is Not Equals");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtConfirmPassword, "");

            }
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            ctrlEmployeeFiltering1.TxtFocusFilter();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
