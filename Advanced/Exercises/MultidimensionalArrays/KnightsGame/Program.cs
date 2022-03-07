using System;

namespace KnightsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] board = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    board[row, col] = input[col];
                }
            }

            int removedKnights = 0;

            while (true)
            {
                int maxAttackedKnight = 0;
                int knightRow = 0;
                int knightCol = 0;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        char a = board[row, col];

                        if (a != 'K')
                        {
                            continue;
                        }

                        int count = CountAttacks(board, row, col);

                        if (count > maxAttackedKnight)
                        {
                            maxAttackedKnight = count;
                            knightCol = col;
                            knightRow = row;
                        }
                    }
                }

                if (maxAttackedKnight == 0)
                {
                    break;
                }

                board[knightRow, knightCol] = '0';
                removedKnights++;

            }

            Console.WriteLine(removedKnights);
        }

        private static int CountAttacks(char[,] board, int row, int col)
        {
            int count = 0;

            if (ContainsKnight(board, row - 2, col  - 1))
            {
                count++;
            }

            if (ContainsKnight(board, row - 2, col  + 1))
            {
                count++;
            }

            if (ContainsKnight(board, row - 1, col  - 2))
            {
                count++;
            }

            if (ContainsKnight(board, row - 1, col  + 2))
            {
                count++;
            }

            if (ContainsKnight(board, row + 1, col  - 2))
            {
                count++;
            }

            if (ContainsKnight(board, row + 1, col  + 2))
            {
                count++;
            }

            if (ContainsKnight(board, row + 2, col  - 1))
            {
                count++; 
            }
            
            if (ContainsKnight(board, row + 2, col  + 1))
            {
                count++;
            }

            return count;
        }

        private static bool ContainsKnight(char[,] board, int row, int col)
        {
            if(!(row >= 0 && row < board.GetLength(0) && col >= 0 && col < board.GetLength(0)))
            {
                return false;
            }

            return board[row, col] == 'K';
        }
    }
}
