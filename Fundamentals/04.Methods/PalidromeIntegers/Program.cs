using System;
using System.Runtime.InteropServices;
using System.Xml;

namespace PalidromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();

            while (input != "END")
            {
                Console.WriteLine(Reverse(input));
                input = Console.ReadLine();
            }
        }

        static string Reverse(string input)
        {
            string output = string.Empty;
            char[] arr = input.ToCharArray();
            char[] arr2 = new char[input.Length];
            int counter = 0;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                arr2[i] = arr[counter];
                counter++;
            }
            string check = string.Join(" ", arr);
            string check2 = string.Join(" ", arr2);

            if ( check == check2)
            {
                output = "true";
            }
            else
            {
                output = "false";
            }
            return output;
        }
    }
}
