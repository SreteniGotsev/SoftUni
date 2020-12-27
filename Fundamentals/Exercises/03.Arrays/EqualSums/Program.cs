using System;
using System.Linq;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                               .Split(" ")
                               .Select(int.Parse)
                               .ToArray();
            bool isfound = false;
            
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNum = arr[i];
                int sumLeft = 0;
                int sumRight = 0;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    sumRight += arr[j];
                }

                for (int k = i - 1 ; k >= 0; k--)
                {
                    sumLeft += arr[k];
                }

                if (sumRight == sumLeft)
                {
                    index = i;
                    isfound = true;
                    Console.WriteLine(index);

                    break;
                }
                isfound = false;
            }

            if (!isfound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
