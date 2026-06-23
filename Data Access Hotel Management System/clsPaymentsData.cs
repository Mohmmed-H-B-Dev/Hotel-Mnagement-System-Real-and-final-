using DVLD_DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Hotel_Management_System
{
    public class clsPaymentsData
    {
        public static bool GetPaymentByPaymentID(int PaymentID, ref int ReservationID, ref int CustomerID, ref int TypePayment,
                                              ref DateTime PaymentDate, ref float TotalPaid, ref float TotalAfterDiscount,
                                              ref float AmountDiscount, ref float DiscountRate, ref float AmountVAT,
                                              ref float VAT_Rate, ref string Notes, ref int CreatedByUserID)
        {
            bool IsFound = false;
            string query = "SELECT * FROM Payments WHERE PaymentID = @PaymentID";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PaymentID", PaymentID);
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                TotalPaid = Convert.ToSingle(reader["TotalPaid"]);
                                TotalAfterDiscount = Convert.ToSingle(reader["TotalAfterDiscount"]);
                                DiscountRate = Convert.ToSingle(reader["DiscountRate"]);
                                AmountDiscount = Convert.ToSingle(reader["AmountDiscount"]);
                                AmountVAT = Convert.ToSingle(reader["AmountVAT"]);
                                VAT_Rate = Convert.ToSingle(reader["VAT_Rate"]);
                                TypePayment = (int)reader["TypePayment"];
                                CustomerID = (int)reader["CustomerID"];
                                ReservationID = (int)reader["ReservationID"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                PaymentDate = (DateTime)reader["PaymentDate"];
                                Notes = (reader["Notes"] != DBNull.Value) ? (string)reader["Notes"] : "";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsUntil.HandelEventViewerExceptions("clsPaymentsData - GetPaymentByPaymentID [Get By ID]", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        IsFound = false;
                    }
                }
            }
            return IsFound;
        }

        public static bool GetPaymentByReservationID(ref int PaymentID, int ReservationID, ref int CustomerID, ref int TypePayment,
                                                     ref DateTime PaymentDate, ref float TotalPaid, ref float TotalAfterDiscount,
                                                     ref float AmountDiscount, ref float DiscountRate, ref float AmountVAT,
                                                     ref float VAT_Rate, ref string Notes, ref int CreatedByUserID)
        {
            bool IsFound = false;
            string query = "SELECT * FROM Payments WHERE ReservationID = @ReservationID";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ReservationID", ReservationID);
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                PaymentID = (int)reader["PaymentID"];
                                TotalPaid = Convert.ToSingle(reader["TotalPaid"]);
                                TotalAfterDiscount = Convert.ToSingle(reader["TotalAfterDiscount"]);
                                DiscountRate = Convert.ToSingle(reader["DiscountRate"]);
                                AmountDiscount = Convert.ToSingle(reader["AmountDiscount"]);
                                AmountVAT = Convert.ToSingle(reader["AmountVAT"]);
                                VAT_Rate = Convert.ToSingle(reader["VAT_Rate"]);
                                TypePayment = (int)reader["TypePayment"];
                                CustomerID = (int)reader["CustomerID"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                PaymentDate = (DateTime)reader["PaymentDate"];
                                Notes = (reader["Notes"] != DBNull.Value) ? (string)reader["Notes"] : "";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsUntil.HandelEventViewerExceptions("clsPaymentsData - GetPaymentByReservationID [Get By ResID]", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        IsFound = false;
                    }
                }
            }
            return IsFound;
        }

        public static int AddNewPayment(int ReservationID, int CustomerID, int TypePayment, DateTime PaymentDate,
                                        float TotalPaid, float TotalAfterDiscount, float AmountDiscount,
                                        float DiscountRate, float AmountVAT, float VAT_Rate, string Notes, int CreatedByUserID)
        {
            int PaymentID = -1;
            string query = @"INSERT INTO [dbo].[Payments] 
                    ([ReservationID], [CustomerID], [TypePayment], [PaymentDate], [TotalPaid], 
                     [TotalAfterDiscount], [AmountDiscount], [DiscountRate], [AmountVAT], [VAT_Rate], [Notes], [CreatedByUserID])
                    VALUES 
                    (@ReservationID, @CustomerID, @TypePayment, @PaymentDate, @TotalPaid, 
                     @TotalAfterDiscount, @AmountDiscount, @DiscountRate, @AmountVAT, @VAT_Rate, @Notes, @CreatedByUserID);
                    SELECT SCOPE_IDENTITY();";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ReservationID", ReservationID);
                    cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                    cmd.Parameters.AddWithValue("@TypePayment", TypePayment);
                    cmd.Parameters.AddWithValue("@PaymentDate", PaymentDate);
                    cmd.Parameters.AddWithValue("@TotalPaid", TotalPaid);
                    cmd.Parameters.AddWithValue("@TotalAfterDiscount", TotalAfterDiscount);
                    cmd.Parameters.AddWithValue("@AmountDiscount", AmountDiscount);
                    cmd.Parameters.AddWithValue("@DiscountRate", DiscountRate);
                    cmd.Parameters.AddWithValue("@AmountVAT", AmountVAT);
                    cmd.Parameters.AddWithValue("@VAT_Rate", VAT_Rate);
                    cmd.Parameters.AddWithValue("@Notes", (object)Notes ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    try
                    {
                        conn.Open();
                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int insertedId))
                        {
                            PaymentID = insertedId;
                        }
                    }
                    catch (Exception ex)
                    {
                        clsUntil.HandelEventViewerExceptions("clsPaymentsData - AddNewPayment [Add New]", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                    }
                }
            }
            return PaymentID;
        }
        //public static DataTable GetAllPayments()
        //{
        //    DataTable dt = new DataTable();

        //    string query = @"SELECT 
        //            Payments.PaymentID, 
        //            Reservations.ReservationID, 
        //            Reservations.Status AS ReservationStatus, 
        //            Customers.IDNumber, 
        //            Customers.ContactNumber, 
        //            Payments.TotalPaid, 
        //            Users.UserName
        //         FROM Payments 
        //         INNER JOIN Reservations 
        //            ON Payments.ReservationID = Reservations.ReservationID 
        //         INNER JOIN Customers 
        //            ON Payments.CustomerID = Customers.CustomerID 
        //            AND Reservations.CustomerID = Customers.CustomerID 
        //         INNER JOIN Users 
        //            ON Payments.CreatedByUserID = Users.UserID 
        //            AND Reservations.CreatedByUserID = Users.UserID 
        //            AND Customers.CreatedByUserID = Users.UserID";
        //    SqlCommand cmd = new SqlCommand(query, conn);
        //    try
        //    {
        //        conn.Open();
        //        SqlDataReader rdr = cmd.ExecuteReader();
        //        if (rdr.HasRows)
        //        {
        //            dt.Load(rdr);
        //        }
        //        rdr.Close();
        //    }
        //    catch (Exception ex) { return null; }
        //    finally { conn.Close(); }

        //    return dt;
        //}
        public static DataTable GetAllPayments()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT Payments.PaymentID, Reservations.ReservationID, 
                     Reservations.Status AS ReservationStatus, Customers.IDNumber, 
                     Customers.ContactNumber, Payments.TotalPaid, Users.UserName
                     FROM Payments 
                     INNER JOIN Reservations ON Payments.ReservationID = Reservations.ReservationID 
                     INNER JOIN Customers ON Payments.CustomerID = Customers.CustomerID 
                     INNER JOIN Users ON Payments.CreatedByUserID = Users.UserID";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows) dt.Load(reader);
                        }
                    }
                    catch (Exception ex)
                    {
                        clsUntil.HandelEventViewerExceptions("clsPaymentsData - GetAllPayments [Get All]", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        return null;
                    }
                }
            }
            return dt;
        }
    }


    
}
