using System;
using System.Linq;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split(" ").ToArray();
            string[] second = Console.ReadLine().Split(" ").ToArray();
            string holder = String.Empty;
            string holder2 = String.Empty;

            for (int i = 0; i < first.Length; i++)
            {
                holder = first[i];
                for (int j = 0; j < second.Length; j++)
                {

                holder2 = second[j];
                    if (holder2 == holder)
                    {
                        Console.Write(holder + " ");
                    }
                }
            }
            
        }
    }
}
