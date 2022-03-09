using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            int count = int.Parse(Console.ReadLine());


            for (int i = 0; i < count; i++)
            {
                string input = Console.ReadLine();
                Car car = new Car(input);
                cars.Add(input.Split().ToArray()[0], car);
            }

            string command = Console.ReadLine();

            while (command.Split()[0] != "End")
            {
                cars.First(x => x.Key == command.Split()[1]).Value.Drive(int.Parse(command.Split()[2]));
                
                command = Console.ReadLine();
            }

            foreach (var item in cars)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
