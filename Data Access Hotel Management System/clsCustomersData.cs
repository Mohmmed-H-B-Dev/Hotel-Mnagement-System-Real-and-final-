using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Hotel_Management_System
{
    public class clsCustomersData
    {

        public static bool GetCustomerByCustomerID(int CustomerID, ref string FirstName, ref string SecondName, ref string ThirdName,ref string LastName
            , ref string IDNumber, ref string ContactNumber,ref string Email, ref int CountryID, ref int NumberVisit
            ,ref string SpecialRequests,ref int CreatedByUserID)
        {
            bool IsFound = false;

            string query = "select * from Customers where CustomerID=@CustomerID;";
           

            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {


                    cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                    try
                    {

                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {


                            if (reader.Read())
                            {
                                IsFound=true;

                                CustomerID=(int)reader["CustomerID"];

                                FirstName=(string)reader["FirstName"];
                                SecondName= (reader["SecondName"] != DBNull.Value ? (string)reader["SecondName"] : "");
                                ThirdName= (reader["ThirdName"] != DBNull.Value ? (string)reader["ThirdName"] : "");

                                Email= (reader["Email"] != DBNull.Value ? (string)reader["Email"] : "");
                                SpecialRequests= (reader["SpecialRequests"] != DBNull.Value ? (string)reader["SpecialRequests"] : "");
                             
                                LastName=(string)reader["LastName"];
                                IDNumber=(string)reader["IDNumber"];

                                NumberVisit=(int)reader["NumberVisit"];
                                ContactNumber=(string)reader["ContactNumber"];
                             

                                CountryID =(int)reader["CountryID"];
                                CreatedByUserID =(int)reader["CreatedByUserID"];
                            }
                        }
                    }
                    catch (Exception ex) {


                        clsUntil.HandelEventViewerExceptions("Data Access Customer _GetByID ", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        IsFound=false; }
                    finally { conn.Close(); }

                    return IsFound;
                }

            }
        }

        public static bool GetCustomerByIDNumber(ref int CustomerID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName
         , string IDNumber, ref string ContactNumber, ref string Email, ref int CountryID, ref int NumberVisit
         , ref string SpecialRequests, ref int CreatedByUserID)
        {
            bool IsFound = false;

            string query = "select * from Customers where IDNumber=@IDNumber;";
            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {

            
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@IDNumber", IDNumber);
            try
            {

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IsFound=true;

                    CustomerID=(int)reader["CustomerID"];

                    FirstName=(string)reader["FirstName"];
                        SecondName= (reader["SecondName"] != DBNull.Value ? (string)reader["SecondName"] : "");
                        ThirdName= (reader["ThirdName"] != DBNull.Value ? (string)reader["ThirdName"] : "");

                        Email= (reader["Email"] != DBNull.Value ? (string)reader["Email"] : "");
                        SpecialRequests= (reader["SpecialRequests"] != DBNull.Value ? (string)reader["SpecialRequests"] : "");


                        LastName=(string)reader["LastName"];
                    IDNumber=(string)reader["IDNumber"];

                    NumberVisit=(int)reader["NumberVisit"];
                    ContactNumber=(string)reader["ContactNumber"];
                  
                    
                        CountryID =(int)reader["CountryID"];
                    CreatedByUserID =(int)reader["CreatedByUserID"];
                }
                reader.Close();
            }
            catch (Exception ex) {

                    clsUntil.HandelEventViewerExceptions("Data Access Customer _GetByNumberId ", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                    IsFound=false; }
            }
            return IsFound;

        }


        public static int AddNewCustomer(string FirstName,  string SecondName,   string ThirdName,   string LastName
         , string IDNumber,      string ContactNumber,  string Email,  int CountryID,   int NumberVisit
         , string SpecialRequests,   int CreatedByUserID)
        {
            int CustomerIdReturn = -1;

            string query = " INSERT INTO[dbo].[Customers] " +
                " ([FirstName]    , [SecondName] , [ThirdName]      " +
                ", [LastName], [IDNumber], [Email]" +
                " , [ContactNumber] , [CountryID] , [NumberVisit] " +
                " , [SpecialRequests] ,[CreatedDate], [CreatedByUserID]) "+
                " VALUES " +
                " (@FirstName,@SecondName,@ThirdName,@LastName," +
                "@IDNumber,@Email" +
                ",@ContactNumber,@CountryID,@NumberVisit," +
                "@SpecialRequests,@CreatedDate,@CreatedByUserID)" +
                " Select SCOPE_IDENTITY();";
            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    cmd.Parameters.AddWithValue("@IDNumber", IDNumber);
                    cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);


                        cmd.Parameters.AddWithValue("@SecondName",(object)SecondName?? DBNull.Value);
                      cmd.Parameters.AddWithValue("@ThirdName", (object)ThirdName?? DBNull.Value);
                
                    cmd.Parameters.AddWithValue("@LastName", LastName);

                    cmd.Parameters.AddWithValue("@NumberVisit", 1);

                        cmd.Parameters.AddWithValue("@SpecialRequests", (object)SpecialRequests??  DBNull.Value);
                  
                    cmd.Parameters.AddWithValue("@CountryID", CountryID);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    cmd.Parameters.AddWithValue("@ContactNumber", ContactNumber);
                        cmd.Parameters.AddWithValue("@Email", (object)Email?? DBNull.Value);
                 





                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result!=null && int.TryParse(Convert.ToString(result), out int CId))
                        {
                            CustomerIdReturn = CId;
                        }
                    }
                    catch (Exception ex) {
                        clsUntil.HandelEventViewerExceptions("Data Access Customer _AddNew ", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        return -1; }
                }
            }
            return CustomerIdReturn;

        }


        public static bool UpdateCustomer(int CustomerID, string FirstName, string SecondName, string ThirdName, string LastName
        , string IDNumber, string ContactNumber, string Email, int CountryID, int NumberVisit
        , string SpecialRequests, int CreatedByUserID)
        {

            string query = "UPDATE [dbo].[Customers]" +
                "   SET [FirstName] =@FirstName,[SecondName] =@SecondName," +
                "[ThirdName] =@ThirdName,[LastName] =@LastName,[IDNumber] =@IDNumber" +
                ",[Email] =@Email ,[ContactNumber] =@ContactNumber,[CountryID]=@CountryID" +
                " ,[NumberVisit] =@NumberVisit,[SpecialRequests] =@SpecialRequests" +
                ",[CreatedByUserID] =@CreatedByUserID " +
                "WHERE CustomerID=@CustomerID " +
                "";
            int CustomerIdReturn = -1;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {


                    cmd.Parameters.AddWithValue("@CustomerID", CustomerID);

                    cmd.Parameters.AddWithValue("@IDNumber", IDNumber);
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    if (string.IsNullOrEmpty(SecondName))
                        cmd.Parameters.AddWithValue("@SecondName", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@SecondName", SecondName);
                    if (string.IsNullOrEmpty(ThirdName))
                        cmd.Parameters.AddWithValue("@ThirdName", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@ThirdName", ThirdName);

                    cmd.Parameters.AddWithValue("@LastName", LastName);

                    cmd.Parameters.AddWithValue("@NumberVisit", NumberVisit);

                    if (string.IsNullOrEmpty(SpecialRequests))
                        cmd.Parameters.AddWithValue("@SpecialRequests", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@SpecialRequests", SpecialRequests);


                    cmd.Parameters.AddWithValue("@CountryID", CountryID);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                  
                    cmd.Parameters.AddWithValue("@ContactNumber", ContactNumber);
                  
                        cmd.Parameters.AddWithValue("@Email",(object)Email ?? DBNull.Value);
                  





                    try
                    {
                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        CustomerIdReturn = result;

                    }
                    catch (Exception ex) {

                        clsUntil.HandelEventViewerExceptions("Data Access Customer _Update ", ex.Message, System.Diagnostics.EventLogEntryType.Error);

                        return false; }
                }
            }
            return (CustomerIdReturn>0);

        }




        public static bool Update_SpecialRequestsCustomer(int CustomerID,  string SpecialRequests)
        {

            string query = "UPDATE [dbo].[Customers]" +
                "   SET [SpecialRequests] =@SpecialRequests" +
                " " +
                "WHERE CustomerID=@CustomerID " +
                "";
            int CustomerIdReturn = -1;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {



                    cmd.Parameters.AddWithValue("@CustomerID", CustomerID);


                    if (string.IsNullOrEmpty(SpecialRequests))
                        cmd.Parameters.AddWithValue("@SpecialRequests", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@SpecialRequests", SpecialRequests);




                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result!=null && int.TryParse(Convert.ToString(result), out int CId))
                        {
                            CustomerIdReturn = CId;
                        }
                    }
                    catch (Exception ex) {
                        clsUntil.HandelEventViewerExceptions("Data Access Customer _Update_SpecialRequestsCustomer ", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        return false; }
                 }
            }
            return (CustomerIdReturn>0);

        }

        public static bool Update_NumberVisitCustomer(int CustomerID, int NumberVisit)
        {

            string query = "UPDATE [dbo].[Customers]       " +
                "       SET    [NumberVisit] =@NumberVisit       " +
                "                WHERE CustomerID=@CustomerID;   ";

            int CustomerIdReturn = -1;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {




                    cmd.Parameters.AddWithValue("@CustomerID", CustomerID);

                    cmd.Parameters.AddWithValue("@NumberVisit", NumberVisit);





                    try
                    {
                        conn.Open();
                        int result = cmd.ExecuteNonQuery();

                        CustomerIdReturn = result;

                    }
                    catch (Exception ex)
                    {
                        clsUntil.HandelEventViewerExceptions("Data Access Customer _Update_NumberVisitCustomer ", ex.Message, System.Diagnostics.EventLogEntryType.Error);

                        return false;
                    }
                     
                }
            }
            return (CustomerIdReturn>0);

        }


        public static DataTable GetAllCustomers()
        {
            DataTable dt = new DataTable();

            string query = "SELECT       Customers.CustomerID, Customers.FirstName + ' ' + Customers.SecondName + ' ' + Customers.ThirdName + ' ' + Customers.LastName AS FullName, Customers.IDNumber, Customers.Email, Customers.ContactNumber, \r\n                         Countries.CountryName, Customers.NumberVisit, Customers.SpecialRequests, Customers.CreatedByUserID\r\nFROM            Customers INNER JOIN\r\n                         Countries ON Customers.CountryID = Countries.CountryID";
            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {


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
                    catch (Exception ex)
                    {
                        clsUntil.HandelEventViewerExceptions("Data Access Customer _GetAllCustomer ", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        return null;
                    }
                    finally { conn.Close(); }
                }
            }
            return dt;
        }

        public static bool DeleteCustomer(int CustomerID)
        {

            string query = "DELETE FROM [dbo].[Customers]\r\n    " +
                "  WHERE CustomerID=@CustomerID";
            int rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {


                    cmd.Parameters.AddWithValue("@CustomerID", CustomerID);

                    try
                    {
                        conn.Open();
                        rowsAffected = cmd.ExecuteNonQuery();


                    }
                    catch (Exception ex)
                    {

                        clsUntil.HandelEventViewerExceptions("Data Access Customer _Delete Customr ", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        return false;
                    }
                   

                }
            }
            return (rowsAffected>0);
        }

        public static bool IsCustomerExist(int CustomerID)
        {
            int rowsAffected = 0;
            string query = "Select Found=1 from Customers where CustomerID=@CustomerID\r\n";
            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {


                    cmd.Parameters.AddWithValue("@CustomerID", CustomerID);

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
                        clsUntil.HandelEventViewerExceptions("Data Access Customer _IsCustomer Exists by ID ", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        return false;
                    }
                    
                }
            }
            return (rowsAffected>0);
        }

        public static bool IsCustomerExist(string IDNumber)
        {

            string query = "Select Found=1 from Customers where IDNumber=@IDNumber\r\n";
            int rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {


                    cmd.Parameters.AddWithValue("@IDNumber", IDNumber);

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
                        clsUntil.HandelEventViewerExceptions("Data Access Customer _IsCustomer Exists by IdNumber ", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        return false;
                    }
                    
                }
            }
            return (rowsAffected>0);
        }


    }
}
