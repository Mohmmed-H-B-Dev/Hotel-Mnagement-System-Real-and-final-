using Business_Hotel_Management_System;
using DVLD.People;
using Hotel_Mnagement_System.Customers.Group_Customer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Mnagement_System.Customers
{
    public partial class frmListAddFindCustomers : Form
    {
        int _CustomerID;
        string _NationalNo;
        clsCustomers _Customer;
        clsGroupCustomers _GroupCustomer;
        public delegate void frmListAddFindCustomersEventHandler(clsCustomers sender, int CustomerID);

        public event frmListAddFindCustomersEventHandler CustomerDataBack;
        public frmListAddFindCustomers()
        {
            InitializeComponent();
            btnAddCustomer.Enabled = false;
            btnClose.Enabled = false;   
        }
        public frmListAddFindCustomers(object AnyThing)
        {
            InitializeComponent();

        }


        private void frmAddFindCustomers_Load(object sender, EventArgs e)
        {
            if(!this.ValidateChildren())
            {

                txtSearchCustomer.Focus();

            }


          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_Customer!=null)
                CustomerDataBack?.Invoke(_Customer, _CustomerID);

            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (_Customer==null)
                _Customer=new clsCustomers();
            if (string.IsNullOrEmpty(_Customer.SpecialRequests))
                txtUpdateSpecialRequests.Text="None.";
            else
                txtUpdateSpecialRequests.Text=_Customer.SpecialRequests;
            txtSearchCustomer.Enabled=true;
            lblTitleSpecialRequests.Enabled=true;

            if (ctrlCustomerCard1.CustomerID!=-1)
                btnAddGroup.Enabled=true;
            else
                btnAddGroup.Enabled =false;

            _GroupCustomer=_Customer.GroupCustomerInfo;
            if (_GroupCustomer!=null)
            {
                _LoadGroupCustomerData();
            }
            btnAddCustomer.Enabled=true;
            btnClose.Enabled=true;
            this.AcceptButton=btnAddCustomer;
        }

        private void txtSearchCustomer_Validating(object sender, CancelEventArgs e)
        {
           if(string .IsNullOrEmpty(txtSearchCustomer.Text))
            {
                errorProvider1.SetError(txtSearchCustomer, "Please Enter (ID Number) To Find Customer.");
                btnSearch.Enabled=false;
              
                return;
            }
            else
            {
                errorProvider1.SetError(txtSearchCustomer, "");
                btnSearch.Enabled=true;

            }


            _Customer=clsCustomers.FindCustomer(txtSearchCustomer.Text.Trim());
            if (_Customer==null)
            {
                errorProvider1.SetError(txtSearchCustomer, "There is not Customer with ID Number ("+txtSearchCustomer.Text+")..");
               
            }
            else
            {
                errorProvider1.SetError(txtSearchCustomer, "");
                _ResetGroupCustomerData();
                ctrlCustomerCard1.LoadCustomerInfo(_Customer);
                _CustomerID=ctrlCustomerCard1.CustomerID;
              
            }

        }

       

        private void txtSearchCustomer_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchCustomer.Text))
            {
                btnSearch.Enabled=false;
             
            }
            else
            {
               
                btnSearch.Enabled=true;
            }

        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddUpdateCustomer frmAddUpdateCustomer = new frmAddUpdateCustomer();
            frmAddUpdateCustomer.DataBack+=_DataBackFromAddNewCustomer;
            frmAddUpdateCustomer.ShowDialog();
           
        }

        void _DataBackFromAddNewCustomer(object sender, int CustomerID)
        {
            _CustomerID= CustomerID;
            _Customer=clsCustomers.FindCustomer(CustomerID);

            txtSearchCustomer.Text=_Customer.IDNumber;
            ctrlCustomerCard1.LoadCustomerInfo(_Customer);
            if(string.IsNullOrEmpty(_Customer.SpecialRequests))
            txtUpdateSpecialRequests.Text="None.";
            else
                txtUpdateSpecialRequests.Text=_Customer.SpecialRequests;
            txtSearchCustomer.Enabled=true;
            lblTitleSpecialRequests.Enabled=true;
            if(ctrlCustomerCard1.CustomerID!=-1)
                btnAddGroup.Enabled=true;
            else
                btnAddGroup.Enabled =false;
            _ResetGroupCustomerData();

            btnAddCustomer.Enabled=true;
            btnClose.Enabled=true;
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            if (_GroupCustomer!=null)
            {
                MessageBox.Show("You has already Group Customer is Active.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            frmAddNew_Group_Customer frm = new frmAddNew_Group_Customer(_CustomerID);
            frm.GC_DataBack+=DataBackAddedGroupCustomer;
            frm.ShowDialog();
        }

        private void  DataBackAddedGroupCustomer(int GroupID)
        {
            if (GroupID<=0)
            {
                MessageBox.Show("GroupID is Empty, Contact Admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _Customer.GroupCustomerID = GroupID;
            txtSearchCustomer.Enabled = false;
            btnAddGroup.Enabled=false;
            btnAddNewCustomer.Enabled=false;
            btnSearch.Enabled=false;
            _GroupCustomer=clsGroupCustomers.GetGroupCustomerByGroupID(GroupID);
            _LoadGroupCustomerData();


        }
        void _LoadGroupCustomerData()
        {
           
            if (_GroupCustomer != null)
            {
                lblGroupID.Text=_GroupCustomer.GroupID.ToString();
                txtGroupSepcialRequests.Text=_GroupCustomer.SpecialGroupRequests;
                lblTotalMembers.Text=_GroupCustomer.TotalMembers.ToString();
            }
        }

        void _ResetGroupCustomerData()
        {
            lblGroupID.Text="[????]";
            lblTotalMembers.Text="[????]";
            txtGroupSepcialRequests.Text="None";
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (_Customer!=null)
                CustomerDataBack?.Invoke(_Customer, _CustomerID);

            this.Close();
        }

        private void btnUpdateSpecialRequests_Click(object sender, EventArgs e)
        {
            if (_CustomerID>=1)
            {
                clsCustomers.Update_SpecialRequestsCustomer(_CustomerID, txtUpdateSpecialRequests.Text);
                if (clsCustomers.Update_SpecialRequestsCustomer(_CustomerID, txtUpdateSpecialRequests.Text)&&
                    _GroupCustomer!=null)
                {
                    if (clsGroupCustomers.UpdateSpecialRequestsCustomer(_GroupCustomer.GroupID, txtUpdateSpecialRequests.Text))
                    {
                        MessageBox.Show("Update Special Requests is Success..", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Update Special Requests is Felid..", "Felid", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }
    }
}
