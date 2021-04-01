using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string[]> arrays = Console.ReadLine()
                                         .Split("|")
                                         .Select(x => x.Split(" ", StringSplitOptions.RemoveEmptyEntries))
                                         .ToList();

            arrays.Reverse();

            foreach (var item in arrays)
            {
                if (item.Length > 0)
                {

                    Console.Write(string.Join(" ", item) + " ");
                }
            }

        }
    }
}
