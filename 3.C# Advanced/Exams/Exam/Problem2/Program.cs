using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] matrix = new char[size, size];

            Queue<string> commands = new Queue<string>(Console.ReadLine().Split(","));

            int playerOne = 0;
            int playerTwo = 0;
            int totalCount = 0;

            for (int row = 0; row < size; row++)
            {

                string t = String.Join("",Console.ReadLine().Split(" "));
                char[] input = t.ToArray();    
                                               

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = input[col];

                    if (input[col] == '<')
                    {
                        playerOne++;
                    }
                    else if (input[col] == '>')
                    {
                        playerTwo++;
                    }
                }
            }

            totalCount = playerOne + playerTwo;

            int count = 1;

            while (commands.Count > 0 && playerOne > 0 && playerTwo > 0)
            {
                string[] command = commands.Dequeue().Split();

                int targetRow = int.Parse(command[0]);
                int targetCol = int.Parse(command[1]);

                if (InTarget(targetRow, targetCol, size))
                {
                    switch (matrix[targetRow, targetCol])
                    {
                        case '>':
                            if (count % 2 == 1)
                            {
                                matrix[targetRow, targetCol] = 'X';
                                playerTwo--;
                            }
                            break;

                        case '<':

                            if (count % 2 == 0)
                            {
                                matrix[targetRow, targetCol] = 'X';
                                playerOne--;
                            }
                            break;

                        case '#':

                            matrix[targetRow, targetCol] = 'X';

                            if (InTarget(targetRow - 1, targetCol - 1, size) && matrix[targetRow, targetCol] != '*')
                            {

                                if (matrix[targetRow - 1, targetCol - 1] == '<')
                                {
                                    playerOne--;
                                }
                                else if (matrix[targetRow - 1, targetCol - 1] == '>')
                                {
                                    playerTwo--;
                                }

                                matrix[targetRow - 1, targetCol - 1] = 'X';
                            }

                            if (InTarget(targetRow - 1, targetCol, size) && matrix[targetRow, targetCol] != '*')
                            {
                                if (matrix[targetRow - 1, targetCol] == '<')
                                {
                                    playerOne--;
                                }
                                else if (matrix[targetRow - 1, targetCol] == '>')
                                {
                                    playerTwo--;
                                }
                                matrix[targetRow - 1, targetCol] = 'X';
                            }

                            if (InTarget(targetRow - 1, targetCol + 1, size) && matrix[targetRow, targetCol] != '*')
                            {
                                if (matrix[targetRow - 1, targetCol + 1] == '<')
                                {
                                    playerOne--;
                                }
                                else if (matrix[targetRow - 1, targetCol + 1] == '>')
                                {
                                    playerTwo--;
                                }
                                matrix[targetRow - 1, targetCol + 1] = 'X';
                            }

                            if (InTarget(targetRow, targetCol - 1, size) && matrix[targetRow, targetCol] != '*')
                            {
                                if (matrix[targetRow, targetCol - 1] == '<')
                                {
                                    playerOne--;
                                }
                                else if (matrix[targetRow, targetCol - 1] == '>')
                                {
                                    playerTwo--;
                                }
                                matrix[targetRow, targetCol - 1] = 'X';
                            }

                            if (InTarget(targetRow + 1, targetCol + 1, size) && matrix[targetRow, targetCol] != '*')
                            {
                                if (matrix[targetRow, targetCol + 1] == '<')
                                {
                                    playerOne--;
                                }
                                else if (matrix[targetRow, targetCol + 1] == '>')
                                {
                                    playerTwo--;
                                }
                                matrix[targetRow, targetCol + 1] = 'X';
                            }

                            if (InTarget(targetRow + 1, targetCol - 1, size) && matrix[targetRow, targetCol] != '*')
                            {
                                if (matrix[targetRow + 1, targetCol - 1] == '<')
                                {
                                    playerOne--;
                                }
                                else if (matrix[targetRow + 1, targetCol - 1] == '>')
                                {
                                    playerTwo--;
                                }
                                matrix[targetRow + 1, targetCol - 1] = 'X';
                            }

                            if (InTarget(targetRow + 1, targetCol, size) && matrix[targetRow, targetCol] != '*')
                            {
                                if (matrix[targetRow + 1, targetCol] == '<')
                                {
                                    playerOne--;
                                }
                                else if (matrix[targetRow + 1, targetCol] == '>')
                                {
                                    playerTwo--;
                                }
                                matrix[targetRow + 1, targetCol] = 'X';
                            }

                            if (InTarget(targetRow + 1, targetCol + 1, size) && matrix[targetRow, targetCol] != '*')
                            {
                                if (matrix[targetRow + 1, targetCol + 1] == '<')
                                {
                                    playerOne--;
                                }
                                else if (matrix[targetRow + 1, targetCol + 1] == '>')
                                {
                                    playerTwo--;
                                }
                                matrix[targetRow + 1, targetCol + 1] = 'X';
                            }
                            break;


                        default:
                            break;
                    }

                }
                count++;
            }


            if (commands.Count > 0)
            {
                Console.WriteLine($"It's a draw! Player One has {playerOne} ships left. Player Two has {playerTwo} ships left.");
                return;
            }

            if (playerOne > playerTwo)
            {
                Console.WriteLine($"Player One has won the game! {totalCount - (playerOne + playerTwo)} ships have been sunk in the battle.");
            }
            else if (playerTwo > playerOne)
            {
                Console.WriteLine($"Player Two has won the game! {totalCount - (playerOne + playerTwo)} ships have been sunk in the battle.");
            }
            else
            {
                Console.WriteLine($"It's a draw! Player One has {playerOne} ships left. Player Two has {playerTwo} ships left.");
            }




        }

        private static bool InTarget(int targetRow, int targetCol, int size)
        {
            if (targetRow >= 0 && targetRow < size && targetCol >= 0 && targetCol < size)
            {
                return true;
            }

            return false;
        }
    }
}
