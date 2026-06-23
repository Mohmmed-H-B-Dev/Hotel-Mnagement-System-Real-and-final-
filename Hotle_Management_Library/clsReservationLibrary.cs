using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotle_Management_Library
{
    public class clsReservationLibrary
    {


        public enum enMode { enAddNew = 1, enUpdate = 2 }
        public enum enReservationStatus { enEmpty = -1, enNew = 1, enCompleted = 3, enCancelled = 2 }

        enMode _Mode = enMode.enAddNew;
        public int ReservationID { get; set; }
        private int _RoomID { get; set; }

        public int RoomID
        {
            get { return _RoomID; }
            set
            {
                _RoomID=value;
             }
        }
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
        public int CustomerID
        {
            get { return _CustomerID; }
            set
            {
                _CustomerID=value;

            }
        }
        public DateTime DateTime { get; set; }
        public DateTime LastDateTime { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public enReservationStatus Status { get; set; }
        public float PaidFees { get; set; }
        public string Notes { get; set; }
        private int _CreatedByUserID { set; get; }


        public float TotalPaid { get; set; }
        public float TotalAfterDiscount { get; set; }
        public float AmountDiscount { get; set; }
        public float DiscountRate { get; set; }
        public float AmountVAT { get; set; }
        public float VAT_Rate { get; set; }
        public enum enTypePayment { Cash = 1, Made = 2, Vise = 3, MisterCard = 4, Tamara = 5, Tabby = 6 }

        public enTypePayment TypePayment { get; set; }  
        public int CreatedByUserID
        {
            get { return _CreatedByUserID; }
            set
            {
                _CreatedByUserID=value;
            }
        }
        public int PaymentID { get; set; }
    }
}
