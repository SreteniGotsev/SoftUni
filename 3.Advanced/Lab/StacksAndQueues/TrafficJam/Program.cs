using System;
using System.Collections.Generic;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int cars = int.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            Queue<string> vehicles = new Queue<string>();

            int counter = 0;

            while (input != "end")
            {
                if (input == "green")
                {
                    if (vehicles.Count > cars)
                    {

                        for (int i = 0; i < cars; i++)
                        {
                            Console.WriteLine($"{vehicles.Dequeue()} passed!");
                            counter++;
                        }
                    }
                    else 
                    {
                        int holder = vehicles.Count;
                        for (int i = 0; i < holder; i++)
                        {
                            Console.WriteLine($"{vehicles.Dequeue()} passed!");
                            counter++;
                        }
                        break;
                    }
                }
                else
                {
                    vehicles.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
