using System;
using System.Collections.Generic;
using System.Linq;

namespace SetesOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sets = Console.ReadLine().Split()
                                           .Select(int.Parse)
                                           .ToArray();
            int n = sets[0];
            int m = sets[1];


            HashSet<int> firstSet = new HashSet<int>(n);
            HashSet<int> secondSet = new HashSet<int>(m);

            for (int i = 0; i < n + m; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (i < n)
                {
                    firstSet.Add(currentNum);
                }
                else
                {
                    secondSet.Add(currentNum);
                }
            }

            HashSet<int> duplicates = new HashSet<int>();

            foreach (var number in firstSet)
            {
                foreach (var number2 in secondSet)
                {
                    if (number == number2)
                    {
                        duplicates.Add(number);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", duplicates));
        }
    }
}
