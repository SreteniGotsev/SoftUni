using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DateModifier
{
    public class Date
    {
        public Date(string date)
        {
            int[] data = date.Split("").Select(int.Parse).ToArray();
            Year = data[0];
            Month = data[1];
            Day = data[2];

        }

        private int year;
        private int month;
        private int day;

        public int Year { get => this.year; set { this.year = value; } }
        public int Month { get => this.month; set { this.month = value; } }
        public int Day { get => this.day ; set { this.day = value; } }

    }
}
