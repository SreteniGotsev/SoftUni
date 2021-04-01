using System;

namespace MiddCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = Middling(input);
            Console.WriteLine(output);

        }

        static string Middling(string text)
        {
            char[] arr = text.ToCharArray();
            string charHolder = String.Empty;
            string charHolder2 = String.Empty;
            string output = String.Empty;
            bool isEven = true;

            if (arr.Length % 2 == 1)
            {
                charHolder = arr[(arr.Length) / 2].ToString();
                isEven = false;
            }
            else
            {
                isEven = true;
                charHolder = arr[arr.Length / 2 - 1].ToString();
                charHolder2 = arr[arr.Length / 2].ToString();
            }

            if (isEven)
            {
                output = charHolder + charHolder2;
            }
            else
            {
                output = charHolder;
            }

            return output;

        }
    }
}
