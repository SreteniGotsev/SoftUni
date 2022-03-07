using System;
using System.Xml.Schema;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int pouring = 0;
            int total = 0;
            for (int i = 0; i < number; i++)
            {
                pouring = int.Parse(Console.ReadLine());

                if (pouring <= 255 - total)
                {
                    total += pouring;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(total);
        }
    }
}
