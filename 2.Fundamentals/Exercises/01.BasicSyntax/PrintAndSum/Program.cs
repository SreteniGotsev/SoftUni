using System;

namespace PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int currentNum = 0;
            int totalNum = 0;
            for (int i = start; i <= stop; i++)
            {
                currentNum = i;
                Console.Write(currentNum + " ");
                totalNum += currentNum;
            }
            Console.WriteLine($"Sum: {totalNum}");
        }
    }
}
