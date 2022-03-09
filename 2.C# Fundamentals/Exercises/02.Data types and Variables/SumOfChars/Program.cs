using System;
using System.Text;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
           int n =  int.Parse(Console.ReadLine());
           string digit = String.Empty;
           double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                digit = Console.ReadLine();
                sum += char.Parse(digit);
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}

