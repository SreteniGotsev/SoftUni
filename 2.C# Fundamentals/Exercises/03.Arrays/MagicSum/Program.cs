using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                               .Split()
                               .Select(int.Parse)
                               .ToArray();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                int curr = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    int next = arr[j];
                    if (curr + next == num)
                    {
                        Console.WriteLine($"{curr} {next}");
                    }
                }
            }
        }
    }
}
