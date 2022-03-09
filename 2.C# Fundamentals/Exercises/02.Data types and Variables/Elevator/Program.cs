using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double cources = 0;
            int remainder = 0;
            remainder = people % capacity;
            cources = people / capacity + Math.Ceiling((double)remainder / capacity);
            Console.WriteLine(cources);

        }
    }
}
