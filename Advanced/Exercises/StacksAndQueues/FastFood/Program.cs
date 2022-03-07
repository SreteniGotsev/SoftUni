using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());

            List<int> orders = Console.ReadLine().Split().Select(int.Parse).ToList();

            Queue<int> queue = new Queue<int>();

            int biggestOrder = orders.Max();

            foreach (var item in orders)
            {
                queue.Enqueue(item);
            }

            bool isEnough = true;

            while (food > 0 && queue.Count > 0)
            {
                if (food >= queue.Peek())
                {
                    food -= queue.Dequeue();
                }
                else
                {
                    food = 0;
                    isEnough = false;
                }
            }

            Console.WriteLine(biggestOrder);

            if (isEnough)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
        }
    }
}
