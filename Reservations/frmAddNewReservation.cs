using Business_Hotel_Management_System;
using DVLD.Classes;
using Hotel_Mnagement_System.Customers;
using Hotel_Mnagement_System.global_classes;
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

namespace Hotel_Mnagement_System.Reservations
{
    public partial class frmAddNewReservation : Form
    {
        clsPayments.clsFeesInfo _FeesInfo;

        int _RoomID;
        int _CustomerID;
        clsCustomers _Customer;
        clsRooms _Room;
        int _ReservationID = -1;
        float PaidFees=0;
        clsReservations _Reservation;
        enum enMod { enAdd = 1, enUpdate = 2 }
        enMod _Mode = enMod.enAdd;
        public frmAddNewReservation()
        {
            InitializeComponent();
            txtStatus.Text="New";
            _Mode = enMod.enAdd;
            this.Text ="Add New Reservation.";
           
        }
        public frmAddNewReservation(int ReservationID)
        {
            InitializeComponent();
            _ReservationID = ReservationID;
            _Mode = enMod.enUpdate;
            this.Text ="Update Reservation.";
        }

        void _LoadData()
        {
            clsPayments Pym =clsPayments.FindPaymentByReservationID(_ReservationID);

            _Reservation=Pym.ReservationInfo;
            if ( _Reservation == null )
            {
                MessageBox.Show("Reservation Date is Empty..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblRoomID.Text=Pym.ReservationInfo.RoomID.ToString();
           lblCustomerID.Text= _Reservation.CustomerID.ToString();
            lblDataFrom.Text=_Reservation.CheckInDate.ToShortDateString();
           lblToDate.Text=_Reservation.CheckOutDate.ToShortDateString() ;
           
            txtStatus.Text=_Reservation.TextStatus;
            txtTotalFees.Text=_Reservation.FeesInfo.TotalPaid.ToString("C");
           txtNotes.Text=  _Reservation.Notes;

            txtTotalFeesAfterDiscount.Text= _Reservation.FeesInfo.TotalAfterDiscount.ToString("C");
            txtTotalBasicFees.Text=( _Reservation.FeesInfo.AmountVAT+ _Reservation.FeesInfo.TotalAfterDiscount).ToString("C");

            txtFeesDiscount.Text=_Reservation.FeesInfo.AmountDiscount.ToString("C");
            txtVAT.Text=_Reservation.FeesInfo.AmountVAT.ToString("C");

            lblCreatedByUserID.Text=_Reservation.CreatedByUserID.ToString();
            _Room=_Reservation.RoomInfo;
            _Customer= _Reservation.CustomerInfo;
            _GotRoomInfo(_Reservation.RoomInfo);
           _GotCustomerInfo(_Reservation.CustomerInfo);
           
            _ResetDateTimeToReservation();
        }
        void _ResetDateTimeToReservation()
        {
            dtpFromDate.MinDate = DateTime.Now;
            dtpToDate.MinDate =DateTime.Now;
            dtpToDate.MaxDate =dtpToDate.MinDate.AddDays(90);
        }
        private void frmAddNewReservation_Load(object sender, EventArgs e)
        {
            if (_Mode!=enMod.enAdd)
            {
                _LoadData();
                gbBasicInfoAdd.Enabled = true;
                pControl_Grouptxt.Enabled = false;  
                gbFilterByDayOrMonth.Enabled=false;
                return;

            }
            _ResetDateTimeToReservation();
            btnAddBooking.Enabled = false;
            this.AcceptButton=btnChooseRoom;
        }

       
       

        private void btnChooseRoom_Click(object sender, EventArgs e)
        {
            frmManageListRooms frm = new frmManageListRooms(true);
            frm.OnRoomManage+=_GetRoomID;
            frm.ShowDialog();
            this.AcceptButton=btnChooseCustomer;
            txtTotalBasicFees.Text="$000,000";
        }
      
        void _GetRoomID(object sender, int RoomID)
        {
            _RoomID = RoomID;
            _Room =clsRooms.FindRoomByID(RoomID);
            if (_Room == null)
            {
                MessageBox.Show("There is Not Room to Reserve..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (clsReservations.IsReservationExistByRoomID(_RoomID))
            {
                MessageBox.Show("The room is reserved for another customer,Choose another room..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _GotRoomInfo(_Room);
        }
        void _GotRoomInfo(clsRooms _Room)
        {
            if (_Room == null)
            {
                MessageBox.Show("There is Not Room to Reserve..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblRoomID.Text = _RoomID.ToString();
            lblTypeRoom.Text=_Room.TypeRoomInfo.TypeName;
            lblStatus.Text=_Room.TextRoomStatus;
            lblFeesForDay.Text ="$"+_Room.TypeRoomInfo.FeesForDay.ToString();
            lblFeesForMonth.Text ="$"+_Room.TypeRoomInfo.FeesForMonth.ToString();
            //   _CheckDataIsReadyToSave();
            if (_Customer!=null)
            {
                gbFilterByDayOrMonth.Enabled = true;

            }
        }

        void _GetCustomerID(object sender, int CustomerID)
        {
            _CustomerID=CustomerID;
            _Customer=clsCustomers.FindCustomer(_CustomerID);

            if (_Customer == null)
            {
                MessageBox.Show("There is Not Customer to Reserve..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            {
                //if (clsReservations.IsReservationExistByCustomerID(_CustomerID))
                //{
                //    MessageBox.Show("This Customer has Reservation be for,Choose another Customer..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
            }

            _GotCustomerInfo(_Customer);
        }
        void _GotCustomerInfo(clsCustomers _Customer)
        {
            if (_Customer == null)
            {
                MessageBox.Show("There is Not Customer to Reserve..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblCustomerID.Text = _Customer.CustomerID.ToString();
            lblVisitNumber.Text=_Customer.NumberVisit.ToString();
            lblFullName.Text= _Customer.FullName.ToString();
            lblWithGroup.Text= (_Customer.GroupCustomerInfo !=null) ? "Yas" : "No";
            //  _CheckDataIsReadyToSave();
            if (_Room!=null)
            {

                gbFilterByDayOrMonth.Enabled = true;

            }
        }
        private void btnChooseCustomer_Click(object sender, EventArgs e)
        {
            frmListAddFindCustomers frm = new frmListAddFindCustomers();
            frm.CustomerDataBack+=_GetCustomerID;
            frm.ShowDialog();
        }

        private void btnSave_MouseMove(object sender, MouseEventArgs e)
        {
            if((!btnChooseCustomer.Enabled)&& (_Customer==null))
            {
                MessageBox.Show("Please choose { customer } to continue..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ((!btnChooseCustomer.Enabled)&& (_Room==null))
            {
                MessageBox.Show("Please choose  { Room } to continue..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        float _CalculateFeesAfterDiscount(int Days, float DiscountRate)
        {
            float TotalFees = _Room.TypeRoomInfo.FeesForDay* Days;
                        return ((  (TotalFees*DiscountRate)));
        }
        private void rbtnForMonth_CheckedChanged(object sender, EventArgs e)
        {
            _ResetDateTimeToReservation();
            gbBasicInfoAdd.Enabled=true;    
        }

        private void rbtnForDays_CheckedChanged(object sender, EventArgs e)
        {
            _ResetDateTimeToReservation();

            gbBasicInfoAdd.Enabled=true;
        }

        private  void btnCalculateTheTotalFees_Click(object sender, EventArgs e)
        {
            if (_Room==null)
                return;

            int CountDays = clsDate.CalculateTheCostOfRentingFor_90_MaxDate_(dtpFromDate.Value, dtpToDate.Value);
            float VAT = clsSideNecessities.VAT_Rate();
            float TotalFees = 0;
            float TotalFeesAfterDiscount = 0;
            TotalFees = _Room.TypeRoomInfo.FeesForDay*CountDays;
            float DiscountFees = 0;
            float DiscountRate=clsSideNecessities.BasicDiscountForMonths_Rate();
            float AmountVAT = 0;
            if (CountDays>30)
            {
                DiscountFees = _CalculateFeesAfterDiscount(CountDays, DiscountRate);
                TotalFeesAfterDiscount =TotalFees-DiscountFees;
                txtTotalBasicFees.Text=TotalFees.ToString("C");
                txtTotalFeesAfterDiscount.Text=TotalFeesAfterDiscount.ToString("C"); ;
                txtFeesDiscount.Text=DiscountFees.ToString("C");
                txtVAT.Text=(AmountVAT=TotalFeesAfterDiscount*VAT).ToString("C");
            }
            else
            {

                TotalFees = _Room.TypeRoomInfo.FeesForDay*CountDays;
                txtTotalBasicFees.Text=TotalFees.ToString("C");
                txtTotalFeesAfterDiscount.Text=txtTotalBasicFees.Text;
                txtVAT.Text=(AmountVAT=TotalFees*VAT).ToString("C");

            }

            if(_Customer!=null &&_Room!=null)
            btnAddBooking.Enabled=true; 
            btnCalculateTheTotalFees.Enabled=false;
          
            if (TotalFeesAfterDiscount==0)
                PaidFees=TotalFees;
            else
                PaidFees=TotalFeesAfterDiscount;
            txtTotalFees.Text= txtTotalFeesAfterDiscount.Text;
            _FeesInfo=new clsPayments.clsFeesInfo(TotalFees, TotalFeesAfterDiscount, DiscountFees, DiscountRate, AmountVAT, VAT, clsPayments.enTypePayment.Cash);


            // MessageBox.Show("Days = "+CountDays.ToString()+"\n\n   Months = "+CountMonths.ToString());
            //  _HandelDateFeesAll();
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            if (clsReservations.IsReservationExistByRoomID(_RoomID))
            {
                MessageBox.Show("The room is reserved for another customer,Choose another room..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_Mode==enMod.enAdd)
            {
                _Reservation=new clsReservations();
                _Reservation.RoomID=_RoomID;
                _Reservation.CustomerID=_CustomerID;
                _Reservation.DateTime=DateTime.Now;
                _Reservation.Status=clsReservations.enReservationStatus.enNew;
            }
             

           
            
            _Reservation.LastDateTime=DateTime.Now;
            _Reservation.CheckInDate=dtpFromDate.Value;
            _Reservation.CheckOutDate=dtpToDate.Value;
          
            _Reservation.PaidFees=PaidFees;
            _Reservation.Notes=txtNotes.Text;
            _Reservation.FeesInfo=_FeesInfo;
            _Reservation.CreatedByUserID=clsGlobal.CurrentUser.UserID;
            clsMailService.Subscription(_Reservation);
            if (_Reservation.Save())
            {
                MessageBox.Show("Add new Reservation Date is Success.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ReservationID=_Reservation.ReservationID;
                txtReservationID.Text=_ReservationID.ToString() ;
                gbC_R.Enabled=false;
                gbFilterByDayOrMonth.Enabled=false;
                btnAddBooking.Enabled=false;
                lblCreatedByUserID.Text=_Reservation.CreatedByUserID.ToString();

            }
            else
            {
                MessageBox.Show(" ReservationDate is Felid.", "Felid", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dtpFromDate_ValueChanged(object sender, EventArgs e)
        {
            btnCalculateTheTotalFees.Enabled=true;
            btnAddBooking.Enabled=false;

        }

        private void dtpToDate_ValueChanged(object sender, EventArgs e)
        {
            btnCalculateTheTotalFees.Enabled=true;
            btnAddBooking.Enabled=false;

        }
    }
}
