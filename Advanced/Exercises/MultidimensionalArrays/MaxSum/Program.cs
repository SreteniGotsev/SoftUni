using System;
using System.Linq;

namespace MaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToArray();

            int d1 = dimensions[0];
            int d2 = dimensions[1];

            int[,] cube = new int[d1, d2];

            for (int i = 0; i < d1; i++)
            {
                int[] input = Console.ReadLine()
                                     .Split()
                                     .Select(int.Parse)
                                     .ToArray();

                for (int j = 0; j < d2; j++)
                {
                    cube[i, j] = input[j];
                }
            }

            int[] location = new int[2];
            int sum = 0;
            int sumHolder = 0;
            int count = 0;


            for (int i = 0; i < d1 - 2; i++)
            {
                for (int j = 0; j < d2 - 2; j++)
                {

                    int a = cube[i, j];
                    int b = cube[i + 1, j];
                    int c = cube[i + 2, j];
                    sumHolder += a + b + c;

                    a = cube[i, j + 1];
                    b = cube[i + 1, j + 1];
                    c = cube[i + 2, j + 1];
                    sumHolder += a + b + c;

                    a = cube[i, j + 2];
                    b = cube[i + 1, j + 2];
                    c = cube[i + 2, j + 2];
                    sumHolder += a + b + c;                   

                    if (sumHolder > sum)
                    {
                        sum = sumHolder;
                        location[0] = i;
                        location[1] = j;
                    }

                    sumHolder = 0;

                }
            }

            Console.WriteLine(sum);

            for (int i = location[0]; i < location[0] + 3; i++)
            {
                for (int j = location[1]; j < location[1] + 3; j++)
                {
                    Console.Write(cube[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
        
    }
}
