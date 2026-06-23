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
    public partial class frmEmployeeFine : Form
    {
        public frmEmployeeFine()
        {
            InitializeComponent();
            ctrlEmployeeFiltering1.TxtFocusFilter();
        }
    }
}
