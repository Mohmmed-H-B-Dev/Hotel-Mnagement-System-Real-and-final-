using Data_Access_Hotel_Management_System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static Business_Hotel_Management_System.clsPayments;

namespace Business_Hotel_Management_System
{
    public  class clsPayments
    {
        public  enum enTypePayment {Cash=1,Made=2,Vise=3,MisterCard=4,Tamara=5,Tabby=6 }
        public enum enMode { enAddNew=1,enUpdate=2}
       public  class clsFeesInfo
        {
            public clsFeesInfo()
            {
                this.VAT_Rate=0;
                this.DiscountRate=0;
                this.TotalAfterDiscount=0;
                this.AmountDiscount=0;
                this.AmountVAT=0;
                this.TypePayment=enTypePayment.Cash;
            }
            public clsFeesInfo(float TotalPaid ,float TotalAfterDiscount, float AmountDiscount, float DiscountRate
               , float AmountVAT, float VAT_Rate, enTypePayment TypePayment)
            {
                this.TotalPaid=TotalPaid;
                this.TotalAfterDiscount = TotalAfterDiscount;
                this.AmountDiscount = AmountDiscount;
                this.DiscountRate = DiscountRate;
                this.AmountVAT = AmountVAT;
                this.VAT_Rate = VAT_Rate;
                this.TypePayment = TypePayment;
            }

            public   float TotalPaid { get; set; }
            public  float TotalAfterDiscount { get; set; }
            public  float AmountDiscount { get; set; }
            public  float DiscountRate { get; set; }
            public  float AmountVAT { get; set; }
            public  float VAT_Rate { get; set; }
            public  enTypePayment TypePayment { get; set; }
        }
        enMode _Mode = enMode.enAddNew;
        public string TypePaymentText
        {
            get {switch (feesInfo.TypePayment)
                {
                    case enTypePayment.Cash:
                        return "Cash";
                    case enTypePayment.Made:
                        return "Made";
                    case enTypePayment.Vise:
                        return "Vise";
                    case enTypePayment.MisterCard:
                        return "MisterCard";
                    case enTypePayment.Tamara:
                        return "Tamara";
                    case enTypePayment.Tabby:
                        return "Tabby";
                    default:
                        return "Null";
                        
                }
            }
            
        }
        public int PaymentID {  get; set; }
        private int _ReservationID { get; set; }
        public int ReservationID { get { return _ReservationID; } set { _ReservationID=value;
                this.ReservationInfo=clsReservations.GetReservationByReservationID(_ReservationID);

            } }
        public clsReservations ReservationInfo { get; set; }
        private int _CustomerID { get; set; }
        public int CustomerID
        {
            get { return _CustomerID; }
            set
            {
                _CustomerID=value;

                this.CustomerInfo=clsCustomers.FindCustomer(_CustomerID);
            }
        }
        public clsCustomers CustomerInfo { get; set; }
        public DateTime PaymentDate {  get; set; }
     
        public string Notes {  get; set; }
        private int _CreatedByUserID { set; get; }

        public int CreatedByUserID
        {
            get { return _CreatedByUserID; }
            set
            {
                _CreatedByUserID=value;
                this.UserInfo=clsUser.FindByUserID(value);
            }
        }
        public clsUser UserInfo { get; set; }
        public clsFeesInfo feesInfo { get; set; }
        public clsPayments(int PaymentID, int ReservationID, int CustomerID, DateTime PaymentDate
           ,clsFeesInfo feesInfo, string Notes, int CreatedByUserID) 
        {
           
            this.PaymentID = PaymentID;
            this.ReservationID= ReservationID;
            this.feesInfo= feesInfo;
            this.ReservationInfo=clsReservations.GetReservationByReservationID(ReservationID);
            this.ReservationInfo.FeesInfo=this.feesInfo;
            this.CustomerID= CustomerID;    
            this.CustomerInfo=clsCustomers.FindCustomer(CustomerID);
            this.PaymentDate= PaymentDate;

          
            
            this.Notes= Notes;
            this.CreatedByUserID = CreatedByUserID;
            this.UserInfo=clsUser.FindByUserID(CreatedByUserID);
            this._Mode=enMode.enUpdate;

        }

