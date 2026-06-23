using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Hotel_Management_System
{
    public class clsEmployeeData
    {

        public static bool GetEmployeeByEmployeeID(int EmployeeID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName
            , ref string IDNumber, ref DateTime DateOfBirth, ref short Gendor, ref string Email, ref string ContactNumber, ref int CountryID, ref string ImagePath)
        {
            bool IsFound = false;

            string query = "select * from Employees where EmployeeID=@EmployeeID;";
            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {


                    cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    try
                    {

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound=true;

                                FirstName=(string)reader["FirstName"];

                                SecondName= (reader["SecondName"] != DBNull.Value ? (string)reader["SecondName"] : "");
                                ThirdName= (reader["ThirdName"] != DBNull.Value ? (string)reader["ThirdName"] : "");

                                Email= (reader["Email"] != DBNull.Value ? (string)reader["Email"] : "");

                                LastName=(string)reader["LastName"];
                                IDNumber=(string)reader["IDNumber"];
                                DateOfBirth=(DateTime)reader["DateOfBirth"];
                                Gendor=(short)reader["Gendor"];
                                ContactNumber=(string)reader["ContactNumber"];

                                ImagePath= (reader["ImagePath"] != DBNull.Value ? (string)reader["ImagePath"] : "");

                                CountryID =(int)reader["CountryID"];





                            }
                        }                    }
                    catch (Exception ex)
                    {
                        clsUntil.HandelEventViewerExceptions("Data Access Employees _Get  Employee by ID  ", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        IsFound=false;
                    }

                }
            }
            return IsFound;

        }

        public static bool GetEmployeeByIDNumber(string IDNumber, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName
            , ref int EmployeeID, ref DateTime DateOfBirth, ref short Gendor, ref string Email, ref string ContactNumber, ref int CountryID, ref string ImagePath)
        {
            bool IsFound = false;

            string query = "select * from Employees where IDNumber=@IDNumber;";
            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {


                    cmd.Parameters.AddWithValue("@IDNumber", IDNumber);
                    try
                    {

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound=true;

                                FirstName=(string)reader["FirstName"];

                                SecondName= (reader["SecondName"] != DBNull.Value ? (string)reader["SecondName"] : "");
                                ThirdName= (reader["ThirdName"] != DBNull.Value ? (string)reader["ThirdName"] : "");

                                Email= (reader["Email"] != DBNull.Value ? (string)reader["Email"] : "");

                                LastName=(string)reader["LastName"];
                                EmployeeID=(int)reader["EmployeeID"];
                                DateOfBirth=(DateTime)reader["DateOfBirth"];
                                Gendor=(short)reader["Gendor"];
                                ContactNumber=(string)reader["ContactNumber"];

                                CountryID =(int)reader["CountryID"];
                                ImagePath= (reader["ImagePath"] != DBNull.Value ? (string)reader["ImagePath"] : "");





                            }
                        }
                    }
                    catch (Exception ex) {
                        clsUntil.HandelEventViewerExceptions("Data Access Employees _Get  Employee by IDNumber  ", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        IsFound=false; }
                    finally { conn.Close(); }
                }
            }
            return IsFound;

        }


        public static int AddNewEmployee(string IDNumber, string FirstName, string SecondName, string ThirdName, string LastName
            , DateTime DateOfBirth, short Gendor, string Email, string ContactNumber, int CountryID, string ImagePath)
        {

            string query = "INSERT INTO[dbo].[Employees] ([FirstName]" +
                ", [SecondName]  , [ThirdName]  , [LastName] " +
                "  , [IDNumber] , [DateOfBirth] , [Gendor]   , [Email] ," +
                " [ContactNumber]" +
                "      , [CountryID],[ImagePath] )    VALUES " +
                "   (@FirstName,@SecondName,@ThirdName,@LastName" +
                ",@IDNumber,@DateOfBirth,@Gendor,@Email,@ContactNumber,@CountryID," +
                "@ImagePath)" +
                " Select SCOPE_IDENTITY();";
            int EmployeeIdReturn = -1;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {



                    cmd.Parameters.AddWithValue("@IDNumber", IDNumber);
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@SecondName", (object)SecondName?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@ThirdName", (object)ThirdName?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", (object)Email?? DBNull.Value);

                    cmd.Parameters.AddWithValue("@ImagePath", (object)ImagePath?? DBNull.Value);

                    cmd.Parameters.AddWithValue("@LastName", LastName);

                    cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    cmd.Parameters.AddWithValue("@Gendor", Gendor);
                    cmd.Parameters.AddWithValue("@CountryID", CountryID);
                    cmd.Parameters.AddWithValue("@ContactNumber", ContactNumber);


                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result!=null && int.TryParse(Convert.ToString(result), out int EId))
                        {
                            EmployeeIdReturn = EId;
                        }
                    }
                    catch (Exception ex)
                    {
                        clsUntil.HandelEventViewerExceptions("Data Access Employees _AddNew  ", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        return -1; }
                }
            }
            return EmployeeIdReturn;

        }


        public static bool UpdateEmployee(int EmployeeID, string IDNumber, string FirstName, string SecondName, string ThirdName, string LastName
            , DateTime DateOfBirth, short Gendor, string Email, string ContactNumber, int CountryID, string ImagePath)
        {

            string query = " UPDATE [dbo].[Employees]" +
                " SET [FirstName] = @FirstName" +
                ",[SecondName] =@SecondName ,[ThirdName] = @ThirdName ,[LastName] = @LastName" +
                " ,[IDNumber] =@IDNumber ,[DateOfBirth] =@DateOfBirth,[Gendor] =@Gendor " +
                " ,[Email] =@Email ,[ContactNumber] = @ContactNumber   ,[CountryID] = @CountryID" +
                " ,[ImagePath] =@ImagePath " + "WHERE EmployeeID=@EmployeeID ";

            int EmployeeIDReturn = -1;
            int RowsAffected = -1;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {



                    cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    cmd.Parameters.AddWithValue("@IDNumber", IDNumber);
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@SecondName", (object)SecondName?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@ThirdName", (object)ThirdName?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Email", (object)Email?? DBNull.Value);

                    cmd.Parameters.AddWithValue("@ImagePath", (object)ImagePath?? DBNull.Value);

                    cmd.Parameters.AddWithValue("@LastName", LastName);

                    cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    cmd.Parameters.AddWithValue("@Gendor", Gendor);
                    cmd.Parameters.AddWithValue("@CountryID", CountryID);
                    cmd.Parameters.AddWithValue("@ContactNumber", ContactNumber);





                    try
                    {
                        conn.Open();
                        RowsAffected=cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        clsUntil.HandelEventViewerExceptions("Data Access Employees _Update  ", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        return false;
                    }
                }
            }
            return (RowsAffected>0);

        }

        public static DataTable GetAllEmployees()
        {
            DataTable dt = new DataTable();

            string query = "select * from EmployeesInfoView;";
            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {


                    try
                    {
                        conn.Open();
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {


                            if (rdr.HasRows)
                            {
                                dt.Load(rdr);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsUntil.HandelEventViewerExceptions("Data Access Employees Get All Employees  ", ex.Message, System.Diagnostics.EventLogEntryType.Error);

                        return null;
                    }
                }
            }
            return dt;
        }

        public static bool DeleteEmployee(int EmployeeID)
        {

            string query = "DELETE FROM [dbo].[Employees]\r\n    " +
                "  WHERE EmployeeID=@EmployeeID";
            int rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {
                using (  SqlCommand cmd = new SqlCommand(query, conn))
                {

                
                 cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
     
            try
            {
                conn.Open();
                rowsAffected = cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                clsUntil.HandelEventViewerExceptions("Data Access Employees Delete  ", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                return false; }
        } 
    }            return (rowsAffected>0);
        }

        public static bool IsEmployeeExist(int EmployeeID)
        {

            string query = "Select Found=1 from Employees where EmployeeID=@EmployeeID\r\n";
            int rowsAffected = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {


                    cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    
                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            rowsAffected = 1;
                        }


                    }
                    catch (Exception ex)
                    {
                        clsUntil.HandelEventViewerExceptions("Data Access Employees _IsEmployeeExist  ", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        return false;
                    }

                }
            }
            return (rowsAffected>0);
        }

        public static bool IsEmployeeExist(string IDNumber)
        {
            int rowsAffected = 0;

            string query = "Select Found=1 from Employees where IDNumber=@IDNumber\r\n";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {


                    cmd.Parameters.AddWithValue("@IDNumber", IDNumber);
                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null&&int.TryParse(Convert.ToString(result), out int num))
                        {
                            rowsAffected = num;
                        }


                    }
                    catch (Exception ex)
                    {
                        clsUntil.HandelEventViewerExceptions("Data Access Employees _IsEmployeeExist  ", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        return false; }
                }
            }            return (rowsAffected>0);
        }
    }
}
