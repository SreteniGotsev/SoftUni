using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            int[] dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int, int, int> division = Divide;

            
            Queue<int> queue = new Queue<int>();

            for (int i = 1; i < length; i++)
            {
                queue.Enqueue(i);
            }

            for (int i = 0; i < queue.Count; i++)
            {
                for (int j = 0; j < dividers.Length; j++)
                {
                   int num =  Divide(queue.Dequeue(), dividers[j]);
                    if (num != -1)
                    {
                        queue.Enqueue(num);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", queue));
        }

        private static int Divide(int length, int divider)
        {
            if (length % divider == 0)
            {
                return length;
            }
            return -1;
        }
    }
}
