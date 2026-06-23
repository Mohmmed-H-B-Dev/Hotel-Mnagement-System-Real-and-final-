using Business_Hotel_Management_System;
using DVLD.Classes;
using Hotel_Mnagement_System.Customers;
using Hotel_Mnagement_System.Rooms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Hotel_Mnagement_System.global_classes;
namespace Hotel_Mnagement_System.Reservations
{
    public partial class frmManageListReservations : Form
    {
        int _RoomID;
        int _CustomerID;
        clsCustomers _Customer;
        clsRooms _Room;
        DataTable _dtReservations;
        
     

        public frmManageListReservations()
        {
            InitializeComponent();
            ExpiredReservations();
        }

        private void HandelEventLogViewer(int n1 , string Message,EventLogEntryType type)
        {
            string sourceName = "HotelManage";

            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
                Console.WriteLine("Event source Created..");

            }

            EventLog.WriteEntry(sourceName, Message+ "(... "+n1.ToString()+"...)",type);

        }
        private void frmManageListReservations_Load(object sender, EventArgs e)
        {
            _dtReservations=clsReservations.GetAllReservations();
      
            
            dgvManageReservation.DataSource = _dtReservations;
            lblRecordCount.Text=dgvManageReservation.Rows.Count.ToString();
          


         
            if(guna2npExpiredBooking.Text=="0"&& Guna2npExpireBookingForTomorrow.Text=="0")
            {
                gbExpireBooking.Visible = false;
            }
            else
            {
                gbExpireBooking.Visible = true;

                gbExpireBooking.BackColor=Color.PowderBlue;
            }
        }

