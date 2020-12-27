using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] original = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            StringBuilder sb = new StringBuilder();

            foreach (var word in original)
            {
                char[] input = word.ToCharArray();
                char[] code = new char[input.Length];

                for (int i = 0; i < input.Length; i++)
                {
                    int num = (int)input[i] + 3;
                    code[i] = (char)num;
                }
                string newWord = new string(code);
                sb.Append(newWord +"#");
            }

            Console.WriteLine(sb.ToString().TrimEnd('#'));
        }
    }
}
