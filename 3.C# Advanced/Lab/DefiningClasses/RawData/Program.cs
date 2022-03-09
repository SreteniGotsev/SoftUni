using System;
using System.Collections.Generic;
using System.Linq;
using RawData;

namespace RawData
{
    class StartUp
    {
        public static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            bool isLow;

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split();

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeigth = int.Parse(input[3]);
                string cargoType = input[4];
                double tire1Pressure = double.Parse(input[5]);
                int tire1Age = int.Parse(input[6]);
                double tire2Pressure = double.Parse(input[7]);
                int tire2Age = int.Parse(input[8]);
                double tire3Pressure = double.Parse(input[9]);
                int tire3Age = int.Parse(input[10]);
                double tire4Pressure = double.Parse(input[11]);
                int tire4Age = int.Parse(input[12]);

                Car car = new Car(model, engineSpeed, enginePower, cargoWeigth, cargoType,
                    tire1Pressure, tire1Age, tire2Pressure, tire2Age, tire3Pressure, tire3Age, tire4Pressure, tire4Age);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                cars.Where(t => t.Tires.Any)
                foreach (Car car in cars.Where(c => c.Cargo.CargpType == command && c.Tires.Any())
                {
                    Console.WriteLine(car.Model);
                }
            }
            else
            {
                foreach (Car car in cars.Where(c => c.Cargo.CargpType == command && c.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }


        }
    }
}
