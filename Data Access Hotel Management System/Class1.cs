//using DVLD_DataAccess;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Security.Policy;
//using System.Text;
//using System.Threading.Tasks;

//namespace Data_Access_Hotel_Management_System
//{
//    public class clsReservatio
//    {


//        public static bool GetReservationByReservationID(int ReservationID,
//        ref int RoomID, ref int CustomerID, ref DateTime DateTime, ref DateTime LastDateTime,
//        ref DateTime CheckInDate, ref DateTime CheckOutDate,
//        ref int Status, ref float PaidFees, ref string Notes, ref int CreatedByUserID)
//        {
//            bool IsFound = false;
//            string query = "SELECT * FROM Reservations WHERE ReservationID = @ReservationID;";

//            // استخدام using يضمن إغلاق الاتصال والـ Command والتخلص منهما فور انتهاء العملية
//            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
//            {
//                using (SqlCommand cmd = new SqlCommand(query, conn))
//                {
//                    cmd.Parameters.AddWithValue("@ReservationID", ReservationID);

//                    try
//                    {
//                        conn.Open();
//                        using (SqlDataReader reader = cmd.ExecuteReader())
//                        {
//                            if (reader.Read())
//                            {
//                                IsFound = true;

//                                // تعبئة البيانات مع التحويلات الآمنة
//                                RoomID = (int)reader["RoomID"];
//                                CustomerID = (int)reader["CustomerID"];
//                                DateTime = (DateTime)reader["DateTime"];
//                                LastDateTime = (DateTime)reader["LastDateTime"];
//                                CheckInDate = (DateTime)reader["CheckInDate"];
//                                CheckOutDate = (DateTime)reader["CheckOutDate"];
//                                Status = Convert.ToInt32(reader["Status"]);
//                                PaidFees = Convert.ToSingle(reader["PaidFees"]);
//                                CreatedByUserID = (int)reader["CreatedByUserID"];

//                                // معالجة الملاحظات بشكل مختصر
//                                Notes = (reader["Notes"] != DBNull.Value) ? (string)reader["Notes"] : "";
//                            }
//                        }
//                    }
//                    catch (Exception ex)
//                    {
//                        IsFound = false;
//                        // تسجيل الخطأ (اختياري حسب نظامك)
//                        clsUntil.HandelEventViewerExceptions("Data Access - Get", ex.Message, System.Diagnostics.EventLogEntryType.Error);
//                    }
//                }
//            } // هنا يتم إغلاق الاتصال تلقائياً حتى لو حدث خطأ

//            return IsFound;
//        }


//        public static int AddNewReservation_old(
//             int RoomID, int CustomerID, DateTime DateTime, DateTime LastDateTime,
//            DateTime CheckInDate, DateTime CheckOutDate
//            , byte Status, float PaidFees, string Notes, int CreatedByUserID)
//        {

//            string query = " INSERT INTO[dbo].[Reservations]  " +
//                "      ([RoomID]   , [CustomerID]  " +
//                "      , [DateTime] ,[LastDateTime]    " +
//                "   , [CheckInDate]  " +
//                "   , [CheckOutDate],[Status] , [PaidFees]    " +
//                "       , [Notes] , [CreatedByUserID])" +

//                " VALUES " +
//                "(@RoomID,@CustomerID,@DateTime,@LastDateTime," +
//                "@CheckInDate,@CheckOutDate" +
//                ",@Status,@PaidFees,@Notes,@CreatedByUserID)"+
//                " Select SCOPE_IDENTITY();";


//            SqlCommand cmd = new SqlCommand(query, conn);

//            cmd.Parameters.AddWithValue("@RoomID", RoomID);
//            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
//            cmd.Parameters.AddWithValue("@DateTime", DateTime);
//            cmd.Parameters.AddWithValue("@LastDateTime", LastDateTime);
//            cmd.Parameters.AddWithValue("@CheckInDate", CheckInDate);
//            cmd.Parameters.AddWithValue("@CheckOutDate", CheckOutDate);
//            cmd.Parameters.AddWithValue("@Status", Status);

//            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
//            if (string.IsNullOrEmpty(Notes))
//                cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
//            else
//                cmd.Parameters.AddWithValue("@Notes", Notes);

