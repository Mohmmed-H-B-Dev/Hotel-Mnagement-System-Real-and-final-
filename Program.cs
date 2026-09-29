using DVLD.Login;
using Hotel_Mnagement_System.global_classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Mnagement_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Application.ApplicationExit +=(sender, e) =>
            {
                cls_HandelRoomsAndExpiredReservation.Stop();
            };
            Application.Run(new frmLogin());
        }
    }
}
