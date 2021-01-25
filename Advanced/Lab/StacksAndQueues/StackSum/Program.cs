using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> sum = new Stack<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                sum.Push(numbers[i]);
            }

            string comand = Console.ReadLine();
            int output = 0;

            while (comand != "end")
            {
                string[] tokens = comand.Split();

                string action = tokens[0].ToLower();

                if (action == "add")
                {
                    for (int i = 1; i <= 2; i++)
                    {
                        sum.Push(int.Parse(tokens[i]));
                    }
                }
                else if (action == "remove")
                {
                    for (int i = 0; i < int.Parse(tokens[1]); i++)
                    {
                        sum.Pop();
                    }
                }

                comand = Console.ReadLine();

            }

            while (sum.Count > 0)
            {
                output += sum.Pop();
            }

            Console.WriteLine($"Sum: {output}");
        }
    }
}
