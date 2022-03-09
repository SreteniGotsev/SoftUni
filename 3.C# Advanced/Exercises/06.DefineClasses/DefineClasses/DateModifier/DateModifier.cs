using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        public DateModifier()
        {

        }

        public void Modify(Date date1, Date date2)
        {
            int num = Math.Abs(date1.Year - date2.Year) * 365;
            if (date1.Month > date2.Month)
            {
                num += Math.Abs(date1.Month - date2.Month) * 30;

            }
            
        }
    }
}
