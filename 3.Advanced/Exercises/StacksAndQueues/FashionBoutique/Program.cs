using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] box = Console.ReadLine().Split()
                                   .Select(int.Parse).ToArray();

            int capacity = int.Parse(Console.ReadLine());

            Stack<int> clothes = new Stack<int>();

            int racks = 0;

            foreach (var item in box)
            {
                clothes.Push(item);
            }

            int holder = capacity;

            bool isFull = clothes.Count > 0;

            while (clothes.Count>0)
            {
                if (holder > clothes.Peek())
                {
                    holder -= clothes.Pop(); 
                }
                else if (holder == clothes.Peek())
                {
                    holder -= clothes.Pop();
                    racks++;
                    holder = capacity;
                }
                else
                {
                    racks++;
                    holder = capacity;
                }
            }

            if (isFull)
            {
                racks++;
            }

            Console.WriteLine(racks);

        }
    }
}
