using Data_Access_Hotel_Management_System;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Business_Hotel_Management_System
{
    public  class clsUser
    {
        public int UserID {  get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }
        private bool _IsAdmin { get; set; }
        public bool IsAdmin { get { return _IsAdmin; } set { _IsAdmin=value; } }
        public bool IsActive { get; set; }
        private int _EmployeeID { get; set; }
        public int EmployeeID { get { return _EmployeeID; } set
            {
                _EmployeeID=value;
                clsEmployees.Find(_EmployeeID);
            } }
        public clsEmployees EmployeeInfo { get; set; }

       public enum enMode { enAddNew = 1, enUpdate=2,enChangePassword=3}
        enMode _Mode= enMode.enAddNew;
        public enMode Mode { set { _Mode=value; } get { return _Mode; } }
        public clsUser()
        {
            this.IsActive = false;
            this._IsAdmin = false;
            this.EmployeeID=-1;
            this.EmployeeInfo =null;
            this.UserID=-1;
            this.UserName ="";
            this.Password ="";
            this.Permissions=0;
            this._Mode=enMode.enAddNew;
        }

        public clsUser(int UserID,string UserName,string Password,bool IsActive, bool IsAdmin, int EmployeeID,int  Permissions)
        {
            this.IsActive = IsActive;
            this._IsAdmin = IsAdmin;
            this.EmployeeID=EmployeeID;
            this.EmployeeInfo=clsEmployees.Find(EmployeeID);
            this.UserID=UserID;
            this.UserName =UserName;
            this.Password =Password;
            this.Permissions=Permissions;
            this._Mode=enMode.enUpdate;
        }

        public static clsUser FindByUserID(int UserID)
        {
            string UserName = ""; string Password = ""; bool IsActive = false; bool IsAdmin = false; int EmployeeID = -1;
            int Permissions = 0;
            if (clsUserData.FindUserByUserID(UserID, ref UserName, ref Password, ref IsActive, ref IsAdmin, ref EmployeeID,ref Permissions))
            {
                return new clsUser(UserID, UserName, Password, IsActive, IsAdmin, EmployeeID, Permissions);
            }

            else
                return null;

        }
        public static clsUser FindByUserName(string UserName)
        {
            int UserID = -1; string Password = ""; bool IsActive = false; bool IsAdmin = false; int EmployeeID = -1;
            int Permissions = 0;
            if (clsUserData.FindUserByUserName(UserName, ref UserID, ref Password, ref IsActive, ref IsAdmin, ref EmployeeID,ref Permissions))
            {
                return new clsUser(UserID, UserName, Password, IsActive, IsAdmin, EmployeeID, Permissions);
            }

            else
                return null;

        }
        public static clsUser FindByEmployeeID(int EmployeeID)
        {
            int Permissions = 0; int UserID = -1; string Password = ""; string UserName = ""; bool IsActive = false; bool IsAdmin = false;
            if (clsUserData.FindUserByEmployeeID(ref UserName, ref UserID, ref Password, ref IsActive, ref IsAdmin, EmployeeID,ref Permissions))
            {
                return new clsUser(UserID, UserName, Password, IsActive, IsAdmin, EmployeeID, Permissions);
            }

            else
                return null;

        }
        public static clsUser FindByUserNameAndPassword(string UserName,string Password)
        {
            int UserID = -1; int EmployeeID = -1; bool IsActive = false; bool IsAdmin = false;int Permissions = 0;
            if (clsUserData.GetUserByUserNameAndPassword( UserName,  Password, ref UserID, ref IsActive, ref IsAdmin,ref EmployeeID,ref Permissions))
            {
                return new clsUser(UserID, UserName, Password, IsActive, IsAdmin, EmployeeID, Permissions);
            }

            else
                return null;

        }


        private bool _AddNewUser()
        {
            this.UserID =clsUserData.AddNewUser(this.UserName, this.Password, this._IsAdmin, this.IsActive, this.EmployeeID,this.Permissions);
            if (this.UserID>=1)
            {
                return true;
            }

            return false;
        }


        private bool _UpdateUser()
        {

            return clsUserData.UpdateUser(this.UserID, this.IsAdmin,this.IsActive,this.Permissions);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.enAddNew:
                    if (_AddNewUser())
                    {
                        _Mode=enMode.enUpdate;
                        return true;
                    }
                    break;

                case enMode.enUpdate:
                    if (_UpdateUser())
                    {
                        return true;
                    }
                    break;

                case enMode.enChangePassword:
                    if (clsUserData.ChangePassword(this.UserID,this.Password))
                    {
                        this._Mode=enMode.enUpdate;
                        return true;
                    }
                    break;
            }

            return false;   
        }

        public static DataTable GetAllUsers()
        {
            return clsUserData.GetAllUsers();
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUserData.DeleteUser(UserID);
        }

        public static bool IsUserExist(int UserID)
        {
            return (clsUserData.IsUserExist(UserID));
        }
        public static bool IsUserExist(string UserName)
        {
            return (clsUserData.IsUserExist(UserName));
        }

        public static bool IsUserExistForPersonID(int EmployeeID)
        {
            return clsUserData.IsUserExistForPersonID(EmployeeID);
        }

        public static bool ChangePassword(int UserID, string NewPassword)
        {
            return clsUserData.ChangePassword(UserID, NewPassword);
        }
    }
}
