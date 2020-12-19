using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace SmallestOfTreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];

            for (int i = 0; i < 3; i++)
            {
                array[i] = int.Parse(Console.ReadLine());

            }

            int smallestNum = Counter(array);
            Console.WriteLine(smallestNum);

        }

        static int Counter(int[] number) 
        {
            int smallestNum = int.MaxValue;
            for (int i = 0; i < number.Length; i++)
            {
                int num = number[i];
                if (num < smallestNum)
                {
                    smallestNum = num;
                }
            }

            return smallestNum;
        }
    }
}
