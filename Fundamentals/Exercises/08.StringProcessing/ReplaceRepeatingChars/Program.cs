using System;
using System.Text;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length - 1; i++)
            {
                char a = input[i];
                char b = input[i + 1];

                if (a != b)
                {
                    sb.Append(a);
                }

            }
                sb.Append(input[input.Length - 1]);

            Console.WriteLine(sb.ToString());
        }
    }
}
