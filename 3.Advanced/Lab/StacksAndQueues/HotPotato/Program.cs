using System;
using System.Collections.Generic;
using System.Linq;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kids = Console.ReadLine().Split();

            int tosses = int.Parse(Console.ReadLine());

            Queue<string> children = new Queue<string>();

            foreach (var kid in kids)
            {
                children.Enqueue(kid);
            }

            int counter = 1;

            while (children.Count > 1)
            {

                if (counter == tosses)
                {
                    Console.WriteLine($"Removed {children.Dequeue()}");
                    counter = 1;
                }
                else
                {
                    counter++;
                    children.Enqueue(children.Dequeue());
                }

            }
            Console.WriteLine($"Last is {children.Dequeue()}");
        }
    }
}
