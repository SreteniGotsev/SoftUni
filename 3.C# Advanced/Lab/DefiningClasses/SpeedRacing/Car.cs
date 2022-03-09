using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public bool Drive (double distanceTravelled)
        {
            double neededFuel = distanceTravelled * this.FuelConsumptionPerKilometer;

            if (neededFuel > FuelAmount)
            {
                return false;
            }

            this.FuelAmount -= neededFuel;
            this.TravelledDistance += distanceTravelled;

            return true;
        }
    }
}
