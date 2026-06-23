using Data_Access_Hotel_Management_System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Hotel_Management_System
{
    public  class clsSideNecessities
    {

        public static float VAT_Rate()
        {
            return clsSideNecessitiesData.GetVATRate();    
        }


        public static float BasicDiscountForMonths_Rate()
        {
            return clsSideNecessitiesData.GetBasicDiscountForMonthsRate();
        }
        public static float CurrentOfferDiscounts_Rate()
        {
            return clsSideNecessitiesData.GetCurrentOfferDiscountsRate();
        }

    }
}
