using Itenso.TimePeriod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace DateModifier
{
    public static class DateModifier
    {
        public static int DateDiff (string date1, string  date2)
        {
            DateTime firstDate = DateTime.Parse(date1);
            DateTime secondDate= DateTime.Parse(date2);

            TimeSpan datediff = firstDate - secondDate;

            return datediff.Days;
            
        }



    }
}
