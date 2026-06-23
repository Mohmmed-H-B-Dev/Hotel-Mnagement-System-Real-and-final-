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
    public class clsEmployees
    {
       public enum enMode { enAddNew = 1, enUpdate = 2 }
        enMode _Mode= enMode.enAddNew;
        public clsEmployees()
        {
            _Mode=enMode.enAddNew;
            this.EmployeeID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.IDNumber = "";
            this.Email = "";
            this.ContactNumber = "";
            this.ImagePath = "";
            this.DateOfBirth = DateTime.Now;
            this.Gendor = 0 ;
            this.CountryID = -1;
            this.CountryInfo=null;
        }
        public clsEmployees(int EmployeeID,string FirstName,string SecondName,string ThirdName,string LastName,
            string IDNumber,string Email,string ContactNumber,string ImagePath,DateTime DateOfBirth,short Gendor,int CountryID) 
        
        {
            _Mode=enMode.enUpdate;
            this.EmployeeID = EmployeeID;   
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;  
            this.IDNumber = IDNumber;
            this.Email = Email;
            this.ContactNumber = ContactNumber;
            this.ImagePath = ImagePath;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.CountryID = CountryID;
            this.CountryInfo=clsCountry.Find(this.CountryID);
           
        
        }
        public int EmployeeID {  get; set; }
        private int _CountryID { get; set; }
        public int CountryID { get { return _CountryID; } set { _CountryID=value;
                this.CountryInfo=clsCountry.Find(_CountryID);
            } }

        public clsCountry CountryInfo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string IDNumber { get; set; }
        public string Email { get; set; }
        public string ContactNumber { get; set; }
        public string ImagePath { get; set; }
        public DateTime DateOfBirth { get; set; }
        public short Gendor { get; set; }
        public string EmployeeFullName { get { return this.FirstName+" "+this.SecondName+" "+this.ThirdName+" "+this.LastName; } }

        public static clsEmployees Find(int employeeID)
        {
            string FirstName = "";   string SecondName = ""; string ThirdName = "";     string LastName = ""; string IDNumber = "";  string Email = "";   string ContactNumber = "";   string ImagePath = "";  DateTime DateOfBirth = DateTime.Now;  short Gendor = 0; int CountryID = 0;
            if (clsEmployeeData.GetEmployeeByEmployeeID(employeeID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref IDNumber, ref DateOfBirth, ref Gendor, ref Email, ref ContactNumber, ref CountryID, ref ImagePath))
            {
                return new clsEmployees(employeeID, FirstName, SecondName, ThirdName, LastName, IDNumber, Email, ContactNumber, ImagePath, DateOfBirth, Gendor, CountryID);
              }
            else
                return null;

        }
        public static clsEmployees Find(string IDNumber)
        {
            int EmployeeID = 0; string FirstName = ""; string SecondName = ""; string ThirdName = ""; string LastName = "";  string Email = ""; string ContactNumber = ""; string ImagePath = ""; DateTime DateOfBirth = DateTime.Now; short Gendor = 0; int CountryID = 0;
            if (clsEmployeeData.GetEmployeeByIDNumber(IDNumber, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref EmployeeID, ref DateOfBirth, ref Gendor, ref Email, ref ContactNumber, ref CountryID, ref ImagePath))
            {
                return new clsEmployees(EmployeeID, FirstName, SecondName, ThirdName, LastName, IDNumber, Email, ContactNumber, ImagePath, DateOfBirth, Gendor, CountryID);
            }
            else
                return null;

        }
        private bool _AddNewEmployee()
        {
            this.EmployeeID=clsEmployeeData.AddNewEmployee(this.IDNumber, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gendor, this.Email, this.ContactNumber, this.CountryID, this.ImagePath);
            if(this.EmployeeID >= 1) 
                return true;

            return false;

        }

        private bool _UpdateEmployee()
        {
           bool IsUpdated=clsEmployeeData.UpdateEmployee(this.EmployeeID,this.IDNumber, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gendor, this.Email, this.ContactNumber, this.CountryID, this.ImagePath);
            if (IsUpdated)
                return true;

            return false;

        }
        public static DataTable GetAllEmployees()
        {
           return clsEmployeeData.GetAllEmployees();
        }


        public bool Save()
        {
            switch (_Mode) 
            {
                case enMode.enAddNew:
                    if (_AddNewEmployee())
                    {
                        _Mode = enMode.enUpdate;
                        return true;
                    }
                    break;
                case enMode.enUpdate:
                    if (_UpdateEmployee())
                    {
                        return true;
                    }
                    break;
            }

            return false;
        }

        public static bool DeleteEmployees(int EmployeeID)
        {
           return clsEmployeeData.DeleteEmployee(EmployeeID);
        }
        public static bool IsEmployeeExist(string IDNumber)
        {
            return clsEmployeeData.IsEmployeeExist(IDNumber);
        }
        public static bool IsEmployeeExist(int EmployeeID)
        {
            return clsEmployeeData.IsEmployeeExist(EmployeeID);
        }
    }
}