//            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);




//            int ReservationIdReturn = -1;

//            try
//            {
//                conn.Open();
//                object result = cmd.ExecuteScalar();
//                if (result!=null && int.TryParse(Convert.ToString(result), out int RId))
//                {
//                    ReservationIdReturn = RId;
//                }
//            }
//            catch (Exception ex) { return -1; }
//            finally { conn.Close(); }

//            return ReservationIdReturn;

//        }


//        public static int AddNewReservation(
//    int RoomID, int CustomerID, DateTime DateTime, DateTime LastDateTime,
//    DateTime CheckInDate, DateTime CheckOutDate, byte Status,
//    float PaidFees, string Notes, int CreatedByUserID)
//        {
//            int NewReservationID = -1;

//            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
//            {
//                try
//                {
//                    using (SqlCommand cmd = new SqlCommand("sp_AddNewReservation", conn))
//                    {
//                        cmd.CommandType = CommandType.StoredProcedure;

//                        // إضافة المعاملات المدخلة
//                        cmd.Parameters.AddWithValue("@RoomID", RoomID);
//                        cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
//                        cmd.Parameters.AddWithValue("@DateTime", DateTime);
//                        cmd.Parameters.AddWithValue("@LastDateTime", LastDateTime);
//                        cmd.Parameters.AddWithValue("@CheckInDate", CheckInDate);
//                        cmd.Parameters.AddWithValue("@CheckOutDate", CheckOutDate);
//                        cmd.Parameters.AddWithValue("@Status", Status);
//                        cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
//                        cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

//                        // معالجة الملاحظات (تسمح بـ NULL في قاعدة البيانات)
//                        cmd.Parameters.AddWithValue("@Notes", (object)Notes?? DBNull.Value);


//                        // إعداد المعامل المخرج (Output Parameter)
//                        SqlParameter outputIdParam = new SqlParameter("@NewReservationID", SqlDbType.Int)
//                        {
//                            Direction = ParameterDirection.Output
//                        };
//                        cmd.Parameters.Add(outputIdParam);

//                        conn.Open();

//                        // تنفيذ الإجراء
//                        cmd.ExecuteNonQuery();

//                        // قراءة القيمة العائدة من المعامل المخرج
//                        if (cmd.Parameters["@NewReservationID"].Value != DBNull.Value)
//                        {
//                            NewReservationID = (int)cmd.Parameters["@NewReservationID"].Value;
//                        }
//                    }
//                }
//                catch (Exception ex)
//                {
//                    // استخدام كلاس المعالجة الخاص بك
//                    clsUntil.HandelEventViewerExceptions("Data Access Layer - Reservations", ex.Message, System.Diagnostics.EventLogEntryType.Error);
//                    NewReservationID = -1;
//                }

//            }

//            return NewReservationID;
//        }

//        public static bool UpdateReservation(int ReservationID,
//     int RoomID, int CustomerID, DateTime DateTime, DateTime LastDateTime,
//    DateTime CheckInDate, DateTime CheckOutDate
//    , byte Status, float PaidFees, string Notes, int CreatedByUserID)
//        {

//            string query = "  UPDATE [dbo].[Reservations]" +
//                " SET [RoomID] = @RoomID ,[CustomerID] =@CustomerID" +
//                ",[DateTime] =@DateTime,[LastDateTime]=@LastDateTime ,[CheckInDate] =@CheckInDate" +
//                ",[CheckOutDate] =@CheckOutDate,[Status] =@Status" +
//                ",[PaidFees] =@PaidFees" +
//                ",[Notes] =@Notes,[CreatedByUserID] =@CreatedByUserID " +
//                "WHERE ReservationID=@ReservationID";

//            SqlCommand cmd = new SqlCommand(query, conn);
//            cmd.Parameters.AddWithValue("@Status", Status);
//            cmd.Parameters.AddWithValue("@ReservationID", ReservationID);
//            cmd.Parameters.AddWithValue("@LastDateTime", LastDateTime);
//            cmd.Parameters.AddWithValue("@RoomID", RoomID);
//            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);
//            cmd.Parameters.AddWithValue("@DateTime", DateTime);
//            cmd.Parameters.AddWithValue("@CheckInDate", CheckInDate);
//            cmd.Parameters.AddWithValue("@CheckOutDate", CheckOutDate);
//            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
//            if (string.IsNullOrEmpty(Notes))
//                cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
//            else
//                cmd.Parameters.AddWithValue("@Notes", Notes);

