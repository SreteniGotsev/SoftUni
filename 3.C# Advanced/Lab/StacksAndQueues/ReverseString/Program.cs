using System;
using System.Collections.Generic;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Stack<char> word = new Stack<char>();

            foreach (var item in text)
            {
                word.Push(item);
            }

            while (word.Count > 0)
            {


                Console.Write(word.Pop());

            }

        }
    
    }
}
