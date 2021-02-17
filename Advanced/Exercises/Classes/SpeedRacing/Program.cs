using System;
using System.Collections.Generic;
using System.Linq;
using SpeedRacing;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string carModel = input[0];
                double fuel = double.Parse(input[1]);
                double fuelConsumption = double.Parse(input[2]);

                Car current = new Car { Model = carModel, FuelAmount = fuel, FuelConsumptionPerKilometer = fuelConsumption };

                cars.Add(current);
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {
                string model = command[1];
                double distance = double.Parse(command[2]);

                Car car = cars.First(car => car.Model == model);

                bool isDriven = car.Drive(distance);

                if (!isDriven)
                {
                    Console.WriteLine("Insufficient fuel for the drive") ;
                }

                command = Console.ReadLine().Split();
            }

            foreach (var item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:f2} {item.TravelledDistance}");
            }
        }
    }
}
