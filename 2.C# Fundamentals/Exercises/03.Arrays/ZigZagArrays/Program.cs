using System;
using System.Linq;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] holder1 = new int[number];
            int[] holder2 = new int[number];
            for (int i = 0; i < number; i++)
            {
                int[] array = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                int firstElement = array[0];
                int secondElement = array[1];

                if (i % 2 == 0)
                {
                    holder1[i]= firstElement;
                    holder2[i] = secondElement;
                }
                else if (i % 2 == 1)
                {
                    holder1[i] = secondElement;
                    holder2[i] = firstElement;
                }
            }
            Console.WriteLine(string.Join(" ", holder1));
            Console.WriteLine(string.Join(" ", holder2));


        }
    }
}
