using Business_Hotel_Management_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Mnagement_System.global_classes
{
    public class clsMailService
    {

        public static void Subscription(clsReservations reservations)
        {
           
            reservations.OnReservationsAdd+=HandelMessageBox;
        }
        public void UnSubscription(clsReservations reservations)
        {
            reservations.OnReservationsAdd-=HandelMessageBox;
        }

        public static void SubscriptionExpiredReservation(clsReservations reservations)
        {

            reservations.OnReservationsExpired+=SendMessageToClient;
        }
        public void UnSubscriptionExpiredReservation(clsReservations reservations)
        {
            reservations.OnReservationsExpired-=SendMessageToClient;
        }
        public static void SendMessageToClient(object sender, ReservationEventArgs e)
        {

            MessageBox.Show("I am Class Mail Service ,\nI  work with events,\nI am now subscribed with event reservation (ReservationEventArgs),\n" +
                "I can handle any job you want... ", "Events Args, With Reservation Details", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
        public static void HandelMessageBox(object sender,ReservationEventArgs e)
        {

            MessageBox.Show("I am Class Mail Service ,\nI  work with events,\nI am now subscribed with event reservation (ReservationEventArgs),\n" +
                "I can handle any job you want... ", "Events Args, With Reservation Details", MessageBoxButtons.OK,MessageBoxIcon.Information);


        }
    }
}
