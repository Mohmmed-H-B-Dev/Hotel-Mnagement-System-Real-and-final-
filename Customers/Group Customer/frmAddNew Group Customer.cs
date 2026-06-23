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

namespace Hotel_Mnagement_System.Customers.Group_Customer
{
    public partial class frmAddNew_Group_Customer : Form
    {
        int _CustomerID;
        int GroupCustomerID;
        clsGroupCustomers _GroupCustomerInfo;
        public delegate void GroupCustomerDataBack(int GroupID);
        public event GroupCustomerDataBack GC_DataBack;

        public frmAddNew_Group_Customer(int CustomerID)
        {
            InitializeComponent();
            _CustomerID = CustomerID;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddNew_Group_Customer_Load(object sender, EventArgs e)
        {
            txtCustomerID.Text = _CustomerID.ToString();
            ctrlCustomerCard1.LoadCustomerInfo(_CustomerID);
            txtCreatedByUserID.Text= clsGlobal.CurrentUser.UserID.ToString() ;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _GroupCustomerInfo=new clsGroupCustomers();
            _GroupCustomerInfo.CreatedByUserID=clsGlobal.CurrentUser.UserID; ;
            _GroupCustomerInfo.CustomerID=_CustomerID;
            _GroupCustomerInfo.TotalMembers =Convert.ToInt32(txtTotalMembers.Text);
            _GroupCustomerInfo.SpecialGroupRequests=txtSpecialRequests.Text;

            if (_GroupCustomerInfo.Save())
            {
                MessageBox.Show("Group Customer Added  Successfully. ","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);

                GC_DataBack?.Invoke(_GroupCustomerInfo.GroupID);
                btnSave.Enabled = false;
                gbGroupCustomerInfo.Enabled=false;
            }
            else
            {
                MessageBox.Show("Group Customer Added  Filed. ", "Filed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void txtTotalMembers_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled= !char.IsDigit(e.KeyChar) &&  !char.IsControl(e.KeyChar);
        }

        private void nudTotalMembers_ValueChanged(object sender, EventArgs e)
        {
            txtTotalMembers.Text=nudTotalMembers.Value.ToString();
        }
    }
}
