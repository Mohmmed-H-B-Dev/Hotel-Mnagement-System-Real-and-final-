using Data_Access_Hotel_Management_System;
using Hotle_Management_Library;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Hotel_Management_System
{
    public  class clsReservations
    {
        public event EventHandler<ReservationEventArgs> OnReservationsAdd;

        public event EventHandler<ReservationEventArgs> OnReservationsExpired;

        public enum enMode { enAddNew=1,enUpdate=2}
        public enum enReservationStatus {enEmpty=-1,enNew=1, enCompleted=3,enCancelled=2 }

        enMode _Mode = enMode.enAddNew;
        public int ReservationID {  get; set; }
        private int _RoomID { get; set; }

        public int RoomID { get { return _RoomID; } set { _RoomID=value;
                this.RoomInfo=clsRooms.FindRoomByID(_RoomID);
            } }
        public clsRooms RoomInfo { get; set; }
        public string TextStatus
        {
            get
            {
                switch (Status)
                {
                    case enReservationStatus.enNew:
                        return "New";
                    case enReservationStatus.enCancelled:
                        return "Cancelled";
                    case enReservationStatus.enCompleted:
                        return "Completed";
                    default:
                        return "Empty";
                }
            }
        }
        private int _CustomerID { get; set; }
        public int CustomerID { get { return _CustomerID; } set { _CustomerID=value;

                this.CustomerInfo=clsCustomers.FindCustomer(_CustomerID);
            } }
        public clsCustomers CustomerInfo { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime LastDateTime {  get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public enReservationStatus Status {  get; set; }    
        public float PaidFees {  get; set; }
        public string Notes {  get; set; }
        private int  _CreatedByUserID { set; get; }
        private Hotle_Management_Library.clsReservationLibrary _ReservationLibraryInfo { set; get; }
        public int CreatedByUserID { get { return _CreatedByUserID; } set {
                _CreatedByUserID=value;
                this.UserInfo=clsUser.FindByUserID(value); } }
        public clsUser UserInfo {  get; set; }

 
        public clsPayments.enTypePayment TypePayment { get; set; }
        public clsReservations(int ReservationID,int RoomID , int CustomerID , DateTime DateTime,DateTime LastDateTime,
        DateTime CheckInDate ,DateTime CheckOutDate ,
        enReservationStatus Status , float PaidFees , string Notes , int CreatedByUserID )
        {
            this.ReservationID = ReservationID;
            this.RoomID = RoomID;
            this.RoomInfo = clsRooms.FindRoomByID(RoomID);
            this.CustomerID = CustomerID;
            this.CustomerInfo=clsCustomers.FindCustomer(CustomerID);
            this.DateTime = DateTime;
            this.LastDateTime = LastDateTime;
            this.CheckInDate = CheckInDate;
            this.CheckOutDate = CheckOutDate;
            this.Status=Status;
            this.PaidFees = PaidFees;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
            this.UserInfo=clsUser.FindByUserID(CreatedByUserID);
            this._Mode =enMode.enUpdate;
        }

        public clsReservations()
        {
            this.ReservationID = -1;
            this.RoomID = -1;
            this.CustomerID = -1;
            this.DateTime = DateTime.Now;
            this.LastDateTime= DateTime.Now;
            this.CheckInDate = DateTime.Now;
            this.CheckOutDate = DateTime.Now;
            this.Status=enReservationStatus.enEmpty;
            this.PaidFees = 0;
            this.Notes = "";
            this.CreatedByUserID = -1;
            this._ReservationLibraryInfo=new clsReservationLibrary();
            this._Mode =enMode.enAddNew;
        }
        public clsPayments.clsFeesInfo FeesInfo { set; get; }
        public static clsReservations GetReservationByReservationID(int ReservationID)
        {
            int RoomID = -1; int CustomerID = -1; DateTime DateTime = DateTime.Now;
            DateTime LastDateTime=DateTime.Now;
            DateTime CheckInDate = DateTime.Now; DateTime CheckOutDate=DateTime.Now;
            int Status = 0; float PaidFees = 0; string Notes = ""; int CreatedByUserID = -1;

            if(clsReservationsData.GetReservationByReservationID(ReservationID,ref RoomID,ref CustomerID,ref DateTime,ref LastDateTime, ref CheckInDate,ref CheckOutDate
                ,ref Status,ref PaidFees,ref Notes ,ref CreatedByUserID))
            {
                return new clsReservations(ReservationID, RoomID, CustomerID, DateTime, LastDateTime, CheckInDate, CheckOutDate, (enReservationStatus)Status, PaidFees, Notes, CreatedByUserID);

            }
            return null;

        }
        private clsPayments.clsFeesInfo _GetFeesInfo()
        {
            clsPayments.clsFeesInfo feesInfo = new clsPayments.clsFeesInfo();

            feesInfo.DiscountRate=this.FeesInfo.DiscountRate;
            feesInfo.AmountDiscount=this.FeesInfo.AmountDiscount;
            feesInfo.VAT_Rate=this.FeesInfo.VAT_Rate;
            feesInfo.AmountVAT =this.FeesInfo.AmountVAT;
            feesInfo.TotalAfterDiscount=this.FeesInfo.TotalAfterDiscount;
            feesInfo.TotalPaid=this.FeesInfo.TotalPaid;
            feesInfo.TypePayment=this.FeesInfo.TypePayment;

         

            return feesInfo;
        }
        //private bool _AddNewPayment()
        //{
        //    clsPayments payment = new clsPayments();
        //    payment.ReservationID=this.ReservationID;
        //    payment.CustomerID=this.CustomerID;
        //    payment.PaymentDate=DateTime.Now;
        //    payment.feesInfo=this.FeesInfo;
        //    payment.Notes=this.Notes;
        //    payment.CreatedByUserID=this.CreatedByUserID;
            
        //    return payment.Save();
        //}

        private  void ProssesInfoToReservationLibraryInfo()
        {
            this._ReservationLibraryInfo.RoomID=this.RoomID;
            this._ReservationLibraryInfo.CustomerID=this.CustomerID;
            this._ReservationLibraryInfo.DateTime=this.DateTime;
            this._ReservationLibraryInfo.LastDateTime=this.LastDateTime;
            this._ReservationLibraryInfo.CheckInDate=this.CheckInDate;
            this._ReservationLibraryInfo.CheckOutDate=this.CheckOutDate;
            this._ReservationLibraryInfo.Status=(clsReservationLibrary.enReservationStatus)this.Status;
            this._ReservationLibraryInfo.PaidFees=this.PaidFees;
            this._ReservationLibraryInfo.Notes=this.Notes;
            this._ReservationLibraryInfo.CreatedByUserID=this.CreatedByUserID;

            this._ReservationLibraryInfo.DiscountRate=this.FeesInfo.DiscountRate;
            this._ReservationLibraryInfo.AmountDiscount=this.FeesInfo.AmountDiscount;
            this._ReservationLibraryInfo.VAT_Rate=this.FeesInfo.VAT_Rate;
            this._ReservationLibraryInfo.AmountVAT=this.FeesInfo.AmountVAT;
            this._ReservationLibraryInfo.TotalAfterDiscount=this.FeesInfo.TotalAfterDiscount;
            this._ReservationLibraryInfo.TotalPaid=this.FeesInfo.TotalPaid;
            this._ReservationLibraryInfo.TypePayment =(clsReservationLibrary.enTypePayment)this.FeesInfo.TypePayment;


        }
        private bool _AddNewReservation()
        {

            this.ProssesInfoToReservationLibraryInfo();
            this.ReservationID= clsReservationsData.AddNewReservation(_ReservationLibraryInfo);


            if (this.ReservationID >= 1)
            {
               if (OnReservationsAdd!=null)
                {
                    OnReservationsAdd(this, new ReservationEventArgs(this));
                }
                return true;
            }


            //if(this.ReservationID >= 1 )
            //{
            //    if(IsReservationExistByCustomerIDAndCompleted(this.CustomerID))
            //    clsCustomers.Update_NumberVisitCustomer(this.CustomerID, this.CustomerInfo.NumberVisit+1);
            //    bool result = (_AddNewPayment()&& clsRooms.UpdateStatusRoom(this.RoomID, (byte)clsRooms.enStatusRooms.enReserved, CreatedByUserID));
            //    if (OnReservationsAdd!=null)
            //    {
            //        OnReservationsAdd(this, new ReservationEventArgs(this));
            //    }
            //   return result ;
            //}

            return false;
        }

        private bool _UpdateReservation()
        {
           bool IsUpdated = clsReservationsData.UpdateReservation(this.ReservationID,this.RoomID,
                this.CustomerID, this.DateTime,this.LastDateTime, this.CheckInDate, this.CheckOutDate, 
                (byte)this.Status, this.PaidFees, this.Notes, this.CreatedByUserID);

            if (IsUpdated)
            {
                return true;
            }

            return false;
        }
        
        private bool UpdateReservationDateIn_And_Out()
        {
            bool IsUpdated = clsReservationsData.UpdateReservationDateIn_And_Out(this.ReservationID,
                this.LastDateTime, this.CheckInDate, this.CheckOutDate,
                this.CreatedByUserID);

            if (IsUpdated)
            {
                return true;
            }

            return false;
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.enAddNew:
                    if (_AddNewReservation())
                    {
                        _Mode=enMode.enUpdate;
                        return true;
                    }

                    break;

                case enMode.enUpdate:
                    if (UpdateReservationDateIn_And_Out())
                    {
                        return true;
                    }

                    break;
            }
            return false;
        }

        public static DataTable GetAllReservations()
        {
            return clsReservationsData.GetAllReservations( );
        }
        public static DataTable GetExpireReservationsForTomorrow()
        {
            return clsReservationsData.GetExpireReservationsForTomorrow();
        }
        public static DataTable GetExpiredReservations()
        {
            return clsReservationsData.GetExpiredReservations();
        }
        public static bool DeleteReservation(int ReservationID)
        {
            return clsReservationsData.DeleteReservation(ReservationID);
        }

        public static bool IsReservationExistByReservationID(int ReservationID)
        {
            return clsReservationsData.IsReservationExistByReservationID(ReservationID);
        }

        public static bool IsReservationExistByCustomerID(int CustomerID)
        {
            return clsReservationsData.IsReservationExistByCustomerID(CustomerID);
        }
        public static bool IsReservationExistByCustomerIDAndCompleted(int CustomerID)
        {
            return clsReservationsData.IsReservationExistByCustomerIDAndCompleted (CustomerID);
        }
        public static bool IsReservationExistByRoomID(int RoomID)
        {
            return clsReservationsData.IsReservationExistByRoomID(RoomID);
        }
        public static bool UpdateStatusReservation(int ReservationID, byte Status, int LastUpdatedByUserID)
        {
            return clsReservationsData.UpdateStatusReservation(ReservationID, Status, LastUpdatedByUserID);
        }


        //private bool _AddNewPayment()
        //{
        //    clsPayments Pym = new clsPayments();

        //    Pym.CustomerID=this.CustomerID;
        //    Pym.ReservationID=this.ReservationID;
        //    Pym.PaymentDate=DateTime.Now;
        //   // Pym.Notes =this.Notes;
        //   Pym.CreatedByUserID=this.CreatedByUserID;
        //  //  Pym.TotalPaid=this.PaidFees;

        //    return Pym.Save();
        //}
    }
}
