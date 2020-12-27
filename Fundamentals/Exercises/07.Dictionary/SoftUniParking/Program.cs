using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int comandsTotal = int.Parse(Console.ReadLine());

            Dictionary<string, string> parking = new Dictionary<string, string>();

            for (int i = 0; i < comandsTotal; i++)
            {
                string[] input = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = input[0];
                string user = input[1];

                switch (command)
                {
                    case "register":

                        string plateNum = input[2];

                        if (!parking.ContainsKey(user))
                        {
                            parking.Add(user, plateNum);
                            Console.WriteLine($"{user} registered {plateNum} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {parking[user]}");
                        }

                        break;

                    case "unregister":

                        if (parking.ContainsKey(user))
                        {
                            parking.Remove(user);
                            Console.WriteLine($"{user} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {user} not found");
                        }


                        break;

                    default:
                        break;
                }

            }

            foreach (var item in parking)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
