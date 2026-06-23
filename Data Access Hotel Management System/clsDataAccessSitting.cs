using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace Data_Access_Hotel_Management_System
{
    public class clsDataAccessSitting
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionDB"].ConnectionString;

        //public static string ConnectionString = "Server =.; Database = HotelManagementSystem;User Id = sa; Password=sa123456;";
    }
}
