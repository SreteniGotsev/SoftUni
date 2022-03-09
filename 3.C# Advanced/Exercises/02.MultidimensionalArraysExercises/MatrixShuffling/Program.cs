using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToArray();

            string[,] cube = new string[dimensions[0], dimensions[1]];

            for (int i = 0; i < dimensions[0]; i++)
            {
                string[] input = Console.ReadLine()
                                      .Split()
                                      .ToArray();

                for (int j = 0; j < dimensions[1]; j++)
                {
                    cube[i, j] = input[j];
                }
            }

            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "END")
            {
                if (command[0] != "swap" || command.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    command = Console.ReadLine().Split().ToArray();
                    continue;
                }

                int row1 = int.Parse(command[1]);
                int col1 = int.Parse(command[2]);
                int row2 = int.Parse(command[3]);
                int col2 = int.Parse(command[4]);

                string holder = string.Empty;

                if (row1 >= 0 && row1 < dimensions[0]
                    && row2 >= 0 && row2 < dimensions[0]
                    && col1 >= 0 && col1 < dimensions[1]
                    && col2 >= 0 && col2 < dimensions[1])
                {
                    holder = cube[row1, col1];
                    cube[row1, col1] = cube[row2, col2];
                    cube[row2, col2] = holder;

                    for (int i = 0; i < dimensions[0]; i++)
                    {
                        for (int j = 0; j < dimensions[1]; j++)
                        {
                            Console.Write(cube[i, j] + " ");
                        }
                        Console.WriteLine();
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine().Split().ToArray();
            }
        }
    }
}
