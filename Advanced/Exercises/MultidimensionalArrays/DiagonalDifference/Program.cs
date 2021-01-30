using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] cube = new int[size,size];

            for (int i = 0; i < size; i++)
            {

                int[] currArray = Console.ReadLine()
                                         .Split()
                                         .Select(int.Parse)
                                         .ToArray();

                for (int j = 0; j < size; j++)
                {                     
                    cube[i, j] = currArray[j];
                }
            }

            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < size; i++)
            {                
                    sum1 += cube[i, i];                  
                
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = size - 1; j >= 0; j--)
                {
                    sum2 += cube[i, j];
                    i++;
                }
            }

            int sum = Math.Abs(sum1 - sum2);

            Console.WriteLine(sum);

        }      
         
    }
}
