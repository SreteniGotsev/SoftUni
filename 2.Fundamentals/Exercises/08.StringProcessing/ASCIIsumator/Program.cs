using System;

namespace ASCIIsumator
{
    class Program
    {
        static void Main(string[] args)
        {
            char beg = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = beg; i <= end; i++)
            {
                sum += i;
            }
            Console.WriteLine(sum);
        }
    }
}
