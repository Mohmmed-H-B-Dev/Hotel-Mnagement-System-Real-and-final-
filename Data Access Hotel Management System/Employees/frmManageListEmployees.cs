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

namespace Hotel_Mnagement_System.Employees
{
    public partial class frmManageListEmployees : Form
    {
        DataTable _dtEmployeesData = new DataTable();
        public frmManageListEmployees()
        {
            InitializeComponent();
        }

        private void frmManageListEmployees_Load(object sender, EventArgs e)
        {

            _dtEmployeesData=clsEmployees.GetAllEmployees();
            dgvManageEmployee.DataSource = _dtEmployeesData;
            cmbFilterEmployees.SelectedIndex=0;
            if(dgvManageEmployee.Rows.Count > 0 )
            {
            dgvManageEmployee.Columns[0].HeaderText="Employee ID";
            dgvManageEmployee.Columns[0].Width=90;
            dgvManageEmployee.Columns[1].HeaderText="Full Name";
            dgvManageEmployee.Columns[1].Width=300;
            dgvManageEmployee.Columns[2].HeaderText="ID Number";
            dgvManageEmployee.Columns[2].Width=120;
            dgvManageEmployee.Columns[3].HeaderText="Date Of Birth";
            dgvManageEmployee.Columns[3].Width=190;
            dgvManageEmployee.Columns[4].HeaderText="Gendor";
            dgvManageEmployee.Columns[4].Width=80;
            dgvManageEmployee.Columns[5].HeaderText="Email";
            dgvManageEmployee.Columns[5].Width=150;
            dgvManageEmployee.Columns[6].HeaderText="Contact Number";
            dgvManageEmployee.Columns[6].Width=150;
            dgvManageEmployee.Columns[7].HeaderText="Country Name";
            dgvManageEmployee.Columns[7].Width=190;

           }

            lblRecordCount.Text=dgvManageEmployee.Rows.Count.ToString();
        }

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            frmAddNewEditEmployee frm = new frmAddNewEditEmployee();
            frm.ShowDialog();
        }
        private void _MapFilteringEmployees()
        {
            string ColumnFilter = "";
            switch (cmbFilterEmployees.Text)
            {
                case "Employee ID":
                    ColumnFilter="EmployeeID";
                    break;

                case "ID Number":
                    ColumnFilter="IDNumber";
                    break;
                case "Full Name":
                    ColumnFilter="FullName";
                    break;
                case "Gendor":
                    ColumnFilter="Gendor";
                    break;
                case "Country Name":
                    ColumnFilter="CountryName";
                    break;
                default:
                    ColumnFilter="None";
                    break;
            }


            if (txtFilteringText.Text==""||ColumnFilter=="None")
            {
                _dtEmployeesData.DefaultView.RowFilter="";
                lblRecordCount.Text=dgvManageEmployee.Rows.Count.ToString();
                return;
            }
            if (ColumnFilter=="EmployeeID")
            {
                _dtEmployeesData.DefaultView.RowFilter=string.Format("[{0}] ={1}", ColumnFilter, txtFilteringText.Text);
            }
            else
                _dtEmployeesData.DefaultView.RowFilter=string.Format("[{0}] Like '{1}%'", ColumnFilter, txtFilteringText.Text);


            lblRecordCount.Text=dgvManageEmployee.Rows.Count.ToString();
        }
        private void btnCloce_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void txtFilteringText_TextChanged(object sender, EventArgs e)
        {
            _MapFilteringEmployees();
        }

        private void cmbFilterEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterEmployees.Text == "None")
            {
                txtFilteringText.Visible=false;

            }
            else
                txtFilteringText.Visible=true ;
        }

   

        private void cmsEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tsmiShowDetalis_Click(object sender, EventArgs e)
        {
            frmEmployeeDetails frm =new frmEmployeeDetails((int)dgvManageEmployee.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
        }

        private void tmsiDeleteEmployee_Click(object sender, EventArgs e)
        {
           int EmployeeIdToDelete=(int)dgvManageEmployee.CurrentRow.Cells[0].Value;

            
            if (MessageBox.Show("Are You Sure You Want Delete This Employee.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.No)
                return;

            if (clsEmployees.DeleteEmployees(EmployeeIdToDelete))
            {
                MessageBox.Show("Employee Deleted Is Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmManageListEmployees_Load(null, null);
                return;
            }
            else
            {
                MessageBox.Show("Employee Deleted Is Filed.", "Filed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tsmiAddNewEmployee_Click(object sender, EventArgs e)
        {
            frmAddNewEditEmployee frm =new frmAddNewEditEmployee(); 
            frm.ShowDialog();

            frmManageListEmployees_Load(null, null);

        }

        private void tsmiEditEmployee_Click(object sender, EventArgs e)
        {
            frmAddNewEditEmployee frm =new frmAddNewEditEmployee((int)dgvManageEmployee.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            frmManageListEmployees_Load(null, null);
        }
    }
}
