using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<string> names = new List<string>();
            List<string> currentInput = new List<string>();
            for (int i = 0; i < count; i++)
            {
                currentInput = Console.ReadLine()                                      
                                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                      .ToList();
                if (currentInput[2] == "going!")
                {
                    if (names.Contains(currentInput[0]))
                    {
                        Console.WriteLine($"{currentInput[0]} is already in the list!");
                    }
                    else
                    {
                    names.Add(currentInput[0]);
                    }

                }
                else if (currentInput.Contains("not"))
                {
                    if (names.Contains(currentInput[0]))
                    {
                        names.Remove(currentInput[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{currentInput[0]} is not in the list!");
                    }
                }
            }
            for (int i = 0; i < names.Count; i++)
            {
            Console.WriteLine(names[i]);

            }
        }
    }
}
