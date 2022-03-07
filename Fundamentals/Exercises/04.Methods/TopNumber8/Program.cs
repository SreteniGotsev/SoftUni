using System;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Linq;

namespace TopNumber8
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            PtintNumbering(num);
        }

        static void PtintNumbering(int num)
        {
            for (int i = 0; i <= num; i++)
            {
                string currentNumber = i.ToString();
                int sum = 0;
                bool isOdd = false;

                foreach (var curr in currentNumber)
                {
                    int parsNum = int.Parse(curr.ToString());
                    sum += parsNum;
                    if (i % 2 == 1)
                    {
                        isOdd = true;
                    }                
                }

                if (sum / 8 == 0 && isOdd)
                {
                    Console.WriteLine(i);
                }

            }

        }
    }
}
