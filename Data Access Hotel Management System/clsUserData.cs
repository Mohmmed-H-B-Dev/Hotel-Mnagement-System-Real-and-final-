using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace Data_Access_Hotel_Management_System
{
    public class clsUserData
    {
      
        public static bool FindUserByUserID(int UserID, ref string UserName, ref string Password, ref bool IsActive,ref bool IsAdmin, ref int EmployeeID ,ref int Permissions)
        {
            bool IsFound = false;

            string query = "select * from Users where UserID=@UserID;";
            using (SqlConnection connection = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@UserID", UserID);
                try
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader()) { 
                    if (reader.Read())
                    {
                        IsFound = true;
                        UserName = (string)reader["UserName"];
                        Password = (string)reader["Password"];
                        IsActive = (bool)reader["IsActive"];
                        if (reader["IsAdmin"] == DBNull.Value)
                            IsAdmin = false;
                        else
                            IsAdmin = (bool)reader["IsAdmin"];
                        EmployeeID = (int)reader["EmployeeID"];

                        Permissions=(int)reader["Permissions"];

                    }
                }
                }


                catch (Exception ex) { IsFound=false; }
                  
            }
            return IsFound;

        }


        public static bool FindUserByUserName(string UserName, ref int UserID, ref string Password, ref bool IsActive,ref bool IsAdmin,ref int EmployeeID,ref int Permissions)
        {
            bool IsFound = false;

            string query = "select * from Users where UserName=@UserName;";

            SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString);

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            try
            {

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IsFound=true;
                    IsAdmin=(bool)reader["IsAdmin"];

                    UserID=(int)reader["UserID"];
                    Password=(string)reader["Password"];
                    IsActive=(bool)reader["IsActive"];
                    EmployeeID=(int)reader["EmployeeID"];
                    Permissions=(int)reader["Permissions"];

                }
                reader.Close();
            }
            catch (Exception ex) { IsFound=false; }
            finally { conn.Close(); }

            return IsFound;

        }
        public static bool FindUserByEmployeeID(ref string UserName, ref int UserID, ref string Password, ref bool IsActive,ref bool IsAdmin , int EmployeeID ,ref int Permissions)
        {

            bool isFound = false;
            string query = "SELECT * FROM Users WHERE EmployeeID = @EmployeeID;";
            SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString);

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);

            try
            {
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    // The record was found
                    isFound = true;
                    IsAdmin=(bool)rdr["IsAdmin"];

                    UserID= (int)rdr["UserID"];
                    EmployeeID = (int)rdr["EmployeeID"];
                    UserName = (string)rdr["UserName"];
                    Password =(string)rdr["Password"];
                    IsActive = (bool)rdr["IsActive"];
                    Permissions=(int)rdr["Permissions"];
                }
            }
            catch (Exception ex) { }
            finally { conn.Close(); }

            return isFound;
        }
        public static bool GetUserByUserNameAndPassword(string UserName, string Password, ref int UserID,ref bool IsActive,ref bool IsAdmin,ref int EmployeeID,ref int Permissions)
        {
            bool IsFound = false;
            string query = "select * from Users where " +
                "UserName=@UserName and Password= @Password ;";
            SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString);

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);

            try
            {

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IsFound=true;
                    if (reader["IsAdmin"]==DBNull.Value)
                        IsAdmin=false;
                    else
                        IsAdmin =(bool)reader["IsAdmin"];

                    UserID=(int)reader["UserID"];
                    IsActive=(bool)reader["IsActive"];
                    Password=(string)reader["Password"];
                    EmployeeID=(int)reader["EmployeeID"];
                    Permissions=(int)reader["Permissions"];

                }
                reader.Close();
            }
            catch (Exception ex) { IsFound=false; }
            finally { conn.Close(); }

            return IsFound;

        }


        public static int AddNewUser(string UserName, string Password, bool IsAdmin, bool IsActive, int EmployeeID,int Permissions)
        {

            string query = " INSERT INTO[dbo].[Users]" +
                "([UserName] , [Password] ,[IsAdmin] , [IsActive], [EmployeeID],[Permissions])" +
                "VALUES" +
                " (@UserName,@Password,@IsAdmin,@IsActive,@EmployeeID,@Permissions) "+
            " Select SCOPE_IDENTITY();";


            SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString);

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@IsAdmin", IsAdmin);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);
            cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            cmd.Parameters.AddWithValue("@Permissions", Permissions);

            int UserIDReturn = -1;

            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result!=null && int.TryParse(Convert.ToString(result), out int UId))
                {
                    UserIDReturn = UId;
                }
            }
            catch (Exception ex) { return -1; }
            finally { conn.Close(); }

            return UserIDReturn;

        }


        public static bool UpdateUser(int UserID,bool IsAdmin, bool IsActive ,int Permissions)
        {

            //string query = " UPDATE [dbo].[Users] " +
            //    "SET [UserName] =@UserName,[IsActive] =@IsActive" +
            //    "  ,[EmployeeID] =@EmployeeID " +
            //    " WHERE UserID=@UserID";


            SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString);


            SqlCommand cmd = new SqlCommand("sp_UpdateUser", conn);
            cmd.CommandType=CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserID", UserID);

            cmd.Parameters.AddWithValue("@Permissions", Permissions);
            cmd.Parameters.AddWithValue("@IsActive", IsActive);

            int RowsAffected = -1;

            try
            {
                conn.Open();
                 RowsAffected = cmd.ExecuteNonQuery();
                
            }
            catch (Exception ex) { return false; }
            finally { conn.Close(); }

            return (RowsAffected>0);

        }

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            string query = "SELECT        Users.UserID, Users.UserName, Employees.FirstName + ' ' + Employees.SecondName + ' ' + Employees.ThirdName + ' ' + Employees.LastName AS FullName, Employees.IDNumber, Countries.CountryName\r\nFROM            Employees INNER JOIN\r\n                         Countries ON Employees.CountryID = Countries.CountryID INNER JOIN\r\n                         Users ON Employees.EmployeeID = Users.EmployeeID\r\n";
            SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString);


            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    dt.Load(rdr);
                }
                rdr.Close();
            }
            catch (Exception ex) { return null; }
            finally { conn.Close(); }

            return dt;
        }

        public static bool DeleteUser(int UserID)
        {

            string query = "DELETE FROM [dbo].[Users]\r\n    " +
                "  WHERE UserID=@UserID";
            SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString);

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            int rowsAffected = 0;
            try
            {
                conn.Open();
                rowsAffected = cmd.ExecuteNonQuery();


            }
            catch (Exception ex) { return false; }
            finally { conn.Close(); }
            return (rowsAffected>0);
        }


        public static bool IsUserExist(int UserID)
        {
            SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString);

            string query = "Select Found=1 from Users where UserID=@UserID\r\n";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            int rowsAffected = 0;
            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null&&int.TryParse(Convert.ToString(result), out int num))
                {
                    rowsAffected = num;
                }


            }
            catch (Exception ex) { return false; }
            finally { conn.Close(); }
            return (rowsAffected>0);
        }

        public static bool IsUserExist(string UserName)
        {

            string query = "Select Found=1 from Users where UserName=@UserName\r\n";
            SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString);

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            int rowsAffected = 0;
            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null&&int.TryParse(Convert.ToString(result), out int num))
                {
                    rowsAffected = num;
                }


            }
            catch (Exception ex) { return false; }
            finally { conn.Close(); }
            return (rowsAffected>0);
        }



        public static bool IsUserExistForPersonID(int EmployeeID)
        {

            string query = "SELECT Found=1 FROM Users WHERE EmployeeID = @EmployeeID";
            SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString);

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@EmployeeID", EmployeeID);
            int rowsAffected = 0;
            try
            {
                conn.Open();

                object result = cmd.ExecuteScalar();
                if (result != null&&int.TryParse(Convert.ToString(result), out int num))
                {
                    rowsAffected = num;
                }



            }
            catch (Exception ex) { return false; }
            finally { conn.Close(); }
            return (rowsAffected>0);
        }

        public static bool ChangePassword(int UserID, string NewPassword)
        {
            int RowsAffected = 0;
         //   NewPassword=clsUntil.Encoding(NewPassword);
            string query = " Update Users " +
                "set " +
                "Password=@NewPassword " +
                " where UserID= @UserID";
            SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString);

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@UserID", UserID);
            cmd.Parameters.AddWithValue("@NewPassword", NewPassword);





            try
            {
                conn.Open();

                RowsAffected=cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

            }
            finally { conn.Close(); }

            return (RowsAffected>0);
        }
    }
}
