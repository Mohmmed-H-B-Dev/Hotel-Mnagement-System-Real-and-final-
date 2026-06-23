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
    public partial class frmEmployeeDetails : Form
    {
        int _EmployeeID;
        public frmEmployeeDetails(int EmployeeID)
        {
            InitializeComponent();
            _EmployeeID = EmployeeID;
        }

        private void frmEmployeeDetails_Load(object sender, EventArgs e)
        {
            ctrlEmployeeInfo1.LoadInfo(_EmployeeID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
