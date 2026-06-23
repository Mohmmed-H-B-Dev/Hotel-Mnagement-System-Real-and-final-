using System;
using System.Data;
using System.Data.SqlClient;
using Data_Access_Hotel_Management_System;

namespace DVLD_DataAccess
{
    public class clsCountries
    {
        public static bool GetCountryByCountryID(int CountryID, ref string CountryName)
        {
            bool isFound = false;
            string query = "SELECT * FROM Countries WHERE CountryID = @CountryID";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CountryID", CountryID);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                CountryName = (string)rdr["CountryName"];
                                isFound = true;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        clsUntil.HandelEventViewerExceptions("Data Access Countries _Get Country By ID ", ex.Message, System.Diagnostics.EventLogEntryType.Error);
                        isFound = false;
                    }
                }
            }
            return isFound;
        }

        public static bool GetCountryByCountryName(string CountryName, ref int CountryID)
        {
            bool isFound = false;
            string query = "SELECT * FROM Countries WHERE CountryName = @CountryName";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CountryName", CountryName);

                    try
                    {
                        conn.Open();
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.Read())
                            {
                                CountryID = (int)rdr["CountryID"];
                                isFound = true;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        isFound = false;
                        clsUntil.HandelEventViewerExceptions("Data Access Countries _Get Country By Name ", ex.Message, System.Diagnostics.EventLogEntryType.Error);

                    }
                }
            }
            return isFound;
        }

        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Countries ORDER BY CountryName ASC;";

            using (SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    try
                    {
                        conn.Open();
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            if (rdr.HasRows)
                            {
                                dt.Load(rdr);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handling logic
                        clsUntil.HandelEventViewerExceptions("Data Access Countries _Get All Country  ", ex.Message, System.Diagnostics.EventLogEntryType.Error);

                    }
                }
            }
            return dt;
        }
    }
}