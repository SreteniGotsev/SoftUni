using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] numbers = Console.ReadLine().ToCharArray();
            int sbor = 0;
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                sbor += int.Parse(numbers[i].ToString());
            }
            Console.WriteLine(sbor);
        }
    }
}
