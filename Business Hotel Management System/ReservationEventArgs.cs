using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Hotel_Management_System
{
    public class ReservationEventArgs :  EventArgs
    {

        public clsReservations Reservation {  get; set; }

        public ReservationEventArgs (clsReservations Reservation) {  this.Reservation = Reservation; }
    }
}
