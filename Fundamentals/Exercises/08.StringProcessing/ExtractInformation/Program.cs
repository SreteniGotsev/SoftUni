using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace ExtractInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                List<string> names = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();
                foreach (var item in names)
                {
                    if (item.Contains('@')) ;
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
}
