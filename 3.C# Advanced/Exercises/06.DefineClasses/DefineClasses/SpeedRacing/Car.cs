using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpeedRacing
{
  public  class Car
    {
        public Car(string input)
        {
            string[] data = input.Split().ToArray();
            this.Model = data[0];
            this.FuelAmount = double.Parse(data[1]);
            this.FuelConsumptionPerKilometer = double.Parse(data[2]);
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public void Drive(int kms)
        {
            if (this.FuelConsumptionPerKilometer * kms <= this.FuelAmount)
            {
                this.TravelledDistance += kms ;
                this.FuelAmount -= this.FuelConsumptionPerKilometer * kms;

            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");   
            };

        }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:f2} {this.TravelledDistance}"; 
        }
    }
}
