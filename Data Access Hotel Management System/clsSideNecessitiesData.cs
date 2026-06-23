using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Hotel_Management_System
{
    public class clsSideNecessitiesData
    {


        public static float GetVATRate()
        {
            SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString);

            string VAT = "VAT";
            string query = "select Type From SideNecessities Where Name= @VAT";
            float ResultVAT = 0;
            SqlCommand cmd=new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@VAT", VAT);
            try
            {
                conn.Open();
                object result= cmd.ExecuteScalar();
                if(result != null&&Single.TryParse(result.ToString(), out float f_result))
                {
                    ResultVAT = f_result;
                }
                
            }
            catch (Exception ex)
            {

            }
            finally { conn.Close(); }

            return ResultVAT;
        }

        public static float GetBasicDiscountForMonthsRate()
        {
            string BasicDiscountForMonths = "Basic Descount For Month";
            string query = "select Type From SideNecessities Where Name= @BasicDiscountForMonths";
            float ResultBasicDiscountForMonths = 0;
            SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString);

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@BasicDiscountForMonths", BasicDiscountForMonths);
            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    if(float.TryParse(result.ToString(), out float f_result))
                    ResultBasicDiscountForMonths = f_result;
                }

            }
            catch (Exception ex)
            {

            }
            finally { conn.Close(); }

            return ResultBasicDiscountForMonths;
        }
        public static float GetCurrentOfferDiscountsRate()
        {
            string CurrentOfferDiscounts = "Current Offer Discounts";
            SqlConnection conn = new SqlConnection(clsDataAccessSitting.ConnectionString);

            string query = "select Type From SideNecessities Where Name= @CurrentOfferDiscounts";
            float ResultCurrentOfferDiscounts = 0;
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@CurrentOfferDiscounts", CurrentOfferDiscounts);
            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();
                if (result != null&&Single.TryParse(result.ToString(), out float f_result))
                {
                    ResultCurrentOfferDiscounts = f_result;
                }

            }
            catch (Exception ex)
            {

            }
            finally { conn.Close(); }

            return ResultCurrentOfferDiscounts;
        }
    }
}