        private void btnCloce_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChooseRoom_Click(object sender, EventArgs e)
        {
            frmManageListRooms frm =new frmManageListRooms(true);
            frm.OnRoomManage+=_GetRoomID;
            frm.ShowDialog();
        }
        void _CheckDataIsReadyToSave()
        {
            if (_Room!=null&& _Customer!=null)
            {
                btnAddNewReservation.Visible=true;
            }
        }
        void _GetRoomID(object sender,int RoomID)
        {
            _RoomID = RoomID;
            _Room =clsRooms.FindRoomByID(RoomID);
            if (_Room == null)
            {
                MessageBox.Show("There is Not Room to Reserve..","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            _RoomID= _Room.RoomID;  
            lblRoomID.Text = _RoomID.ToString();
            lblTypeRoom.Text=_Room.TypeRoomInfo.TypeName;
            lblStatus.Text=_Room.TextRoomStatus;
            lblFeesForDay.Text ="$"+_Room.TypeRoomInfo.FeesForDay.ToString();
            lblFeesForMonth.Text ="$"+_Room.TypeRoomInfo.FeesForMonth.ToString();
            //   _CheckDataIsReadyToSave();
        }

        void _GetCustomerID(object sender,int CustomerID)
        {
            _CustomerID=CustomerID;
            _Customer=clsCustomers.FindCustomer(_CustomerID);

            if(_Customer == null)
            {
                MessageBox.Show("There is Not Customer to Reserve..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _CustomerID= _Customer.CustomerID;
            lblCustomerID.Text = _CustomerID.ToString();
            lblVisitNumber.Text=_Customer.NumberVisit.ToString();
            lblFullName.Text= _Customer.FullName.ToString();
            lblWithGroup.Text= (_Customer.GroupCustomerInfo !=null) ? "Yas" : "No";
          //  _CheckDataIsReadyToSave();
        }

        private void btnChooseCustomer_Click(object sender, EventArgs e)
        {
            frmListAddFindCustomers frm = new frmListAddFindCustomers();
            frm.CustomerDataBack+=_GetCustomerID;
            frm.ShowDialog();

        }

        private void btnAddNewReservation_Click(object sender, EventArgs e)
        {
            frmAddNewReservation frm =new frmAddNewReservation();
            frm.ShowDialog();
            frmManageListReservations_Load(null, null);
        }

        private void tsmiEditReservations_Click(object sender, EventArgs e)
        {

            if (dgvManageReservation.Rows.Count>0)
            {
                frmAddNewReservation frm = new frmAddNewReservation((int)dgvManageReservation.CurrentRow.Cells[0].Value);
                frm.ShowDialog();
                frmManageListReservations_Load(null, null);
            }
            else
            {
                MessageBox.Show("There is not a Reserve to Update it.. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

    

        }

        private void btnRenewReservation_Click(object sender, EventArgs e)
        {
            

           

            frmRenew_Reservation frm =new frmRenew_Reservation();
            frm.ShowDialog();
            frmManageListReservations_Load(null, null);

        }



        public async Task ExpiredReservations()
        {

            try
            {



                await Task.Run(() =>
                {
                    لازم نعملها في كلاس منفصل عشان نقدر نشغلها اول مايفتح النظام ونعملها
                في الخلفية عشان لو فيه اي حد حجز وحصلت مشكلة في النظام نقدر نعرف ونرسل ايميل للعميل
                    _HanderRoomsAndExpiredReservation();
                    });

            }
            catch (Exception ex)
            {
                HandelEventLogViewer(1, "Form _Manage List Reservations  - Method _ExpiredReservations -  Error in ExpiredReservations: " + ex.Message, EventLogEntryType.Error);
         //       MessageBox.Show("Error in ExpiredReservations: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            await Task.Delay(TimeSpan.FromHours(1)); // Delay for 1 Hour before checking again
        }
       
        DataTable _ExpiredReservation;
        private bool _HanderRoomsAndExpiredReservation()
        {
            //here we will get all expired reservation and update status reservation to completed and update status room to vacant
            // and we need to add payment for each reservation with type payment is (Expired Reservation) and fees is 0
          
            //Important note
            //and we need to update this way to best way that means we write the cot get Expired reservation and
            //update status reservation and update status room in one store procedure to avoid any problem in case
            //of any error happen in the middle of the process
            _ExpiredReservation=clsReservations.GetExpiredReservations();
            لازم نعملها في كلاس منفصل عشان نقدر نشغلها اول مايفتح النظام ونعملها 
                في الخلفية عشان لو فيه اي حد حجز وحصلت مشكلة في النظام نقدر نعرف ونرسل ايميل للعميل
            if (_ExpiredReservation==null)
            return false;
            TimeSpan HoursForClient = new TimeSpan();

            foreach (DataRow row in _ExpiredReservation.Rows)
            {
                HoursForClient= ((DateTime)row["CheckOutDate"])-DateTime.Now;
                //make event and subscribe to send email or sms to
                //client to inform him that his reservation is expired and he need to check out from the room
                //and he has last 10 hours to check out from the room
                if (HoursForClient.Hours<=10)
                {
                   
                  clsMailService.
                        SubscriptionExpiredReservation(clsReservations.GetReservationByReservationID((int)row["ReservationID"]));
               
                }
                if(((DateTime)row["CheckOutDate"]) < DateTime.Now)
                {
                    // Prosses to update status room to vacant and update status reservation to completed
                    if (clsLinkedProsses.HanderRoomsAndExpiredReservation((int)row["RoomID"], clsGlobal.CurrentUser.UserID, (byte)clsRooms.enStatusRooms.enVacant,
                 (int)row["ReservationID"], (byte)clsReservations.enReservationStatus.enCompleted
                 ))
                        //Update UI fro user
                        frmManageListReservations_Load(null, null);
                }
             
               

            }

            return (UpdateRooms && UpdateExpiredReservation);
        }
        //private void btnExpiredBooking_Click(object sender, EventArgs e)
        //{

        //    if(MessageBox.Show("This Button is going to do  update status Room to (Vacant) ,, And update status reservation to (Completed).", "Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
        //    {
        //        if (MessageBox.Show("Ary you sure to update all expired reservation?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
        //        {
        //            if (_HanderRoomsAndExpiredReservation())
        //            {
        //                MessageBox.Show("The rooms were successfully evacuated.", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                frmManageListReservations_Load(null, null);
        //            }else
        //            {
                        
        //                MessageBox.Show("Evacuation of rooms was unsuccessful.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //            }
        //        }
        //    }
            


        //}



    

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {

            clsReservations r = clsReservations.GetReservationByReservationID((int)dgvManageReservation.CurrentRow.Cells[0].Value);


        }
    }
}
