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

namespace Hotel_Mnagement_System.Reservations
{
    public partial class frmRenew_Reservation : Form
    {
        public frmRenew_Reservation()
        {
            InitializeComponent();
        }
        DataTable _dtReservations;


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRenew_Reservation_Load(object sender, EventArgs e)
        {
            _dtReservations=clsReservations.GetExpireReservationsForTomorrow();
            
            dgvManageReservation.DataSource = _dtReservations;


        }

        private void tsmiRenewReservation_Click(object sender, EventArgs e)
        {

            if (dgvManageReservation.Rows.Count<=0)
            {
                MessageBox.Show("There is not a Reserve to renew  it..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                frmAddNewReservation frm = new frmAddNewReservation((int)dgvManageReservation.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
                frmRenew_Reservation_Load(null, null);
            }catch (Exception ex)
            {
                MessageBox.Show("There is not a Reserve to renew it,, "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
          
        }
    }
}
