using Microsoft.VisualBasic;
using System;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string word1 = input[0];
            string word2 = input[1];

            string longerword = word1;
            string shorterword = word2;

            if (word1.Length < word2.Length)
            {
                longerword = word2;
                shorterword = word1;
            }

            int sum = Sum(longerword, shorterword);
            
            
            Console.WriteLine(sum);
        }

        static int Sum(string longerword, string shorterword)
        {                   
           int sum = 0;

            for (int i = 0; i < shorterword.Length; i++)
            {
                int product = longerword[i] * shorterword[i];
                sum += product;
            }

            for (int i = shorterword.Length; i < longerword.Length; i++)
            {
                sum += longerword[i];
            }

           return sum;
        }
    }
}
