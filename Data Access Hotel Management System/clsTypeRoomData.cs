using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
namespace Data_Access_Hotel_Management_System
{
    public  class clsTypeRoomData
    {



        public static bool FindTypeRoom(int TypeRoomID,
            ref string TypeName, ref string Descriptions,
            ref float FeesForDay, ref float FeesForMonth, ref int CreatedByUserID)
        {
            bool IsFound = false;

            string query = "select * from [TypeRooms] where TypeRoomID=@TypeRoomID;";
            SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString);

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TypeRoomID", TypeRoomID);
            try
            {

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IsFound=true;

                    TypeName=(string)reader["TypeName"];

                   
                    if (reader["Descriptions"]!=DBNull.Value)
                        Descriptions=(string)reader["Descriptions"];
                    else
                        Descriptions="";

                    FeesForDay=Convert.ToSingle(reader["FeesForDay"]);
                    FeesForMonth=Convert.ToSingle(reader["FeesForMonth"]);
                    CreatedByUserID =(int)reader["CreatedByUserID"];
                    




                }
                reader.Close();
            }
            catch (Exception ex) { IsFound=false; }
            finally { conn.Close(); }

            return IsFound;

        }

        public static bool FindTypeRoom(string TypeName, ref int TypeRoomID, ref string Descriptions,
           ref float FeesForDay,ref float FeesForMonth, ref int CreatedByUserID)
        {
            bool IsFound = false;

            string query = "select * from [TypeRooms] where TypeName=@TypeName;";
            SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString);

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@TypeName", TypeName);
            try
            {

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    IsFound=true;
                  
                    TypeName=(string)reader["TypeName"];
                    TypeRoomID=(int)reader["TypeRoomID"];


                    if (reader["Descriptions"]!=DBNull.Value)
                        Descriptions=(string)reader["Descriptions"];
                    else
                        Descriptions="";
                    FeesForDay=Convert.ToSingle(reader["FeesForDay"]);
                    FeesForMonth=Convert.ToSingle(reader["FeesForMonth"]);
                    CreatedByUserID =(int)reader["CreatedByUserID"];





                }
                reader.Close();
            }
            catch (Exception ex) { IsFound=false; }
            finally { conn.Close(); }

            return IsFound;

        }


        public static DataTable GetAllTypeRooms()
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString);

            string query = "select * from TypeRooms";
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
    }
}
