using System;
using System.Linq;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToArray();

            char[,] cube = new char[dimensions[0], dimensions[1]];

            char[] snake = Console.ReadLine().ToCharArray();

            int c = 0;


            for (int i = 0; i < dimensions[0]; i++)
            {



                if (i % 2 == 0)
                {

                    for (int j = 0; j < dimensions[1]; j++)
                    {
                        cube[i, j] = snake[c];
                        c++;

                        if (c >= snake.Length)
                        {
                            c = 0;
                        }
                    }

                }
                else
                {
                    for (int j = dimensions[1] - 1; j >= 0; j--)
                    {
                        cube[i, j] = snake[c];
                        c++;

                        if (c >= snake.Length)
                        {
                            c = 0;
                        }
                    }
                }

            }

            for (int i = 0; i < dimensions[0]; i++)
            {
                for (int j = 0; j < dimensions[1]; j++)
                {
                    Console.Write(cube[i, j] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
