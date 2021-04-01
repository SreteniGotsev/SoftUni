using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int[] pumps = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> stops = new Queue<int>();

            stops.Enqueue(pumps[0]);

            while (true)
            {
                stops.Enqueue(pumps[0]);

                pumps = Console.ReadLine().Split().Select(int.Parse).ToArray();

                stops.Enqueue(pumps[0]);
            }

        }
    }
}