//            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);




//            int ReservationIdReturn = -1;

//            try
//            {
//                conn.Open();
//                ReservationIdReturn = cmd.ExecuteNonQuery();

//            }
//            catch (Exception ex)
//            {
//                clsUntil.HandelEventViewerExceptions("Data Access Layer - Reservations", ex.Message, System.Diagnostics.EventLogEntryType.Error);
//                return false;
//            }
//            finally { conn.Close(); }

//            return (ReservationIdReturn>0);

//        }

//        public static bool UpdateReservationDateIn_And_Out(int ReservationID, DateTime LastDateTime,
//DateTime CheckInDate, DateTime CheckOutDate, int LastUpdatedByUserID)
//        {

//            string query = "  UPDATE [dbo].[Reservations]" +
//                " SET " +
//                "[LastDateTime]=@LastDateTime ,[CheckInDate] =@CheckInDate" +
//                ",[CheckOutDate] =@CheckOutDate" +
//                "" +
//                ",[LastUpdatedByUserID] =@LastUpdatedByUserID " +
//                "WHERE ReservationID=@ReservationID";

//            SqlCommand cmd = new SqlCommand(query, conn);
//            cmd.Parameters.AddWithValue("@ReservationID", ReservationID);
//            cmd.Parameters.AddWithValue("@LastDateTime", LastDateTime);
//            cmd.Parameters.AddWithValue("@CheckInDate", CheckInDate);
//            cmd.Parameters.AddWithValue("@CheckOutDate", CheckOutDate);


//            cmd.Parameters.AddWithValue("@LastUpdatedByUserID", LastUpdatedByUserID);




//            int ReservationIdReturn = -1;

//            try
//            {
//                conn.Open();
//                ReservationIdReturn = cmd.ExecuteNonQuery();

//            }
//            catch (Exception ex) { return false; }
//            finally { conn.Close(); }

//            return (ReservationIdReturn>0);

//        }
//        public static DataTable GetAllReservations()
//        {
//            DataTable dt = new DataTable();

//            string query = " select * from ReservationsInfo;";

//            SqlCommand cmd = new SqlCommand(query, conn);

//            try
//            {
//                conn.Open();
//                SqlDataReader rdr = cmd.ExecuteReader();
//                if (rdr.HasRows)
//                {
//                    dt.Load(rdr);
//                }
//                rdr.Close();
//            }
//            catch (Exception ex) { return null; }
//            finally { conn.Close(); }

//            return dt;
//        }
//        public static DataTable GetExpireReservationsForTomorrow()
//        {
//            DataTable dt = new DataTable();

//            string query = " select * from ExpireReservationsForTomorrow;";

//            SqlCommand cmd = new SqlCommand(query, conn);

//            try
//            {
//                conn.Open();
//                SqlDataReader rdr = cmd.ExecuteReader();
//                if (rdr.HasRows)
//                {
//                    dt.Load(rdr);
//                }
//                rdr.Close();
//            }
//            catch (Exception ex) { return null; }
//            finally { conn.Close(); }

//            return dt;
//        }

//        public static DataTable GetExpiredReservations()
//        {
//            DataTable dt = new DataTable();

//            string query = " select * from ExpiredReservations;";

//            SqlCommand cmd = new SqlCommand(query, conn);

//            try
//            {
//                conn.Open();
//                SqlDataReader rdr = cmd.ExecuteReader();
//                if (rdr.HasRows)
//                {
//                    dt.Load(rdr);
//                }
//                rdr.Close();
//            }
//            catch (Exception ex) { return null; }
//            finally { conn.Close(); }

//            return dt;
//        }

//        public static bool DeleteReservation(int ReservationID)
//        {

//            string query = "DELETE FROM [dbo].[Reservations]\r\n    " +
//                "  WHERE ReservationID=@ReservationID";
//            SqlCommand cmd = new SqlCommand(query, conn);
//            cmd.Parameters.AddWithValue("@ReservationID", ReservationID);
//            int rowsAffected = 0;
//            try
//            {
//                conn.Open();
//                rowsAffected = cmd.ExecuteNonQuery();


