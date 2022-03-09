using System;
using System.Linq;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isBigger = true;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNum = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int element = arr[j];
                    if (element >= currentNum)
                    {
                        isBigger = false;
                        break;
                    }
                }
                if (isBigger)
                {
                 Console.Write(currentNum + " ");
                }
                    isBigger = true;
            }
        }
    }
}
