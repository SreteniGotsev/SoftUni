using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Tire
    {
        public Tire(double preasure, int age)
        {
            if (preasure < 1)
            {
                IsLow = true;
            }
            this.Pressure = preasure;
            this.Age = age;
        }

        public bool IsLow { get; set; }
        public double Pressure { get; set; }

        public int Age { get; set; }
    }
}
