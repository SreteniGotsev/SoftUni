using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    for (int i = names.Count; i > 0; i--)
                    {                                     
                        Console.WriteLine(names.Dequeue());
                    }
                }
                else
                {
                    names.Enqueue(input);
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($" {names.Count} people remaining.");
        }
    }
}
