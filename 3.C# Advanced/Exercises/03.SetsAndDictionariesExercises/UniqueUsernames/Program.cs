using System;
using System.Collections.Generic;

namespace UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            HashSet<string> set = new HashSet<string>();

            for (int i = 0; i < number; i++)
            {
                set.Add(Console.ReadLine());
            }

            foreach (var name in set)
            {
                Console.WriteLine(name);
            }
        }
    }
}
