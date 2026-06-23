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

namespace Hotel_Mnagement_System.Rooms
{
    public partial class frmAddRoomsToSystem : Form
    {
        int _RoomID;
        clsRooms _RoomInfo;

        public frmAddRoomsToSystem()
        {
            InitializeComponent();
            _RoomInfo = new clsRooms();
            lblUserName.Text=clsGlobal.CurrentUser.UserName;
        }


        private void _LoadCountriesToComboBox()
        {
            DataTable dt = new DataTable();

            dt=clsTypeRooms.GetAllTypeRooms();

            foreach (DataRow row in dt.Rows)
            {
                cmbTypeRooms.Items.Add(row["TypeName"].ToString());
            }
        }

        private void frmAddRoomsToSystem_Load(object sender, EventArgs e)
        {
            _LoadCountriesToComboBox();
            cmbTypeRooms.SelectedIndex=0;
            lblStatus.Text="Vacant";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void _ResetRoomClassData()
        {
            _RoomInfo= new clsRooms();
            _RoomID=-1;
            cmbTypeRooms.SelectedIndex=0;
            lblRoomID.Text="[????]";
            lblStatus.Text="Vacant";
            lblUserName.Text=clsGlobal.CurrentUser.UserName;
            txtNotes.Text="Write Here!!";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           

            _RoomInfo.CreatedByUserID=clsGlobal.CurrentUser.UserID;
            _RoomInfo.RoomStatus=clsRooms.enStatusRooms.enVacant;
            _RoomInfo.Notes=txtNotes.Text;
            _RoomInfo.TypeRoomID=clsTypeRooms.FindTypeRoom(cmbTypeRooms.Text).TypeRoomID;

            if (_RoomInfo.Save())
            {
                lblRoomID.Text=_RoomInfo.RoomID.ToString();
                _RoomID=_RoomInfo.RoomID;
                MessageBox.Show("Adding Room Data is Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _ResetRoomClassData();
            }
            else
            {
                MessageBox.Show("Adding Room Data is Field.", "Field", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void txtNotes_MouseLeave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNotes.Text))
            txtNotes.Text="Write Here!!";
        }

        private void txtNotes_MouseMove(object sender, MouseEventArgs e)
        {
            if (txtNotes.Text=="Write Here!!")
                txtNotes.Clear();
        }




    
    }
}
