using System;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] list = Console.ReadLine().Split(" ");
            int n = int.Parse(Console.ReadLine());
            string holder = String.Empty;
            for (int i = 0; i < n; i++)
            {
                holder = list[0];
                for (int j = 0; j < list.Length - 1; j++)
                {
                    list[j] = list[j + 1];
                }
            list[list.Length - 1] = holder;
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
