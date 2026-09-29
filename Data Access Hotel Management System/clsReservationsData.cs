using DVLD_DataAccess;
using Hotle_Management_Library;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Hotel_Management_System
{
 
        public class clsReservationsData
        {



            public static bool GetReservationByReservationID(int ReservationID,
                ref int RoomID, ref int CustomerID, ref DateTime DateTime, ref DateTime LastDateTime,
                ref DateTime CheckInDate, ref DateTime CheckOutDate,
                ref int Status, ref float PaidFees, ref string Notes, ref int CreatedByUserID)
            {
                bool IsFound = false;
                string query = "SELECT * FROM Reservations WHERE ReservationID = @ReservationID;";

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
                                    RoomID = (int)reader["RoomID"];
                                    CustomerID = (int)reader["CustomerID"];
                                    DateTime = (DateTime)reader["DateTime"];
                                    LastDateTime = (DateTime)reader["LastDateTime"];
                                    CheckInDate = (DateTime)reader["CheckInDate"];
                                    CheckOutDate = (DateTime)reader["CheckOutDate"];
                                    Status = Convert.ToInt32(reader["Status"]);
                                    PaidFees = Convert.ToSingle(reader["PaidFees"]);
                                    CreatedByUserID = (int)reader["CreatedByUserID"];
                                    Notes = (reader["Notes"] != DBNull.Value) ? (string)reader["Notes"] : "";
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            clsUntil.HandelEventViewerExceptions("clsReservationsData - GetReservationByReservationID [Get By ID]", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                            IsFound = false;
                        }
                    }
                }
                return IsFound;
            }

        public static int AddNewReservation( clsReservationLibrary rInfo)
        {
            int NewReservationID = 0;

            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("[sp_CompleteReservationProcess_Final]", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@RoomID", rInfo.RoomID);
                    cmd.Parameters.AddWithValue("@CustomerID", rInfo.CustomerID);
                    cmd.Parameters.AddWithValue("@DateTime", rInfo.DateTime);
                    cmd.Parameters.AddWithValue("@LastDateTime", rInfo.LastDateTime);
                    cmd.Parameters.AddWithValue("@CheckInDate", rInfo.CheckInDate);
                    cmd.Parameters.AddWithValue("@CheckOutDate", rInfo.CheckOutDate);
                    cmd.Parameters.AddWithValue("@Status", rInfo.Status);
                    cmd.Parameters.AddWithValue("@PaidFees", rInfo.PaidFees);
                    cmd.Parameters.AddWithValue("@Notes", (object)rInfo.Notes ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", rInfo.CreatedByUserID);


                    cmd.Parameters.AddWithValue("@TypePayment", rInfo.TypePayment);
                    cmd.Parameters.AddWithValue("@TotalPaid", rInfo.TotalPaid);
                    cmd.Parameters.AddWithValue("@TotalAfterDiscount", rInfo.TotalAfterDiscount);
                    cmd.Parameters.AddWithValue("@AmountDiscount", rInfo.AmountDiscount);
                    cmd.Parameters.AddWithValue("@DiscountRate", rInfo.DiscountRate);
                    cmd.Parameters.AddWithValue("@AmountVAT", rInfo.AmountVAT);
                    cmd.Parameters.AddWithValue("@VAT_Rate", rInfo.VAT_Rate);


                    SqlParameter outputIdTask = new SqlParameter("@NewReservationID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output,
                    };


                    cmd.Parameters.Add(outputIdTask);

                    SqlParameter outputIdPayment = new SqlParameter("@PaymentID", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output,
                    };


                    cmd.Parameters.Add(outputIdPayment);
                  
                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        if (outputIdTask.Value!=DBNull.Value)
                            rInfo.ReservationID = Convert.ToInt32(outputIdTask.Value);
                        if(outputIdPayment.Value!=DBNull.Value)
                            rInfo.PaymentID = Convert.ToInt32(outputIdPayment.Value);

                        NewReservationID= rInfo.ReservationID;

                    }
                    catch (Exception ex)
                    {
                        clsUntil.HandelEventViewerExceptions("clsReservationsData - Add New Full Reservation With Payment [Add New SP]", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        NewReservationID = -1;
                    }
                }
            }
            return NewReservationID;
        }


        //public static int AddNewReservation(int RoomID, int CustomerID, DateTime DateTime, DateTime LastDateTime,
        //                                        DateTime CheckInDate, DateTime CheckOutDate, int Status,
        //                                        float PaidFees, string Notes, int CreatedByUserID)
        //    {
        //        int NewReservationID = 0;

        //        using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
        //        {
        //            using (SqlCommand cmd = new SqlCommand("[sp_AddNewReservation]", conn))
        //            {
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                cmd.Parameters.AddWithValue("@RoomID", RoomID);
        //                cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
        //                cmd.Parameters.AddWithValue("@DateTime", DateTime);
        //                cmd.Parameters.AddWithValue("@LastDateTime", LastDateTime);
        //                cmd.Parameters.AddWithValue("@CheckInDate", CheckInDate);
        //                cmd.Parameters.AddWithValue("@CheckOutDate", CheckOutDate);
        //                cmd.Parameters.AddWithValue("@Status", Status);
        //                cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
        //            cmd.Parameters.AddWithValue("@Notes", (object)Notes ?? DBNull.Value);
        //            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                   
        //             SqlParameter outputIdTask = new SqlParameter("@NewReservationID", SqlDbType.Int)
        //              {
        //                Direction = ParameterDirection.Output,
        //            };


        //            cmd.Parameters.Add(outputIdTask);

        //            try
        //                {
        //                    conn.Open();
        //                    cmd.ExecuteNonQuery();
        //                if (outputIdTask.Value!=DBNull.Value)
        //                NewReservationID = Convert.ToInt32(outputIdTask.Value);

        //                }
        //                catch (Exception ex)
        //                {
        //                    clsUntil.HandelEventViewerExceptions("clsReservationsData - AddNewReservation [Add New SP]", ex.Message, System.Diagnostics.EventLogEntryType.Error);
        //                    NewReservationID = -1;
        //                }
        //            }
        //        }
        //        return NewReservationID;
        //    }

            public static bool UpdateReservation(int ReservationID, int RoomID, int CustomerID, DateTime DateTime, DateTime LastDateTime,
                                                 DateTime CheckInDate, DateTime CheckOutDate, byte Status, float PaidFees, string Notes, int CreatedByUserID)
            {
                int rowsAffected = 0;
                string query = @"UPDATE [dbo].[Reservations] 
                             SET [RoomID] = @RoomID, [CustomerID] = @CustomerID, [DateTime] = @DateTime, 
                                 [LastDateTime] = @LastDateTime, [CheckInDate] = @CheckInDate, [CheckOutDate] = @CheckOutDate, 
                                 [Status] = @Status, [PaidFees] = @PaidFees, [Notes] = @Notes, [CreatedByUserID] = @CreatedByUserID 
                             WHERE ReservationID = @ReservationID";

                using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReservationID", ReservationID);
                        cmd.Parameters.AddWithValue("@RoomID", RoomID);
                        cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                        cmd.Parameters.AddWithValue("@DateTime", DateTime);
                        cmd.Parameters.AddWithValue("@LastDateTime", LastDateTime);
                        cmd.Parameters.AddWithValue("@CheckInDate", CheckInDate);
                        cmd.Parameters.AddWithValue("@CheckOutDate", CheckOutDate);
                        cmd.Parameters.AddWithValue("@Status", Status);
                        cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
                        cmd.Parameters.AddWithValue("@Notes", (object)Notes ?? DBNull.Value);
                        cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                        try
                        {
                            conn.Open();
                            rowsAffected = cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            clsUntil.HandelEventViewerExceptions("clsReservationsData - UpdateReservation [Update Info]", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                            return false;
                        }
                    }
                }
                return (rowsAffected > 0);
            }

            public static bool UpdateReservationDateIn_And_Out(int ReservationID, DateTime LastDateTime,
                                                               DateTime CheckInDate, DateTime CheckOutDate, int LastUpdatedByUserID)
            {
                int rowsAffected = 0;
                string query = @"UPDATE [dbo].[Reservations] SET [LastDateTime] = @LastDateTime, 
                             [CheckInDate] = @CheckInDate, [CheckOutDate] = @CheckOutDate, 
                             [LastUpdatedByUserID] = @LastUpdatedByUserID WHERE ReservationID = @ReservationID";

                using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReservationID", ReservationID);
                        cmd.Parameters.AddWithValue("@LastDateTime", LastDateTime);
                        cmd.Parameters.AddWithValue("@CheckInDate", CheckInDate);
                        cmd.Parameters.AddWithValue("@CheckOutDate", CheckOutDate);
                        cmd.Parameters.AddWithValue("@LastUpdatedByUserID", LastUpdatedByUserID);

                        try
                        {
                            conn.Open();
                            rowsAffected = cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            clsUntil.HandelEventViewerExceptions("clsReservationsData - UpdateReservationDateIn_And_Out [Update Dates]", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                            return false;
                        }
                    }
                }
                return (rowsAffected > 0);
            }

            public static DataTable GetAllReservations()
            {
                DataTable dt = new DataTable();
                string query = "SELECT * FROM ReservationsInfo;";

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
                            clsUntil.HandelEventViewerExceptions("clsReservationsData - GetAllReservations [Get All]", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                            return null;
                        }
                    }
                }
                return dt;
            }

            public static bool DeleteReservation(int ReservationID)
            {
                int rowsAffected = 0;
                string query = "DELETE FROM [dbo].[Reservations] WHERE ReservationID = @ReservationID";

                using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReservationID", ReservationID);
                        try
                        {
                            conn.Open();
                            rowsAffected = cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            clsUntil.HandelEventViewerExceptions("clsReservationsData - DeleteReservation [Delete]", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                            return false;
                        }
                    }
                }
                return (rowsAffected > 0);
            }

            public static bool IsReservationExistByReservationID(int ReservationID)
            {
                bool isFound = false;
                string query = "SELECT TOP 1 Found=1 FROM Reservations WHERE ReservationID = @ReservationID";

                using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReservationID", ReservationID);
                        try
                        {
                            conn.Open();
                            isFound = (cmd.ExecuteScalar() != null);
                        }
                        catch (Exception ex)
                        {
                            clsUntil.HandelEventViewerExceptions("clsReservationsData - IsReservationExistByReservationID [Exist Check]", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                            isFound = false;
                        }
                    }
                }
                return isFound;
            }
     
        public static bool UpdateStatusReservation(int ReservationID, byte Status, int LastUpdatedByUserID)
            {
                int rowsAffected = 0;
                string query = "UPDATE [dbo].[Reservations] SET [Status] = @Status, [LastUpdatedByUserID] = @LastUpdatedByUserID WHERE ReservationID = @ReservationID";

                using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Status", Status);
                        cmd.Parameters.AddWithValue("@ReservationID", ReservationID);
                        cmd.Parameters.AddWithValue("@LastUpdatedByUserID", LastUpdatedByUserID);

                        try
                        {
                            conn.Open();
                            rowsAffected = cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            clsUntil.HandelEventViewerExceptions("clsReservationsData - UpdateStatusReservation [Update Status]", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                            return false;
                        }
                    }
                }
                return (rowsAffected > 0);
            }

        public static DataTable GetExpireReservationsForTomorrow()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM ExpireReservationsForTomorrow;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.HasRows) dt.Load(rdr);
                        }
                    }
                    catch (Exception ex)
                    {
                        clsUntil.HandelEventViewerExceptions("clsReservationsData - GetExpireReservationsForTomorrow [Get Expire Tomorrow]", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        return null;
                    }
                }
            }
            return dt;
        }

        public static DataTable GetExpiredReservations()
        {
            DataTable dt = new DataTable();
            string query = "SELECT RoomID,ReservationID,CustomerID,CheckInDate,CheckOutDate " +
                "FROM ExpiredReservations  ;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.HasRows) dt.Load(rdr);
                        }
                    }
                    catch (Exception ex)
                    {
                        clsUntil.HandelEventViewerExceptions("clsReservationsData - GetExpiredReservations [Get Expired]", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        return null;
                    }
                }
            }
            return dt;
        }

        public static bool IsReservationExistByCustomerID(int CustomerID)
        {
            bool isFound = false;
            string query = "SELECT TOP 1 Found=1 FROM Reservations WHERE CustomerID = @CustomerID";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                    try
                    {
                        conn.Open();
                        isFound = (cmd.ExecuteScalar() != null);
                    }
                    catch (Exception ex)
                    {
                        clsUntil.HandelEventViewerExceptions("clsReservationsData - IsReservationExistByCustomerID [Exist Check By Customer]", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        isFound = false;
                    }
                }
            }
            return isFound;
        }

        public static bool IsReservationExistByCustomerIDAndCompleted(int CustomerID)
        {
            bool isFound = false;
            // تم الحفاظ على الكويري الخاصة بك مع استخدام TOP 1 للسرعة
            string query = "SELECT TOP 1 Found=1 FROM Reservations WHERE CustomerID = @CustomerID AND Status=3 ORDER BY ReservationID DESC";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
                    try
                    {
                        conn.Open();
                        isFound = (cmd.ExecuteScalar() != null);
                    }
                    catch (Exception ex)
                    {
                        clsUntil.HandelEventViewerExceptions("clsReservationsData - IsReservationExistByCustomerIDAndCompleted [Check Completed]", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        isFound = false;
                    }
                }
            }
            return isFound;
        }

        public static bool IsReservationExistByRoomID(int RoomID)
        {
            bool isFound = false;
            // الحفاظ على الكويري الأصلية التي تحتوي على Join مع جدول Rooms
            string query = @"SELECT TOP 1 Found=1 
                     FROM Rooms INNER JOIN Reservations ON Rooms.RoomID = Reservations.RoomID 
                     WHERE Reservations.RoomID = @RoomID AND Rooms.Status = 2;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoomID", RoomID);
                    try
                    {
                        conn.Open();
                        isFound = (cmd.ExecuteScalar() != null);
                    }
                    catch (Exception ex)
                    {
                        clsUntil.HandelEventViewerExceptions("clsReservationsData - IsReservationExistByRoomID [Check Room Status]", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        isFound = false;
                    }
                }
            }
            return isFound;
        }
    }
    
}
