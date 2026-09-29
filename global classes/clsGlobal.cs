using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Hotel_Management_System;
using DVLD_Buisness;
using System.Net.Mail;
using System.Net;
using Microsoft.Win32;
using System.Security.Cryptography;


namespace DVLD.Classes
{
    internal static  class clsGlobal
    {
        public static TimeSpan TimeIn = new TimeSpan(14, 0, 0);

        public static TimeSpan TimeOut =new TimeSpan(12,0,0);
        public static clsUser CurrentUser;

        public static string ComputeHashing(string Input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] InputHashing = sha256.ComputeHash(Encoding.UTF8.GetBytes(Input));

                return BitConverter.ToString(InputHashing).Replace("-", "").ToLower();
            }
        }
        public static bool RememberUsernameAndPassword(string Username, string Password)
        {

            try
            {
                //this will get the current project directory folder.
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();


                // Define the path to the text file where you want to save the data
                string filePath = currentDirectory + "\\data.txt";

                //incase the username is empty, delete the file
                if (Username=="" && File.Exists(filePath)) 
                { 
                     File.Delete(filePath);
                    return true;

                }

                // concatonate username and passwrod withe seperator.
                string dataToSave = Username + "#//#"+Password ;

                // Create a StreamWriter to write to the file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Write the data to the file
                    writer.WriteLine(dataToSave);
                   
                  return true;
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show ($"An error occurred: {ex.Message}");
                return false;
            }

        }
        public static bool GetStoredCredentialInRegistry(ref string Username, ref string Password)
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\HotelManagementSystem";
            string PasswordUserHotelManagementName = "PasswordUserHotelManagementName";
            string UserNameHotelManagementName = "UserNameHotelManagementName";
            bool result = false;
            try
            {

                string  Value= Registry.GetValue(KeyPath,PasswordUserHotelManagementName,null)as string ;
                if(!string.IsNullOrEmpty(Value))
                {
                    Password=Value;
                    result=true;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

            try
            {
                string Value = Registry.GetValue(KeyPath, UserNameHotelManagementName, null)as string;

                if (!string.IsNullOrEmpty(Value))
                {
                    Username=Value;
                    return result;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
            return false;

        }

        public static bool RememberUsernameAndPasswordInRegistry(string Username, string Password)
        {

            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\HotelManagementSystem";
            string PasswordUserHotelManagementName = "PasswordUserHotelManagementName";
            string PasswordUserHotelManagementData = Password;
            string UserNameHotelManagementName = "UserNameHotelManagementName";
            string UserNameHotelManagementData = Username;
            bool result = false;
            try
            {
                Registry.SetValue(KeyPath, PasswordUserHotelManagementName, PasswordUserHotelManagementData, RegistryValueKind.String);
                result=true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }

            try
            {
                Registry.SetValue(KeyPath, UserNameHotelManagementName, UserNameHotelManagementData, RegistryValueKind.String);
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                return false;
            }
            return false;

        }


        public static bool GetStoredCredential(ref string Username, ref string Password)
        {
            //this will get the stored username and password and will return true if found and false if not found.
            try
            {
                //gets the current project's directory
                string currentDirectory = System.IO.Directory.GetCurrentDirectory();

                // Path for the file that contains the credential.
                string filePath  = currentDirectory + "\\data.txt";

                // Check if the file exists before attempting to read it
                if (File.Exists(filePath))
                {
                    // Create a StreamReader to read from the file
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        // Read data line by line until the end of the file
                        string line;
                        while ((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line); // Output each line of data to the console
                            string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

                            Username = result[0];
                            Password = result[1];
                        }
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show ($"An error occurred: {ex.Message}");
                return false;   
            }

        }

        public static bool SendEmail(clsReservations r,string YourMail="freemoh713@outlook.sa",string ClientMail= "mm713574318moh@gmail.com")
        {
            MailMessage message = new MailMessage(YourMail, ClientMail);
            message.Subject = "تم تاكيد حجزك بنجاح!";
            message.Body="رقم الحجز : "+r.ReservationID.ToString()+"\n" +
                "الغرفة : "+r.RoomInfo.TypeRoomInfo.TypeName+"\n" +
                "Check in date : "+r.CheckInDate.ToShortDateString()+" \n" +
                "Check out date : "+r.CheckOutDate.ToShortDateString()+"\n" +
                " نشكر لك ثفتك بنا ونتطلع لاستقبالك.\n" +
                " فريق الفندق..";

            message.IsBodyHtml=false;
            string SmtpServer = "smtp.office365.com";
            int SmtpPart = 587;

            try
            {
                SmtpClient smtpClient = new SmtpClient(SmtpServer, SmtpPart);
                smtpClient.Credentials= new NetworkCredential(YourMail, "713Raw574Moh");
                smtpClient.EnableSsl=true;
                smtpClient.Send(message);
                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Send Email is failed : "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }


            return false;
        }







        public static bool SendEmail2(clsReservations r, string YourMail = "freemoh713@outlook.sa", string ClientMail = "mm713574318moh@gmail.com")
        {
            MailMessage message = new MailMessage(YourMail, ClientMail);
            message.Subject = "تم تأكيد حجزك بنجاح!";
            message.Body =
                "رقم الحجز : " + r.ReservationID.ToString() + "\n" +
                "الغرفة : " + r.RoomInfo.TypeRoomInfo.TypeName + "\n" +
                "Check in date : " + r.CheckInDate.ToShortDateString() + " \n" +
                "Check out date : " + r.CheckOutDate.ToShortDateString() + "\n" +
                "نشكر لك ثقتك بنا ونتطلع لاستقبالك.\n" +
                "فريق الفندق..";

            message.IsBodyHtml = false;

            string SmtpServer = "smtp.office365.com";
            int SmtpPort = 587;
            string password = "713Raw574Moh"; // ← كلمة المرور

            try
            {
                using (SmtpClient smtpClient = new SmtpClient(SmtpServer, SmtpPort))
                {
                    smtpClient.Credentials = new NetworkCredential(YourMail, password);
                    smtpClient.EnableSsl = true;
                    smtpClient.Send(message);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Send Email is failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

 
        }



    }
}
