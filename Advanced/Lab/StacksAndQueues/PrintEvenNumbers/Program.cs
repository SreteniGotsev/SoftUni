using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();
            Queue<int> queue2 = new Queue<int>();

            foreach (var item in nums)
            {
                queue.Enqueue(item);
            }

            while (queue.Count > 0)
            {
                if (queue.Peek() % 2 == 0)
                {
                    queue2.Enqueue(queue.Dequeue());
                }
                else
                {
                    queue.Dequeue();
                }
            }
            
                    Console.WriteLine(string.Join(", ", queue2));
        }
    }
}
