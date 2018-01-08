using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SatisTakipveBildirimSistemi
{
    public static class DateTimeExtention
    {
        public static string GetHumanizeDate(this DateTime date,CultureInfo language)
        {
            Thread.CurrentThread.CurrentCulture = language;
            Thread.CurrentThread.CurrentUICulture = language;

            string dname = language.DateTimeFormat.GetDayName(date.DayOfWeek);
            string mname= language.DateTimeFormat.GetMonthName(date.Month);

         return  string.Format("{0} {1} {2} {3}", date.Day, mname, date.Year, dname);

        }
    }
}
