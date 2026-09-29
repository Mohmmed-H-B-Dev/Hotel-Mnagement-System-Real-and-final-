using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Hotel_Management_System;

namespace Business_Hotel_Management_System
{
    public class clsLinkedProsses
    {

        public static bool HanderRoomsAndExpiredReservation(int RoomID ,
          int LastUpdatedStatusByUserIDRoom, byte StatusRoom, int ReservationID ,
           
         int StatusReservations)
        {
            return clsLinkedProssesDataAccess.HanderRoomsAndExpiredReservation(LastUpdatedStatusByUserIDRoom, RoomID, (int)StatusRoom, ReservationID, StatusReservations);
        }
    }
}
