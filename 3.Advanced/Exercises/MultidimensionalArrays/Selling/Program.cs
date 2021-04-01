using System;

namespace Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            char[,] matrix = new char[length, length];

            int currRow = 0;
            int currCol = 0;

            int pillarRow = 0;
            int pillarCol = 0;

            int pillar2Row = 0;
            int pillar2Col = 0;

            int pillarCount = 0;


            for (int row = 0; row < length; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < length; col++)
                {
                    matrix[row, col] = input[col];

                    if (input[col] == 'S')
                    {
                        currRow = row;
                        currCol = col;
                    }
                    else if (input[col] == 'O' && pillarCount == 0)
                    {
                        pillarRow = row;
                        pillarCol = col;
                        pillarCount++;
                    }
                    else if (input[col] == 'O')
                    {
                        pillar2Row = row;
                        pillar2Col = col;
                    }
                }
            }

            int money = 0;

            string command = Console.ReadLine();
           

            while (true)
            {
                matrix[currRow, currCol] = '-';
                
                currRow = Row(currRow, command);
                currCol = Cow(currCol, command);

                if (!IsIn(currRow, currCol, length))
                {
                    Console.WriteLine("Bad news, you are out of the bakery.");
                    
                    break;
                }

                switch (matrix[currRow, currCol])
                {
                    case 'O':

                        if (matrix[currRow, currCol] == matrix[pillarRow, pillarCol])
                        {
                            currRow = pillar2Row;
                            currCol = pillar2Col;
                            matrix[pillarRow, pillarCol] = '-';
                            
                        }
                        else
                        {
                            currRow = pillarRow;
                            currCol = pillarCol;
                            matrix[pillar2Row, pillar2Col] = '-';
                            
                        }

                        break;

                    case '-':

                        break;

                    default:
                        //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                        int customer = int.Parse(matrix[currRow, currCol].ToString());
                        money += customer;
                        break;
                }

                matrix[currRow, currCol] = 'S';

                if (money >50)
                {
                    break;
                }
                command = Console.ReadLine();

            }

            if(money > 50)
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
            }

            Console.WriteLine($"Money: {money}");

            for (int rol = 0; rol < length; rol++)
            {
                for (int col = 0; col < length; col++)
                {
                    Console.Write(matrix[rol,col]);
                }
                Console.WriteLine();
            }
        }

        private static int Cow(int currCol,string command)
        {
            if (command == "left")
            {
                return currCol - 1;
            }
            else if (command == "right")
            {
                return currCol + 1;
            }

            return currCol;
        }

        private static int Row(int currRow, string command)
        {
            if (command == "up")
            {
                return currRow - 1;
            }
            else if (command == "down")
            {
                return currRow + 1;
            }

            return currRow;
        }

        public static bool IsIn(int row, int col, int length)
        {
            if (row >= 0 && row < length && col >= 0 && col < length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
