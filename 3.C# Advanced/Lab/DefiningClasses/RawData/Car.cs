using System;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    public class Car
    {
        public Car(string model, int engineSpeed, int enginePower, int cargoWeigth, string cargoType,
            double tire1Pressure, int tire1Age,
            double tire2Pressure, int tire2Age,
            double tire3Pressure, int tire3Age,
            double tire4Pressure, int tire4Age)
        {
            this.Model = model;
            this.Engine = new Engine(engineSpeed, enginePower);
            this.Cargo = new Cargo(cargoWeigth, cargoType);            
            Tires = new List<Tire>();
            Tires.Add(new Tire(tire1Pressure, tire1Age));
            Tires.Add(new Tire(tire2Pressure, tire2Age));
            Tires.Add(new Tire(tire3Pressure, tire3Age));
            Tires.Add(new Tire(tire4Pressure, tire4Age));

        }

        
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public List<Tire> Tires { get; set; }


    }
}

