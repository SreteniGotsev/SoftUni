using System;
using System.Diagnostics.Tracing;
using System.Linq;

namespace MaxSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                               .Split()
                               .Select(int.Parse)
                               .ToArray();
            int counter = 1;
            int bestCounter = 0;
            int bestIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentNum = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int nextNum = arr[j];
                    if (currentNum == nextNum)
                    {                      
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (counter > bestCounter)
                {
                    bestCounter = counter;
                    bestIndex = i;
                }

                counter = 1;
            }
            for (int i = 0; i < bestCounter; i++)
            {
            Console.Write(arr[bestIndex] + " ");
            }
        }
    }
}
