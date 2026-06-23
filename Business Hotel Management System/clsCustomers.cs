using Data_Access_Hotel_Management_System;
using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Hotel_Management_System
{
    public class clsCustomers
    {
        public enum enMode { enAddNew=-1,enUpdate=2 }
        enMode _Mode = enMode.enAddNew;

        public int CustomerID { get; set; }
        private int _CountryID { get; set; }
        public int CountryID
        {
            get { return _CountryID; }
            set
            {
                _CountryID=value;
                this.CountryInfo=clsCountry.Find(_CountryID);
            }
        }
        public   clsCountry CountryInfo { get; set; }
        int _GroupCustomerID { set; get; }
        public int GroupCustomerID {
            get
            { 
                return _GroupCustomerID; 
            }
            set
            {
                _GroupCustomerID=value;
                GroupCustomerInfo=clsGroupCustomers.GetGroupCustomerByGroupID(_GroupCustomerID);
            }
        }
        public clsGroupCustomers GroupCustomerInfo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return FirstName+ " "+SecondName+ " "+ThirdName+ " "+LastName; }
        }
        public string IDNumber { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string ImagePath { get; set; }
        public DateTime DateOfBirth { get; set; }
        public byte Gendor { get; set; }
   
        public int NumberVisit { get; set; }
        public string SpecialRequests { get; set; }
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

        public string EmployeeFullName { get { return this.FirstName+" "+this.SecondName+" "+this.ThirdName+" "+this.LastName; } }

        public clsCustomers()
        {
            _Mode=enMode.enAddNew;
            this.CustomerID = -1;
            this.SpecialRequests="";
            this.CreatedByUserID = -1;
            this.NumberVisit = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.IDNumber = "";
            this.Email = "";
            this.ContactNumber = "";
            this.DateOfBirth = DateTime.Now;
            this.Gendor = 0;
            this.CountryID = -1;
            this.CountryInfo=null;
        }
        public clsCustomers(int CustomerID, string FirstName, string SecondName, string ThirdName, string LastName,
            string IDNumber, string Email, string ContactNumber,string SpecialRequests, DateTime DateOfBirth,int NumberVisit, byte Gendor, int CountryID,int CreatedByUserID)

        {
            _Mode=enMode.enUpdate;
            this.CustomerID = CustomerID;
            this.GroupCustomerInfo=clsGroupCustomers.GetGroupCustomerByCustomerID(CustomerID);
            this.CreatedByUserID=CreatedByUserID;
            this.UserInfo=clsUser.FindByUserID(CreatedByUserID);
            this.SpecialRequests=SpecialRequests;
            this.NumberVisit=NumberVisit;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.IDNumber = IDNumber;
            this.Email = Email;
            this.ContactNumber = ContactNumber;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.CountryID = CountryID;
            this.CountryInfo=clsCountry.Find(this.CountryID);


        }
        public static bool Update_SpecialRequestsCustomer(int CustomerID, string SpecialRequests)
        {
            return clsCustomersData.Update_SpecialRequestsCustomer(CustomerID, SpecialRequests);
        }
        public static bool Update_NumberVisitCustomer(int CustomerID, int NumberVisit)
        {
            return clsCustomersData.Update_NumberVisitCustomer((int)CustomerID, NumberVisit);
        }
        public static clsCustomers FindCustomer(int CustomerID)
        {
            string SpecialRequests = "";int CreatedByUserID = -1;int NumberVisit = -1; string FirstName = ""; string SecondName = ""; string ThirdName = ""; string LastName = ""; string IDNumber = ""; string Email = ""; string ContactNumber = ""; string ImagePath = ""; DateTime DateOfBirth = DateTime.Now; byte Gendor = 0; int CountryID = 0;
            if (clsCustomersData.GetCustomerByCustomerID(CustomerID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref IDNumber,ref ContactNumber,ref Email,ref CountryID ,ref NumberVisit,ref SpecialRequests,ref CreatedByUserID))
            {
                return new clsCustomers(CustomerID, FirstName, SecondName, ThirdName, LastName, IDNumber, Email, ContactNumber,SpecialRequests, DateOfBirth,NumberVisit, Gendor, CountryID,CreatedByUserID);
            }
            else
                return null;

        }
        public static clsCustomers FindCustomer(string IDNumber)
        {
            string SpecialRequests = ""; int CreatedByUserID = -1; int NumberVisit = -1; string FirstName = ""; string SecondName = ""; string ThirdName = ""; string LastName = ""; int CustomerID = -1; string Email = ""; string ContactNumber = ""; string ImagePath = ""; DateTime DateOfBirth = DateTime.Now; byte Gendor = 0; int CountryID = 0;
            if (clsCustomersData.GetCustomerByIDNumber(ref CustomerID, ref FirstName, ref SecondName, ref ThirdName, ref LastName,  IDNumber, ref ContactNumber, ref Email,ref CountryID , ref NumberVisit, ref SpecialRequests, ref CreatedByUserID))
            {
                return new clsCustomers(CustomerID, FirstName, SecondName, ThirdName, LastName, IDNumber, Email, ContactNumber, SpecialRequests, DateOfBirth, NumberVisit, Gendor, CountryID, CreatedByUserID);
            }
            else
                return null;

        }

        private bool _AddNewCustomer()
        {
            this.CustomerID=clsCustomersData.AddNewCustomer(this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.IDNumber, this.ContactNumber, this.Email, this.CountryID, this.NumberVisit, this.SpecialRequests, this.CreatedByUserID);

            if(this.CustomerID >= 1)
            {
                return true;
            }

            return false;
        }


        private bool _UpdateCustomer()
        {
           bool IsUpdated=clsCustomersData.UpdateCustomer(this.CustomerID,this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.IDNumber, this.ContactNumber, this.Email, this.CountryID, this.NumberVisit, this.SpecialRequests, this.CreatedByUserID);

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
                    if (_AddNewCustomer())
                    {
                        _Mode=enMode.enUpdate;
                        return true;
                    }
                    break;

                case enMode.enUpdate:
                    if (_UpdateCustomer())
                    {
                        return true;
                    }
                    break;

            }

            return false;
        }
        public static DataTable GetAllCustomers()
        {
            return clsCustomersData.GetAllCustomers();
        }

        public static bool DeleteCustomer(int CustomerID)
        {
            return clsCustomersData.DeleteCustomer(CustomerID);
        }

        public static bool IsCustomerExist(int CustomerID)
        {
            return clsCustomersData.IsCustomerExist(CustomerID);
        }

        public static bool IsCustomerExist(string IDNumber)
        {
            return clsCustomersData.IsCustomerExist(IDNumber);
        }

    }
}
