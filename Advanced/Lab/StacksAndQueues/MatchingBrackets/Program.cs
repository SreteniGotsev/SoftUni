using System;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<int> brackets = new Stack<int>();

            int indexHolder = 0;

            for (int i = 0; i < input.Length; i++)
            {
                            
                if (input[i] == '(')
                {
                    brackets.Push(i);                    
                }
                else if (input[i] == ')')
                {
                    indexHolder = brackets.Pop();
                    Console.WriteLine(input.Substring(indexHolder, i - indexHolder + 1));
                }


            }


        }
    }
}
