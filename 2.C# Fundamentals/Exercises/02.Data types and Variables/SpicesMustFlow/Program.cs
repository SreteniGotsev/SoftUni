using System;
using System.Diagnostics.Tracing;

namespace SpicesMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstDay = int.Parse(Console.ReadLine());
            int income = 0;
            int counter = 0;

            for (int i = firstDay; i >= 100; i -= 10)
            {
                income += i;
                income -= 26;
                counter++;
            }
            if (income >= 26)
            {
                income -= 26;
            }
            else
            {
                income = 0;
            }

            Console.WriteLine(counter);
            Console.WriteLine(income);
        }
    }
}
