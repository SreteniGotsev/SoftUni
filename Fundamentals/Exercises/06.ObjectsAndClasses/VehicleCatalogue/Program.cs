using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> catalouge = new List<Vehicle>();

            string comand = Console.ReadLine();

            while (comand != "End")
            {
                string[] input = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Vehicle vehicle = new Vehicle(input[0].ToLower(), input[1], input[2].ToLower(), int.Parse(input[3]));

                catalouge.Add(vehicle);

                comand = Console.ReadLine();
            }

            string secondComand = Console.ReadLine();

            while (secondComand != "Close the Catalogue")
            {
                string model = secondComand;

                Vehicle car = catalouge.First(x=>x.Model == model);

                Console.WriteLine(car);

                secondComand = Console.ReadLine();
            }

            List<Vehicle> cars = catalouge.Where(x => x.TypeVehicle == "car").ToList();
            List<Vehicle> trucks = catalouge.Where(x => x.TypeVehicle == "truck").ToList();

            double hpCars = cars.Sum(x => x.HorsePower);
            double hpTrucks = trucks.Sum(x => x.HorsePower);

            double averageCarHp = 0.00;
            double averageTruckHp = 0.00;

            if (cars.Count > 0)
            {
                averageCarHp = hpCars / cars.Count;
            }

            if (trucks.Count > 0)
            {
                averageTruckHp = hpTrucks / trucks.Count;
            }

            Console.WriteLine($"Cars have average horsepower of: {averageCarHp:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckHp:f2}.");
        }
    }

    class Vehicle
    {
        public Vehicle(string typeVehicle, string model, string colour, int horsePower)
        {
            TypeVehicle = typeVehicle;
            Model = model;
            Colour = colour;
            HorsePower = horsePower;
        }

        public string TypeVehicle { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public int HorsePower { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Type: {(TypeVehicle == "car" ? "Car" : "Truck")}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Colour}");
            sb.AppendLine($"Horsepower: {HorsePower}");

            return sb.ToString().TrimEnd();
        }
    }
}