        public clsPayments()
        {
            this.PaymentID = -1;
            this.ReservationID= -1;
            this.CustomerID= -1;
            this.PaymentDate= DateTime.Now;
            this.feesInfo=null;
            this.Notes= "";
            this.CreatedByUserID = -1;
            this._Mode=enMode.enAddNew;

        }

        public static clsPayments FindPayment(int PaymentID)
        {
            int ReservationID = -1;  int CustomerID = -1;  DateTime PaymentDate = DateTime.Now;
            float TotalPaid = 0;
            float TotalAfterDiscount = 0; float AmountDiscount = 0;
             float DiscountRate = 0; float AmountVAT = 0; float VAT_Rate=0;
            int TypePayment = 1;
    string Notes = " ";  int CreatedByUserID = -1;
            clsFeesInfo FeesInfo = null;

            if (clsPaymentsData.GetPaymentByPaymentID(PaymentID,ref ReservationID,ref CustomerID,ref TypePayment,ref PaymentDate,ref TotalPaid, ref TotalAfterDiscount,ref AmountDiscount,ref DiscountRate,ref AmountVAT,ref VAT_Rate,ref Notes,ref CreatedByUserID))
            {
                FeesInfo.DiscountRate =DiscountRate;
                FeesInfo.VAT_Rate =VAT_Rate;
                FeesInfo.AmountDiscount =AmountDiscount;
                FeesInfo.TotalAfterDiscount =TotalAfterDiscount;
                FeesInfo.AmountVAT =AmountVAT;
                return new clsPayments(PaymentID, ReservationID, CustomerID, PaymentDate, FeesInfo, Notes, CreatedByUserID);
            }

            return null;
        }
        public static clsPayments FindPaymentByReservationID(int ReservationID)
        {
            int PaymentID = -1; int CustomerID = -1; DateTime PaymentDate = DateTime.Now;
            float TotalPaid = 0;
            float TotalAfterDiscount = 0; float AmountDiscount = 0;
            float DiscountRate = 0; float AmountVAT = 0; float VAT_Rate = 0;
            int TypePayment = 1;
            string Notes = " "; int CreatedByUserID = -1;
            clsFeesInfo FeesInfo = null;

          if (clsPaymentsData.GetPaymentByReservationID(ref PaymentID,  ReservationID, ref CustomerID, ref TypePayment, ref PaymentDate, ref TotalPaid, ref TotalAfterDiscount, ref AmountDiscount, ref DiscountRate, ref AmountVAT, ref VAT_Rate, ref Notes, ref CreatedByUserID))
            {
                FeesInfo=new clsFeesInfo();
                FeesInfo.DiscountRate =DiscountRate;
                FeesInfo.VAT_Rate =VAT_Rate;

                FeesInfo.TotalPaid=TotalPaid;
                FeesInfo.TypePayment=(enTypePayment)TypePayment;
                FeesInfo.AmountDiscount =AmountDiscount;
                FeesInfo.TotalAfterDiscount =TotalAfterDiscount;
                FeesInfo.AmountVAT =AmountVAT;
                
                return new clsPayments(PaymentID, ReservationID, CustomerID, PaymentDate, FeesInfo, Notes, CreatedByUserID);
            }

            return null;
        }
        private bool _AddNewPayment()
        {
            this.PaymentID=clsPaymentsData.AddNewPayment(this.ReservationID,
                this.CustomerID,(int)this.feesInfo.TypePayment,
                this.PaymentDate, this.feesInfo.TotalPaid,
                this.feesInfo.TotalAfterDiscount,
                this.feesInfo.AmountDiscount, this.feesInfo.DiscountRate, 
                this.feesInfo.AmountVAT, this.feesInfo.VAT_Rate, 
                this.Notes, this.CreatedByUserID);
            if(this.PaymentID>=1)
            {
                return true;
            }
            return false;
        }

        public bool Save()
        {
            switch(_Mode)
            {
                case enMode.enAddNew:
                    if (_AddNewPayment())
                    {
                        _Mode=enMode.enUpdate;
                        return true;
                    }

                    break;
            }

            return false;
        }

        public static DataTable GetAllPayments()
        {
            return clsPaymentsData.GetAllPayments();
        }

    }
}
