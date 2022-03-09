using System;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            Action<string> newLine = x => Console.WriteLine("Sir " + x);

            foreach (var item in names)
            {
                newLine(item);
            }
        }
    }
}
