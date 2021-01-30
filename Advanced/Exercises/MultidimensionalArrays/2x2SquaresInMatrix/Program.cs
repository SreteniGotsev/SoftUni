using System;
using System.Linq;

namespace _2x2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToArray();

            int dimension1 = dimensions[0];
            int dimension2 = dimensions[1];

            string[,] cube = new string[dimension1,dimension2];


            for (int i = 0; i < dimension1; i++)
            {
                string[] input = Console.ReadLine()
                                         .Split()                                         
                                         .ToArray();

                for (int j = 0; j < dimension2; j++)
                {
                    cube[i, j] = input[j];
                }
            }

            string holder1 = string.Empty;
            string holder2 = string.Empty;
            int count = 0;

            for (int i = 0; i < dimension1 - 1; i++)
            {
                for (int j = 0; j < dimension2; j++)
                {
                    string a = cube[i, j];
                    string b = cube[i + 1, j];

                    if (a==b && holder1 == a)
                    {
                        count++;
                        holder1 = string.Empty;
                        holder2 = string.Empty;
                    }
                    else if (a == b)
                    {
                        holder1 = a;
                        holder2 = b;
                    }
                }
            }

            Console.WriteLine(count);

        }
    }
}
