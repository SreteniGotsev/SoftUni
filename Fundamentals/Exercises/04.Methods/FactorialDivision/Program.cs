using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            double factorial = double.Parse(Console.ReadLine());
            double factorial2 = double.Parse(Console.ReadLine());
            //double output = FactorialDivision(factorial, factorial2);
            //Console.WriteLine($"{ output:f2}");
            Console.WriteLine($"{FactorialDivision(factorial, factorial2):f2}");

        }

        static double FactorialDivision(double num, double num2)
        {
            double output;
            double sum1 = 1;
            double sum2 = 1;

            for (int i = 1; i <= num; i++)
            {
                sum1 *= i;
            }
            for (int i = 1; i <= num2; i++)
            {
                sum2 *= i;
            }
            output = sum1 / sum2;
            return output;
        }
    }
}
