using System;
using System.Collections.Specialized;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            int counter = VowelCount(input);
            Console.WriteLine(counter);

        }

        static int VowelCount(string text)
        {

            //char[] arr = new char[text.Length];
            //for (int i = 0; i < text.Length; i++)
            //{
            //    arr[i] = text[i];
            //}
            char[] arr = text.ToCharArray();
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                char curr = arr[i];
                if (curr == 'a'|| curr == 'e' || curr == 'i' || curr == 'o' || curr == 'u')
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
