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
    public class clsGroupCustomersData
    {

        public static bool GetGroupCustomerByGroupID(int GroupID, ref int CustomerID, ref int TotalMembers,
                                                     ref string SpecialGroupRequests, ref int CreatedByUserID)
        {
            bool IsFound = false;
            string query = "SELECT * FROM GroupCustomers WHERE GroupID = @GroupID";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@GroupID", GroupID);
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                CustomerID = (int)reader["CustomerID"];
                                TotalMembers = (int)reader["TotalMembers"];
                                SpecialGroupRequests = (reader["SpecialGroupRequests"] != DBNull.Value) ? (string)reader["SpecialGroupRequests"] : "";
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsUntil.HandelEventViewerExceptions("clsGroupCustomersData - GetGroupCustomerByGroupID [Get By ID]", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        IsFound = false;
                    }
                }
            }
            return IsFound;
        }

        public static bool GetGroupCustomerByCustomerID(ref int GroupID, int StatusGroup, int CustomerID, ref int TotalMembers,
                                                        ref string SpecialGroupRequests, ref int CreatedByUserID)
        {
            bool IsFound = false;
            string query = "SELECT * FROM GroupCustomers WHERE CustomerID = @CustomerID AND StatusGroup = @StatusGroup";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                    cmd.Parameters.AddWithValue("@StatusGroup", StatusGroup);
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                GroupID = (int)reader["GroupID"];
                                TotalMembers = (int)reader["TotalMembers"];
                                SpecialGroupRequests = (reader["SpecialGroupRequests"] != DBNull.Value) ? (string)reader["SpecialGroupRequests"] : "";
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsUntil.HandelEventViewerExceptions("clsGroupCustomersData - GetGroupCustomerByCustomerID [Get By CustomerID]", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        IsFound = false;
                    }
                }
            }
            return IsFound;
        }

        public static int AddNewCustomer(int CustomerID, int TotalMembers, string SpecialGroupRequests, int CreatedByUserID)
        {
            int GCustomerIdReturn = -1;
            int StatusGroup = 1;
            string query = @"INSERT INTO [dbo].[GroupCustomers] 
                     ([CustomerID], [TotalMembers], [SpecialGroupRequests], [CreatedDate], [StatusGroup], [CreatedByUserID]) 
                     VALUES 
                     (@CustomerID, @TotalMembers, @SpecialGroupRequests, @CreatedDate, @StatusGroup, @CreatedByUserID);
                     SELECT SCOPE_IDENTITY();";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                    cmd.Parameters.AddWithValue("@TotalMembers", TotalMembers);
                    cmd.Parameters.AddWithValue("@SpecialGroupRequests", (object)SpecialGroupRequests ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@StatusGroup", StatusGroup);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedId))
                        {
                            GCustomerIdReturn = insertedId;
                        }
                    }
                    catch (Exception ex)
                    {
                        clsUntil.HandelEventViewerExceptions("clsGroupCustomersData - AddNewCustomer [Add New]", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        GCustomerIdReturn = -1;
                    }
                }
            }
            return GCustomerIdReturn;
        }

        public static bool UpdateCustomer(int GroupID, int CustomerID, int TotalMembers, string SpecialGroupRequests, int CreatedByUserID)
        {
            int rowsAffected = 0;
            string query = @"UPDATE [dbo].[GroupCustomers] 
                     SET [CustomerID] = @CustomerID, [TotalMembers] = @TotalMembers, 
                         [SpecialGroupRequests] = @SpecialGroupRequests, [CreatedByUserID] = @CreatedByUserID 
                     WHERE GroupID = @GroupID";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@GroupID", GroupID);
                    cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                    cmd.Parameters.AddWithValue("@TotalMembers", TotalMembers);
                    cmd.Parameters.AddWithValue("@SpecialGroupRequests", (object)SpecialGroupRequests ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    try
                    {
                        conn.Open();
                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        clsUntil.HandelEventViewerExceptions("clsGroupCustomersData - UpdateCustomer [Update Info]", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        return false;
                    }
                }
            }
            return (rowsAffected > 0);
        }
        public static bool UpdateSpecialRequestsCustomer(int GroupID,string SpecialGroupRequests)
        {
            int GCustomerIdReturn = -1;

            string query = "UPDATE [dbo].[GroupCustomers] " +
                " SET [SpecialGroupRequests] = @SpecialGroupRequests" +
                " " +
                "WHERE GroupID=@GroupID";
            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {



                    cmd.Parameters.AddWithValue("@GroupID", GroupID);


                    cmd.Parameters.AddWithValue("@SpecialGroupRequests", (object)SpecialGroupRequests?? DBNull.Value);



                    try
                    {
                        conn.Open();
                        GCustomerIdReturn = cmd.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        clsUntil.HandelEventViewerExceptions("Data Access Group Customer _Update All  ", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        return false; }
                }
            }
            return (GCustomerIdReturn>0);

        }


        public static DataTable GetAllGroupCustomer()
        {
            DataTable dt = new DataTable();

            string query = "SELECT        GroupCustomers.GroupID, Customers.FirstName + ' ' + Customers.SecondName + ' ' + Customers.ThirdName + ' ' + Customers.LastName AS ChargeFullName, Customers.IDNumber  AS ChargeIDNumber, GroupCustomers.TotalMembers, \r\n                         GroupCustomers.SpecialGroupRequests, Customers.ContactNumber, Countries.CountryName, GroupCustomers.CreatedByUserID\r\nFROM            GroupCustomers INNER JOIN\r\n                         Customers ON GroupCustomers.CustomerID = Customers.CustomerID INNER JOIN\r\n                         Countries ON Customers.CountryID = Countries.CountryID\r\n";
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
                    catch (Exception ex) {
                        clsUntil.HandelEventViewerExceptions("Data Access Group Customer _Get All  ", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        return null; }

                }
            }

            return dt;
        }

        public static bool DeleteGroupCustomerGroupID(int GroupID)
        {

            string query = "DELETE FROM [dbo].[GroupCustomers]\r\n    " +
                "  WHERE GroupID=@GroupID";
            int rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {


                    cmd.Parameters.AddWithValue("@GroupID", GroupID);

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
                        clsUntil.HandelEventViewerExceptions("Data Access Group Customer Delete ", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        return false;
                    }

                }
            }
            return (rowsAffected>0);
        }


        public static bool IsGroupCustomerExistByGroupID(int GroupID)
        {

            string query = "Select Found=1 from GroupCustomers where GroupID=@GroupID\r\n";
            int rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {


                    cmd.Parameters.AddWithValue("@GroupID", GroupID);

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
                        clsUntil.HandelEventViewerExceptions("Data Access Group Customer IsGroupCustomerExistByGroupID ", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        return false;
                    }

                }
            }
            return (rowsAffected>0);
        }

        public static bool IsGroupCustomerExistByCustomerID(int CustomerID)
        {
            string query = "Select Found=1 from GroupCustomers where CustomerID=@CustomerID\r\n";

            int rowsAffected = 0;
            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {


                using (SqlCommand cmd = new SqlCommand(query, conn))
                {


                    cmd.Parameters.AddWithValue("@CustomerID", CustomerID);

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
                        clsUntil.HandelEventViewerExceptions("Data Access Group Customer IsGroupCustomerExistByCustomerID ", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        return false;
                    }

                }
            }
            return (rowsAffected>0);
        }

    }
}
