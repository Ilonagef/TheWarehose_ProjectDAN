using System;
using System.Collections.Generic;
using System.Text;

namespace Warehouse
{
    
    public enum Month {
        January,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    public class Date
    {
        private string Day { get; set; }
        private Month month { get; set; }
        private string Year { get; set; }

        public Date(string day,Month month,string year)
        {
            this.Day = day;
            this.month = month;
            this.Year = Year;
        }
    }
}
