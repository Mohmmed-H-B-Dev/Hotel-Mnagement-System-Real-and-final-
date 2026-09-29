using Business_Hotel_Management_System;
using DVLD.Classes;
using DVLD.Login;
using DVLD.User;
using Hotel_Mnagement_System.Customers;
using Hotel_Mnagement_System.Employees;
using Hotel_Mnagement_System.global_classes;
using Hotel_Mnagement_System.Reservations;
using Hotel_Mnagement_System.Rooms;
using Hotel_Mnagement_System.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Mnagement_System
{
    public partial class frmMain : Form
    {
        frmLogin _frmLogin;
        public frmMain(frmLogin frmLogin)
        {
            InitializeComponent();
            _frmLogin = frmLogin;
        }

        


      
        private void manageReservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageListReservations frm = new frmManageListReservations();
            frm.ShowDialog();
        }

   

       

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListAddFindCustomers frm =new frmListAddFindCustomers();
       
            frm.ShowDialog();
        }
        
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            clsGlobal.CurrentUser=null;
            _frmLogin.Show();
           
        }

        private void myInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserr_Info frm = new frmUserr_Info(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();

        }

        private void chanagPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm =new frmChangePassword(clsGlobal.CurrentUser.UserID);
            frm.ShowDialog();
        }
        void _SittingIsAdminOrNot()
        {
            if (!clsGlobal.CurrentUser.IsAdmin)
            {
           

                tcManger.Visible = false;
                manageCustomersToolStripMenuItem.Text="Customers";
                manageReservationsToolStripMenuItem.Text="Reservations";
                manageRoomsToolStripMenuItem.Text="Rooms";

            }
            else
            {

                tcManger.Visible = true;

                manageReservationsToolStripMenuItem.Text="Manage Reservations";
                manageCustomersToolStripMenuItem.Text="Manage Customers";
                manageRoomsToolStripMenuItem.Text="Manage Rooms";
            }
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            cls_HandelRoomsAndExpiredReservation.Start();
            _SittingIsAdminOrNot();
        }

        private void manageRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageListRooms frm =new frmManageListRooms();
          //  frm.OnRoomManage+=tsts;
            frm.ShowDialog();   
        }

    

        private void manageEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageListEmployees frm = new frmManageListEmployees();
            frm.ShowDialog();
        }

        private void manageUsersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmList_User_Managment frm = new frmList_User_Managment();
            frm.ShowDialog();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is not implemented yet!");
        }
    }
}
