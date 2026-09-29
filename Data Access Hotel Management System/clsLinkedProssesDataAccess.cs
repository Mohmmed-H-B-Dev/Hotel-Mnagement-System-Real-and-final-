using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DVLD_DataAccess;
using System.Data;
using System.Runtime.InteropServices.ComTypes;

namespace Data_Access_Hotel_Management_System
{
    public  class clsLinkedProssesDataAccess
    {


        public static bool HanderRoomsAndExpiredReservation(int LastUpdatedStatusByUserIDRoom,
           int RoomID,  int StatusRoom, 
            int ReservationID,
          int StatusReservations )
        {
            int rows = 0;


            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {

                try
                {
                    using (SqlCommand cmd = new SqlCommand("sp_HanderRoomsAndExpiredReservation", conn))
                    {



                        cmd.CommandType=CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@RoomID", RoomID); 
                        cmd.Parameters.AddWithValue("@LastUpdatedStatusByUserIDRoom", LastUpdatedStatusByUserIDRoom);
                        cmd.Parameters.AddWithValue("@StatusRoom", StatusRoom);
                        cmd.Parameters.AddWithValue("@StatusReservations", StatusReservations);
                        cmd.Parameters.AddWithValue("@ReservationID", ReservationID);


                     

                        conn.Open();
                        rows= cmd.ExecuteNonQuery();


                    }
                }
                catch (Exception ex)
                {
                    clsUntil.HandelEventViewerExceptions("Data Tasks Access ", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                }
                finally
                {
                    conn.Close();
                }
            }


            return (rows>0);

        }


    }
}
