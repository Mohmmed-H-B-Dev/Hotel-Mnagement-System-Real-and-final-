using Business_Hotel_Management_System;
using DVLD.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Hotel_Mnagement_System.global_classes
{
    public class cls_HandelRoomsAndExpiredReservation
    {
        static DataTable _ExpiredReservation;
        private static System.Timers.Timer _timer;



        /// <summary>
        /// تشغيل الخدمة في الخلفية عند بداية فتح النظام
        /// </summary>
        public static void Start()
        
        
        {
            // 1. تشغيل الفحص فوراً في الخلفية عند فتح البرنامج دون تجميد الشاشة
            try
            {



                Task.Run(() =>
                {
                      _HanderRoomsAndExpiredReservation();
                });

            }
            catch (Exception ex)
            {
                HandelEventLogViewer(1, "class _HandelRoomsAndExpiredReservation  - Method Start Timer -  Error in ExpiredReservations: " + ex.Message, EventLogEntryType.Error);
             }

            // 2. إعداد التايمر ليعمل بشكل متكرر كل ساعة
            _timer = new System.Timers.Timer();
            _timer.Interval = TimeSpan.FromHours(1).TotalMilliseconds; // كل 1 ساعة
            _timer.Elapsed += OnTimerElapsed;
            _timer.AutoReset = true; // لضمان التكرار المستمر تلقائياً
            _timer.Start();
        }

        /// <summary>
        /// الحدث الذي يتم استدعاؤه تلقائياً كل ساعة
        /// </summary>
        private static void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            _HanderRoomsAndExpiredReservation();
        }

        /// <summary>
        /// إيقاف الخدمة وتنظيف الذاكرة عند إغلاق النظام
        /// </summary>
        public static void Stop()
        {
            if (_timer != null)
            {
                _timer.Stop();
                _timer.Dispose();
            }
        }
        private static void HandelEventLogViewer(int n1, string Message, EventLogEntryType type)
        {
            string sourceName = "HotelManage";

            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
                Console.WriteLine("Event source Created..");

            }

            EventLog.WriteEntry(sourceName, Message+ "(... "+n1.ToString()+"...)", type);

        }
        public static bool _HanderRoomsAndExpiredReservation()
        {
            //here we will get all expired reservation and update status reservation to completed and update status room to vacant
            // and we need to add payment for each reservation with type payment is (Expired Reservation) and fees is 0

            //Important note
            //and we need to update this way to best way that means we write the cot get Expired reservation and
            //update status reservation and update status room in one store procedure to avoid any problem in case
            //of any error happen in the middle of the process
            _ExpiredReservation=Business_Hotel_Management_System.clsReservations.GetExpiredReservations();
            //    لازم نعملها في كلاس منفصل عشان نقدر نشغلها اول مايفتح النظام ونعملها 
            //      في الخلفية عشان لو فيه اي حد حجز وحصلت مشكلة في النظام نقدر نعرف ونرسل ايميل للعميل
            if (_ExpiredReservation==null)
                return false;
            TimeSpan HoursForClient = new TimeSpan();

            foreach (DataRow row in _ExpiredReservation.Rows)
            {
                HoursForClient= ((DateTime)row["CheckOutDate"])-DateTime.Now;
                //make event and subscribe to send email or sms to
                //client to inform him that his reservation is expired and he need to check out from the room
                //and he has last 10 hours to check out from the room
                if (HoursForClient.Hours<=10)
                {

                    clsMailService.
                          SubscriptionExpiredReservation(Business_Hotel_Management_System.clsReservations.GetReservationByReservationID((int)row["ReservationID"]));

                }
                if (((DateTime)row["CheckOutDate"]) < DateTime.Now)
                {
                    // Prosses to update status room to vacant and update status reservation to completed
                    Business_Hotel_Management_System.clsLinkedProsses.HanderRoomsAndExpiredReservation((int)row["RoomID"],
                        clsGlobal.CurrentUser.UserID, (byte)clsRooms.enStatusRooms.enVacant,
                 (int)row["ReservationID"], (byte)clsReservations.enReservationStatus.enCompleted
                 );

                }



            }

            return true;
        }

        public async Task ExpiredReservations()
        {

            try
            {



                await Task.Run(() =>
                {
                    //       لازم نعملها في كلاس منفصل عشان نقدر نشغلها اول مايفتح النظام ونعملها
                    //    في الخلفية عشان لو فيه اي حد حجز وحصلت مشكلة في النظام نقدر نعرف ونرسل ايميل للعميل
                    _HanderRoomsAndExpiredReservation();
                });

            }
            catch (Exception ex)
            {
                HandelEventLogViewer(1, "Form _Manage List Reservations  - Method _ExpiredReservations -  Error in ExpiredReservations: " + ex.Message, EventLogEntryType.Error);
                //       MessageBox.Show("Error in ExpiredReservations: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            await Task.Delay(TimeSpan.FromHours(1)); // Delay for 1 Hour before checking again
        }


    }











}