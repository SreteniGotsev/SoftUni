using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> passengers = Console.ReadLine()
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .Select(int.Parse)
                                          .ToList();
            int maxCapasity = int.Parse(Console.ReadLine());
            List<string> input = Console.ReadLine()
                                        .ToLower()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToList();
                                        
            while (input[0] != "end")
            {
                if (input[0] == "add")
                {
                    passengers.Add(int.Parse(input[1]));
                }
                else
                {
                    int curr = 0;
                    for (int i = 0; i < passengers.Count; i++)
                    {
                        curr = int.Parse(input[0]);
                        if (passengers[i] + curr <= maxCapasity )
                        {
                            passengers[i] += curr;
                            break;
                        }
                    }
                }
                
                input = Console.ReadLine().ToLower()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToList();
            }
            Console.WriteLine(string.Join(" ", passengers));
        }
    }
}
