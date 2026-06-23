using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Hotel_Management_System
{
    public class clsRoomsData
    {




        public static bool FindRoomByID(int RoomID,
            ref int TypeRoomID,
            ref string Notes,ref int Status, ref int CreatedByUserID)
        {
            bool IsFound = false;

            string query = "select * from [Rooms] where RoomID=@RoomID;";
            SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString);

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@RoomID", RoomID);
            try
            {

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IsFound=true;
                    if (reader["Notes"]!=DBNull.Value)
                        Notes=(string)reader["Notes"];
                    else
                        Notes="";

                        Status=Convert.ToInt32(reader["Status"]);

                    TypeRoomID=(int)reader["TypeRoomID"];
    

                    CreatedByUserID =(int)reader["CreatedByUserID"];





                }
                reader.Close();
            }
            catch (Exception ex) { IsFound=false; }
            finally { conn.Close(); }

            return IsFound;

        }


        public static int AddNewRoom( int TypeRoomID, byte Status ,string Notes,int CreatedByUserID)
        {
            SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString);

            string query = "INSERT INTO[dbo].[Rooms] " +
                "([TypeRoomID] , [Status], [Notes] , [CreatedByUserID]) " +
                " VALUES" +
                "(@TypeRoomID,@Status,@Notes,@CreatedByUserID)" +
                "Select SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TypeRoomID", TypeRoomID);
            cmd.Parameters.AddWithValue("@Status", Status);
            if(!string.IsNullOrEmpty(Notes))
            cmd.Parameters.AddWithValue("@Notes", Notes);
            else
                cmd.Parameters.AddWithValue("@Notes", DBNull.Value);

            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
          
            int RoomIdReturn = -1;

            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result!=null && int.TryParse(Convert.ToString(result), out int RId))
                {
                    RoomIdReturn = RId;
                }
            }
            catch (Exception ex) { return -1; }
            finally { conn.Close(); }

            return RoomIdReturn;

        }


        public static bool UpdateRoom(int RoomID, int TypeRoomID, byte Status, string Notes, int CreatedByUserID)
        {
            SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString);

            string query = "UPDATE [dbo].[Rooms] " +
                "SET [TypeRoomID] = @TypeRoomID,[Status]=@Status,[Notes] =@Notes" +
                ",[CreatedByUserID] =@CreatedByUserID " +
                "WHERE RoomID=@RoomID";

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@RoomID", RoomID);
            cmd.Parameters.AddWithValue("@TypeRoomID", TypeRoomID);
            cmd.Parameters.AddWithValue("@Status", Status);
            if (!string.IsNullOrEmpty(Notes))
                cmd.Parameters.AddWithValue("@Notes", Notes);
            else
                cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            int RoomIdReturn = -1;

            try
            {
                conn.Open();
                RoomIdReturn = cmd.ExecuteNonQuery();

            }
            catch (Exception ex) { return false; }
            finally { conn.Close(); }

            return (RoomIdReturn>0);

        }


        public static bool UpdateStatusRoom(int RoomID, byte Status, int LastUpdatedStatusByUserID)
        {
            if (LastUpdatedStatusByUserID<=0)
            {
                return false;
            }
            string query = "UPDATE [dbo].[Rooms] " +
                "SET [Status]=@Status" +
                ",[LastUpdatedStatusByUserID] =@LastUpdatedStatusByUserID " +
                "WHERE RoomID=@RoomID";
            SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString);

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@RoomID", RoomID);
            cmd.Parameters.AddWithValue("@LastUpdatedStatusByUserID", LastUpdatedStatusByUserID);
            cmd.Parameters.AddWithValue("@Status", Status);


            int RoomIdReturn = -1;

            try
            {
                conn.Open();
                RoomIdReturn = cmd.ExecuteNonQuery();

            }
            catch (Exception ex) { return false; }
            finally { conn.Close(); }

            return (RoomIdReturn>0);

        }


        public static DataTable GetAllRooms()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString);

            string query = " select * from RoomsDataView;";
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

        public static bool DeleteRoom(int RoomID)
        {
            SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString);

            string query = "DELETE FROM [dbo].[Rooms]\r\n    " +
                "  WHERE RoomID=@RoomID";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@RoomID", RoomID);
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

        public static int FindStatusRoom(int RoomID)
        {
            int Status = 0;int TypeRoomID=-1; int CreatedByUserID = -1; string Notes = "";

            if (FindRoomByID(RoomID, ref TypeRoomID, ref Notes, ref Status, ref CreatedByUserID))
            {
                return Status;
            }
            else
                return 0;
        }


        

    }
}
