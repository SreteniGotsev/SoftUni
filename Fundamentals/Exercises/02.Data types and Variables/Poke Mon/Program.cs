using System;


namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int counter = 0;
            int h = n / 2;

            while (n >= m)
            {
                n -= m;
                counter++;
                if (n == h && y != 0)
                {
                    n /= y;
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(counter);
        }
    }
}
