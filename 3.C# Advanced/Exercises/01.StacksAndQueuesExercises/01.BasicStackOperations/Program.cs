using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split()
                                    .Select(int.Parse).ToArray();
            int pushing = commands[0];
            int poping = commands[1];
            int peeking = commands[2];

            Stack<int> numbers = new Stack<int>();

            int[] items = Console.ReadLine().Split()
                                   .Select(int.Parse).ToArray();

            foreach (var item in items)
            {
                numbers.Push(item);
            }
            

            for (int i = 0; i < poping; i++)
            {
                numbers.Pop();
            }

            bool isThere = false;
            int smallestNum = int.MaxValue;

            if (numbers.Count > 0)
            {
                while (!isThere && numbers.Count != 0 )
                {
                    int num = numbers.Peek();

                    if (num == peeking)
                    {
                        isThere = true;
                        continue;
                    }
                    else if (num < smallestNum)
                    {
                        smallestNum = num;
                    }
                        numbers.Pop();
                }
                
            }
            else
            {
                Console.WriteLine(0);
                return;
            }

            if (isThere)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(smallestNum);
            }



        }
    }
}
