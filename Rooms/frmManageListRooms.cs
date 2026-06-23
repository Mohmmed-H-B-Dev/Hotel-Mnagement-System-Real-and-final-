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

namespace Hotel_Mnagement_System.Rooms
{
    public partial class frmManageListRooms : Form
    {
        public delegate void frmRoomManage(object sender, int RoomID);

        public event frmRoomManage OnRoomManage;
        DataTable _dtRooms;

        public class clsRoomDataBackEventArgs : EventArgs
        {
            public int RoomID {  get; }
            public string TypeRoom {  get; }
            public string Status { get; }
            public float Fees {   get; }

            public     clsRoomDataBackEventArgs(int RoomID,string TypeRoom,string Status,float Fees)
            {
                this.RoomID= RoomID;
                this.TypeRoom= TypeRoom;
                this.Status= Status;
                this.Fees= Fees;    
            }
        }

        //public EventHandler<clsRoomDataBackEventArgs> OnChooseRoom;
        //public void RaiseRoomDataBack(int RoomID, string TypeRoom, string Status, float Fees)
        //{
        //    RaiseRoomDataBack(new clsRoomDataBackEventArgs(RoomID,TypeRoom,Status,Fees));
        //}
        //public void RaiseRoomDataBack(clsRoomDataBackEventArgs e)
        //{ 
        //    OnChooseRoom?.Invoke(this,e);
        //}
        public frmManageListRooms()
        {
            InitializeComponent();
            ChooseRoomtoolStripMenuItem.Visible = false;

        }

        public frmManageListRooms(object PutAnyValue)
        {
            InitializeComponent();
           ChooseRoomtoolStripMenuItem.Visible = true;
        }

        private void frmManageListRooms_Load(object sender, EventArgs e)
        {
            if (!clsGlobal.CurrentUser.IsAdmin)
                btnaddroom.Visible=false;
            _dtRooms = clsRooms.GetAllRooms();
            dgvManageRoom.DataSource=_dtRooms;
            cmbFilterRooms.SelectedIndex=3;
            cmbStatusRoom.SelectedIndex=2;
            txtFilteringText.Focus();
            if (dgvManageRoom.Rows.Count>0)
            {
                dgvManageRoom.Columns[0].HeaderText="Room ID";
                dgvManageRoom.Columns[0].Width=100;
                dgvManageRoom.Columns[1].HeaderText="Type Name";
                dgvManageRoom.Columns[1].Width=150;
                dgvManageRoom.Columns[2].HeaderText="Descriptions";
                dgvManageRoom.Columns[2].Width=330;
                dgvManageRoom.Columns[3].HeaderText="Status";
                dgvManageRoom.Columns[3].Width=100;
                dgvManageRoom.Columns[4].HeaderText="Fees Day";
                dgvManageRoom.Columns[4].Width=120;
                dgvManageRoom.Columns[5].HeaderText="Fees Month";
                dgvManageRoom.Columns[5].Width=120;
                dgvManageRoom.Columns[6].HeaderText="Notes";
                dgvManageRoom.Columns[6].Width=150;
                dgvManageRoom.Columns[7].HeaderText="User ID";
                dgvManageRoom.Columns[7].Width=100;

              
            }
       
        }



        private void _MapFilteringRooms()
        {
            string ColumnFilter = "";
            switch (cmbFilterRooms.Text)
            {
                case "Room ID":
                    ColumnFilter="RoomID";
                    break;

                case "Type Room":
                    ColumnFilter="TypeName";
                    break;
                
               
                default:
                    ColumnFilter="None";
                    break;
            }


            if (txtFilteringText.Text==""||ColumnFilter=="None")
            {
                _dtRooms.DefaultView.RowFilter="";
                lblRecordCount.Text=dgvManageRoom.Rows.Count.ToString();
                return;
            }
            if (ColumnFilter=="RoomID")
            {
                _dtRooms.DefaultView.RowFilter=string.Format("[{0}] ={1}", ColumnFilter, txtFilteringText.Text);
            }
            else
                _dtRooms.DefaultView.RowFilter=string.Format("[{0}] Like '{1}%'", ColumnFilter, txtFilteringText.Text);


            lblRecordCount.Text=dgvManageRoom.Rows.Count.ToString();
        }
        private void cbStatusRoom_SelectedIndexChanged(object sender, EventArgs e)
        {


            string FilterColumn = "Status";
            string FilterValue = cmbStatusRoom.Text;

            switch (FilterValue)
            {

                case "All":
                    break;
                case "Rented":
                    FilterValue =  "Reserved";
                    break;
                case "Unrented":
                    FilterValue =  "Vacant";
                    break;
            }


            if (FilterValue == "All")
                _dtRooms.DefaultView.RowFilter = "";
            else
                //in this case we deal with numbers not string.
                _dtRooms.DefaultView.RowFilter = string.Format("[{0}] Like '{1}%'", FilterColumn, FilterValue);

            lblRecordCount.Text = dgvManageRoom.Rows.Count.ToString();


        }

        private void txtFilteringText_TextChanged(object sender, EventArgs e)
        {
            _MapFilteringRooms();
        }

        private void cmbFilterRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilterRooms.Text == "None")
            {
                txtFilteringText.Visible=false;
                cmbStatusRoom.Visible=false;
            }
            else
            {
                if (cmbFilterRooms.Text!="Status")
                {
                    txtFilteringText.Visible=true;
                    cmbStatusRoom.Visible=false;

                }
                else
                {
                    txtFilteringText.Visible=false;
                    cmbStatusRoom.Visible=true;
                }
               
            }
                
        }

        private void txtFilteringText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(cmbFilterRooms.Text=="Room ID") 
                e.Handled= !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaddroom_Click(object sender, EventArgs e)
        {
         frmAddRoomsToSystem frm =new frmAddRoomsToSystem();
         frm.ShowDialog();
            frmManageListRooms_Load(null, null);
        }

       

      

       
        private void ChooseRoomtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(dgvManageRoom.CurrentRow.Cells[3].Value)!="Vacant")
            {
                MessageBox.Show("Choose anther room Because , This  status room is >= {"+Convert.ToString(dgvManageRoom.CurrentRow.Cells[3].Value)+"} <=.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                return;

            }

            if (OnRoomManage!=null)
            {
                OnRoomManage(this, Convert.ToInt32(dgvManageRoom.CurrentRow.Cells[0].Value));
                this.Close();
            }
        }
    }
}
