using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Mnagement_System.global_classes
{
    public class clsDate
    {
        static int CounterOfDaysOfThisMonth(int days,DateTime dtFromDate)
        {
            int CountDays = 0;
            for (int i = dtFromDate.Day; i<=days; i++)
            {
                CountDays++;
            }
            return CountDays;
        }

        static int CounterOfDaysOfLastMonth(int days)
        {
            int CountDays = 0;
            for (int i = 1; i<=days; i++)
            {
                CountDays++;
            }
            return CountDays;
        }
        static int CounterOfDaysOfLastMonth(int FromDay,int ToDay)
        {
            int CountDays = 0;
            for (int i = FromDay; i<=ToDay; i++)
            {
                CountDays++;
            }
            return CountDays;
        }
        static List<int> _HandelDaysForMonths(DateTime dtFromDate,DateTime dtToDate)
        {
            List<int> Months = new List<int> { };

            if ((dtToDate.Month-1)==dtFromDate.Month)
                return null;
            int MonthDateTo = dtToDate.Month-1;
            for (int i = dtFromDate.Month; i<MonthDateTo; i++)
            {
                Months.Add(MonthDateTo);
            }

            return Months;
        }
        int _CountDaysInMonth(int Months,DateTime dtToDate)
        {
            int CountDays = 0;
            for (int i = Months; i >=1; i--)
            {
                CountDays+=clsDate.NumberOfDaysInMonth(i, dtToDate.Year);
            }
            return CountDays;
        }

       static int DayCounterFrom_Selected_DayToLastDayInMonth(DateTime Temp_dtFromDate)
        {
            int CountDays = 0;
            int CountDaysInMonth = NumberOfDaysInMonth(Temp_dtFromDate.Month, Temp_dtFromDate.Year);
            int Days = Temp_dtFromDate.Day;

            if (Days==1)
            {
                return CountDaysInMonth;
            }
            do
            {
                CountDays++;
                Days++;
            } while (Days<=CountDaysInMonth);

            return CountDays;

        }
       static int _CalculateTheCostOfRentingFor_90_MaxDate_(DateTime dtFromDate, DateTime dtToDate)
        {
            DateTime Temp_dtFromDate = dtFromDate;
            DateTime Temp_dtToDate = dtToDate;

            int CountDays = 0;
            int ReturnDays = 0;

            while (Temp_dtFromDate.Month!=Temp_dtToDate.Month)
            {
                ReturnDays= DayCounterFrom_Selected_DayToLastDayInMonth(Temp_dtFromDate);
                CountDays+=ReturnDays;
                Temp_dtFromDate=Temp_dtFromDate.AddDays(+ReturnDays);
            }

            CountDays+=(Temp_dtToDate.Day-Temp_dtFromDate.Day)+1;

            //  CountDays+=DaysFromTheParameterBeginDayOfMonth(Convert.ToInt16(Temp_dtFromDate.Day), Temp_dtFromDate.Month, Temp_dtFromDate.Year);
            // CountDays+=DaysFromTheParameterBeginDayOfMonth(Convert.ToInt16(Temp_dtToDate.Day), Temp_dtToDate.Month, Temp_dtToDate.Year);

            return CountDays;
        }

       private int _GetDaysBetweenTowDates(DateTime dtFromDate, DateTime dtToDate)
        {
            TimeSpan ts = dtToDate - dtFromDate;
            return ts.Days;
        }

        public static int CalculateTheCostOfRentingFor_90_MaxDate_(DateTime dtFromDate, DateTime dtToDate)
        {

       //     عليا استخدام ال سباند تايم في هذا المكان لي حساب  عدد الايام بين تارخين
                وعمل المزامنة  مع التايمر لحساب الوقت المتبقي على الشقق وعمل لها تنظيق وصيانة 
                وارسال تنبيهات للادارة  وارسال رسائل للزبائن قبل انتهاء مدة الايجار ب 10 ساعات

                return _GetDaysBetweenTowDates(dtFromDate, dtToDate);
            int CountDays = 0;
            if (dtFromDate.Year==dtToDate.Year)
            {
              return  _CalculateTheCostOfRentingFor_90_MaxDate_(dtFromDate, dtToDate);

            }
            int CountYears = 1;
            DateTime TempToDate = new DateTime(dtFromDate.Year, 12, 31);

            CountDays+=_CalculateTheCostOfRentingFor_90_MaxDate_(dtFromDate, TempToDate);
            DateTime TempFromDate = new DateTime((dtFromDate.Year+CountYears), 1, 1);

            do
            {
                if(TempFromDate.Year!=dtToDate.Year)
                TempToDate = new DateTime(dtFromDate.Year+CountYears, 12, 31);
                else
                {
                    TempToDate = dtToDate;
                    CountYears--;
                }
                CountYears++;

                CountDays+=_CalculateTheCostOfRentingFor_90_MaxDate_(TempFromDate, TempToDate);
                TempFromDate = new DateTime(dtFromDate.Year+CountYears, 1, 1);
            } while (dtToDate.Year!=(dtFromDate.Year+CountYears));
            CountDays+=_CalculateTheCostOfRentingFor_90_MaxDate_(TempFromDate, dtToDate);



            return CountDays;
        }


        static void CalculateTheCostOfRentingForMonths__(DateTime dtFromDate,DateTime dtToDate,ref int rCountDays,ref int rCountMonths)
        {


            int CountDays = 0;
            List<int> Months = new List<int> { };
           
            if (((dtToDate.Month-1)>dtFromDate.Month))
            {
                Months = _HandelDaysForMonths(dtFromDate,dtToDate);
            }

            if (Months!=null)
            {
                rCountMonths+=Months.Count;
                // CountDays+=_CountDaysInMonth(Months);
            }

            int DaysMonthDateFrom = NumberOfDaysInMonth(dtFromDate.Month, dtFromDate.Year);
            int DaysMonthDateTo = NumberOfDaysInMonth(dtToDate.Month, dtToDate.Year);

            if (dtFromDate.Month==dtToDate.Month&&dtFromDate.Year==dtToDate.Year)
            {
                CountDays+= CounterOfDaysOfThisMonth(dtToDate.Day,dtFromDate);
            }
            else
            {
                CountDays+= CounterOfDaysOfThisMonth(DaysMonthDateFrom,dtFromDate);
            }

            if (dtFromDate.Month!=dtToDate.Month&&dtToDate.Year==dtFromDate.Year)
            {
                CountDays+=CounterOfDaysOfLastMonth(dtToDate.Day);
            }


           
                rCountDays+=CountDays;
             
           
            //txtTotalees.Text=TotalFees.ToString();
        //    return TotalFees;
        }
      
        public static void CalculateTheCostOfRentingForYears__(DateTime dtFromDate, DateTime dtToDate, ref int rCountDays, ref int rCountMonths)
        {
            //int rCountDays = 0;
            //int rCountMonths = 0;
         //   int CountDays = 0;



            DateTime Orginal_dtFromDate = dtFromDate;

            if ((dtFromDate==null || dtToDate==null)) return;

            while (Orginal_dtFromDate.Year <dtToDate.Year)
            {
                if(dtToDate.Month==12)
                    CalculateTheCostOfRentingForMonths__(Orginal_dtFromDate, new DateTime(Orginal_dtFromDate.Year, 12, dtToDate.Day), ref rCountDays, ref rCountMonths);
                else
                    CalculateTheCostOfRentingForMonths__(Orginal_dtFromDate, new DateTime(Orginal_dtFromDate.Year, 12, 31), ref rCountDays, ref rCountMonths);

                Orginal_dtFromDate=new DateTime(Orginal_dtFromDate.Year+1, 1, 1);
            }

            if ((Orginal_dtFromDate.Year==dtToDate.Year))
            {
                CalculateTheCostOfRentingForMonths__(Orginal_dtFromDate, dtToDate, ref rCountDays, ref rCountMonths);
            }
          
            //if (Orginal_dtFromDate.Month==12)
            //{
            //    CountDays+=CounterOfDaysOfLastMonth(Orginal_dtFromDate.Day, NumberOfDaysInMonth(Orginal_dtFromDate.Month, Orginal_dtFromDate.Year));
            //    Orginal_dtFromDate=new DateTime(Orginal_dtFromDate.Year+1, 1, 1);
            //}

        }

       public static short DaysFromTheParameterBeginDayOfMonth(short BeginDay,int Month,int Year)
        {


            short TotalDays = 0;

            for (short i = BeginDay; i <= NumberOfDaysInMonth(Month,Year) ; i++)
            {
                TotalDays ++;
            }

        

            return TotalDays;
        }
        public static bool IsLeapYear(int Year)
        {
            return ((Year % 4==0&& Year %100!=0)||Year%400==0);
        }

        public  static short DayOfWeekOrder(short Day, short Month, short Year)
        {
            short a, y, m;
            a =(short)((14 - Month) / 12);
            y =(short)(Year - a);
            m =(short)(Month + (12 * a) - 2);
            // Gregorian:
            //0:sun, 1:Mon, 2:Tue...etc
            return (short) ((Day + y + (y / 4) - (y / 100) + (y / 400) + ((31 * m) / 12)) % 7);
        }

      

        public static string DayShortName(short DayOfWeekOrder)
        {
            string[] arrDayNames = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            return arrDayNames[DayOfWeekOrder];

        }

        public static int NumberOfDaysInMonth(int Month,int Year)
        {
            if (Month<1 ||Month>12 || Year<1)
                return -1;

            int[] DaysCount
               =new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            return (Month==2) ? IsLeapYear(Year) ? 29:28 :DaysCount[Month-1];


        }
        

        public static bool IsLastDayInMonth(DateTime Date)
        {

            return (Date.Day==NumberOfDaysInMonth(Date.Month, Date.Year));
        }
        public static bool IsFirstDayInMonth(DateTime Date)
        {
            int DayInMonth = NumberOfDaysInMonth(Date.Month, Date.Year)+1;
            DayInMonth-=(DayInMonth-1);
            return (Date.Day==DayInMonth);
        }



    }
}
