using System;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split();

            Action<string[], int> namePrinter = Couter;

            namePrinter(names, length);
        }

        private static void Couter(string[] names, int length)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Length <= length)
                {
                    Console.WriteLine(names[i]);
                }
            }
        }
    }
}
