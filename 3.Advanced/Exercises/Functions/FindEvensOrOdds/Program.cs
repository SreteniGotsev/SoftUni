using System;
using System.Collections.Generic;
using System.Linq;

namespace FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bounds = Console.ReadLine()
                                  .Split()
                                  .Select(int.Parse)
                                  .ToArray();

            int lowerBound = bounds[0];
            int upperBound = bounds[1];

            Func<int, int, string, List<int>> oddOrEven = FindOut;

            string command = Console.ReadLine();

            Console.WriteLine(string.Join(" ",oddOrEven(lowerBound, upperBound, command)));


        }

        private static List<int> FindOut(int lowerBoand, int upperBoand, string condition)
        {
            List<int> output = new List<int>();

            for (int i = lowerBoand; i < upperBoand; i++)
            {
                if (condition == "odd" && i % 2 == 1)
                {
                    output.Add(i);
                }
                else if (condition == "even" && i % 2 == 0)
                {
                    output.Add(i);
                }
            }
            

            return output;
        }
    }
}
