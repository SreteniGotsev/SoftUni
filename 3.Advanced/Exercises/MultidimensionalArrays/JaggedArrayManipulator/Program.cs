using System;
using System.Linq;

namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimension = int.Parse(Console.ReadLine());

            double[][] comb = new double[dimension][];

            for (int i = 0; i < dimension; i++)
            {
                comb[i] = Console.ReadLine().Split().Select(double.Parse).ToArray();

            }

            for (int i = 0; i < dimension - 1; i++)
            {
                if (comb[i].Length == comb[i + 1].Length)
                {
                    for (int j = 0; j < comb[i].Length; j++)
                    {
                        comb[i][j] *= 2;
                        comb[i + 1][j] *= 2;
                    }
                }
                else
                {
                    for (int j = 0; j < comb[i].Length; j++)
                    {
                        comb[i][j] /= 2;

                    }

                    for (int j = 0; j < comb[i + 1].Length; j++)
                    {
                        comb[i + 1][j] /= 2;
                    }

                }


            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "End")
            {

                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);

                bool isValid = row >= 0 && row < dimension && col >= 0 && col < comb[row].Length;

                switch (command[0])
                {

                    case "Add":

                        if (isValid)
                        {
                            comb[row][col] += double.Parse(command[3]);
                        }

                        break;

                    case "Subtract":

                        if (isValid)
                        {
                            comb[row][col] -= double.Parse(command[3]);

                        }

                        break;

                    default:
                        break;
                }
                command = Console.ReadLine().Split();
            }

            foreach (var item in comb)
            {
                Console.WriteLine(string.Join(" ", item));
            }

        }

    }
}