//            }
//            catch (Exception ex) { return false; }
//            finally { conn.Close(); }
//            return (rowsAffected>0);
//        }


//        public static bool IsReservationExistByReservationID(int ReservationID)
//        {

//            string query = "Select Found=1 from Reservations where ReservationID=@ReservationID\r\n";
//            SqlCommand cmd = new SqlCommand(query, conn);
//            cmd.Parameters.AddWithValue("@ReservationID", ReservationID);

//            int rowsAffected = 0;
//            try
//            {
//                conn.Open();
//                object result = cmd.ExecuteScalar();
//                if (result != null&&int.TryParse(Convert.ToString(result), out int num))
//                {
//                    rowsAffected = num;
//                }


//            }
//            catch (Exception ex) { return false; }
//            finally { conn.Close(); }
//            return (rowsAffected>0);
//        }

//        public static bool IsReservationExistByCustomerID(int CustomerID)
//        {

//            string query = "Select Found=1 from Reservations where CustomerID=@CustomerID\r\n";
//            SqlCommand cmd = new SqlCommand(query, conn);
//            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);

//            int rowsAffected = 0;
//            try
//            {
//                conn.Open();
//                object result = cmd.ExecuteScalar();
//                if (result != null&&int.TryParse(Convert.ToString(result), out int num))
//                {
//                    rowsAffected = num;
//                }


//            }
//            catch (Exception ex) { return false; }
//            finally { conn.Close(); }
//            return (rowsAffected>0);
//        }

//        public static bool IsReservationExistByCustomerIDAndCompleted(int CustomerID)
//        {

//            string query = "select found=1  from Reservations\r\nwhere CustomerID =@CustomerID and Status=3 order by ReservationID desc ";
//            SqlCommand cmd = new SqlCommand(query, conn);
//            cmd.Parameters.AddWithValue("@CustomerID", CustomerID);

//            int rowsAffected = 0;
//            try
//            {
//                conn.Open();
//                object result = cmd.ExecuteScalar();
//                if (result != null&&int.TryParse(Convert.ToString(result), out int num))
//                {
//                    rowsAffected = num;
//                }


//            }
//            catch (Exception ex) { return false; }
//            finally { conn.Close(); }
//            return (rowsAffected>0);
//        }

//        public static bool IsReservationExistByRoomID(int RoomID)
//        {

//            string query = "SELECT   Found=1     \r\nFROM            Rooms INNER JOIN" +
//                "      Reservations ON Rooms.RoomID = Reservations.RoomID  " +
//                "where Reservations.RoomID=@RoomID and Rooms.Status=2;";
//            SqlCommand cmd = new SqlCommand(query, conn);
//            cmd.Parameters.AddWithValue("@RoomID", RoomID);

//            int rowsAffected = 0;
//            try
//            {
//                conn.Open();
//                object result = cmd.ExecuteScalar();
//                if (result != null&&int.TryParse(Convert.ToString(result), out int num))
//                {
//                    rowsAffected = num;
//                }


//            }
//            catch (Exception ex) { return false; }
//            finally { conn.Close(); }
//            return (rowsAffected>0);
//        }

//        public static bool UpdateStatusReservation(int ReservationID, byte Status, int LastUpdatedByUserID)
//        {

//            string query = "  UPDATE [dbo].[Reservations]" +
//                " SET [Status] =@Status" +
//                ",[LastUpdatedByUserID] =@LastUpdatedByUserID " +
//                "WHERE ReservationID=@ReservationID";

//            SqlCommand cmd = new SqlCommand(query, conn);
//            cmd.Parameters.AddWithValue("@Status", Status);
//            cmd.Parameters.AddWithValue("@ReservationID", ReservationID);


//            cmd.Parameters.AddWithValue("@LastUpdatedByUserID", LastUpdatedByUserID);




//            int ReservationIdReturn = -1;

//            try
//            {
//                conn.Open();
//                ReservationIdReturn = cmd.ExecuteNonQuery();

//            }
//            catch (Exception ex) { return false; }
//            finally { conn.Close(); }

//            return (ReservationIdReturn>0);

//        }

//    }
//}
