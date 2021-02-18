using System;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    public class Car
    {
        public Car(string make, string model, int horsePower, string regNum)
        {
            this.Make = make;
            this.Model = model;
            this.HorsePower = horsePower;
            this.RegistrationNumber = regNum;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public string RegistrationNumber { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Make: {this.Make}" + Environment.NewLine);
            sb.Append($"Model: {this.Model}" + Environment.NewLine);
            sb.Append($"HorsePower: {this.HorsePower}" + Environment.NewLine);
            sb.Append($"RegistrationNumber: {this.RegistrationNumber}");

            return sb.ToString();
        }

    }
}
