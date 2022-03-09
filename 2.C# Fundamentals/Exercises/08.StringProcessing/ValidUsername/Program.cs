using System;
using System.Linq;

namespace ValidUsername
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                string curr = input[i];

                if (curr.Length >= 3 && curr.Length <= 16 && curr.All(c => char.IsLetterOrDigit(c)) || curr.Contains("-") || curr.Contains("_"))
                { 
                 Console.WriteLine(curr);

                }
             }
          }
    }
}
