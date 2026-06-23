using Data_Access_Hotel_Management_System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Hotel_Management_System
{
    public  class clsGroupCustomers
    {
        public enum enMode { enAddNew = 1,enUpdate=2}
        enMode _Mode= enMode.enAddNew;  

        public int GroupID {  get; set; }
        public int CustomerID {  get; set; }
        public int TotalMembers {  get; set; }
        public string SpecialGroupRequests {  get; set; }
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

        public clsGroupCustomers()
        {
            this.GroupID = -1;
            this.CustomerID = -1;
            this.TotalMembers = 0;
            this.SpecialGroupRequests="";
            this.CreatedByUserID = -1;
        }
        public clsGroupCustomers(int GroupID,int CustomerID , int TotalMembers ,string SpecialGroupRequests,int CreatedByUserID)
        {
            this.GroupID = GroupID;
            this.CustomerID = CustomerID;
         //   CustomerInfo=clsCustomers.FindCustomer(CustomerID);
            this.TotalMembers = TotalMembers;
            this.SpecialGroupRequests=SpecialGroupRequests;
            this.CreatedByUserID = CreatedByUserID;
            UserInfo =clsUser.FindByUserID(CreatedByUserID);
        }
        public static clsGroupCustomers GetGroupCustomerByGroupID(int GroupID)
        {
            int CustomerID = -1; int TotalMembers = 0; string SpecialGroupRequests = "";
            int CreatedByUserID = 0;

            if (clsGroupCustomersData.GetGroupCustomerByGroupID(GroupID, ref CustomerID, ref TotalMembers, ref SpecialGroupRequests, ref CreatedByUserID))
            {

                return new clsGroupCustomers(GroupID, CustomerID, TotalMembers, SpecialGroupRequests, CreatedByUserID);
            }
            return null;


        }


        public static clsGroupCustomers GetGroupCustomerByCustomerID(int CustomerID ,int StatusGroup=1)
        {
            int GroupID = -1; int TotalMembers = 0; string SpecialGroupRequests = "";
            int CreatedByUserID = 0;

            if (clsGroupCustomersData.GetGroupCustomerByCustomerID(ref GroupID, StatusGroup, CustomerID, ref TotalMembers, ref SpecialGroupRequests, ref CreatedByUserID))
            {

                return new clsGroupCustomers(GroupID, CustomerID, TotalMembers, SpecialGroupRequests, CreatedByUserID);
            }
            return null;


        }

        private bool _AddNewGroupCustomer()
        {
            this.GroupID = clsGroupCustomersData.AddNewCustomer(this.CustomerID, this.TotalMembers, this.SpecialGroupRequests, this.CreatedByUserID);

            if(this.GroupID >=1)
            {
                return true;
            }
            return false;   
        }

        private bool _UpdateGroupCustomer()
        {

            if (clsGroupCustomersData.UpdateCustomer(this.GroupID,this.CustomerID, this.TotalMembers, this.SpecialGroupRequests, this.CreatedByUserID))
            {
                return true;
            }
            return false;
        }
        public static bool UpdateSpecialRequestsCustomer(int GroupID, string SpecialGroupRequests)
        {
            return clsGroupCustomersData.UpdateSpecialRequestsCustomer(GroupID, SpecialGroupRequests);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.enAddNew:
                    if (_AddNewGroupCustomer())
                    {
                        _Mode=enMode.enUpdate;
                        return true;
                    }
                    break;

                case enMode.enUpdate:
                    if (_UpdateGroupCustomer())
                    {
                        return true;
                    }
                    break;
            }

            return false;
        }


        public static DataTable GetAllGroupCustomer()
        {
            return clsGroupCustomersData.GetAllGroupCustomer(); 
        }

        public static bool DeleteGroupCustomerGroupID(int CustomerID)
        {
            return clsGroupCustomersData.DeleteGroupCustomerGroupID(CustomerID);
        }
        public static bool IsGroupCustomerExistByCustomerID(int GroupID)
        {
            return clsGroupCustomersData.IsGroupCustomerExistByCustomerID(GroupID);
        }
        public static bool IsGroupCustomerExistByGroupID(int GroupID)
        {
            return clsGroupCustomersData.IsGroupCustomerExistByGroupID(GroupID);
        }
    }
}
