using System;
using System.Collections.Generic;
using System.Linq;

namespace MinimumAndMaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Stack<int> numbers = new Stack<int>();


            int biggestNum = int.MinValue;
            int smallestNum = int.MaxValue;

            for (int i = 0; i < num; i++)
            {
                int[] commands = Console.ReadLine().Split()
                                    .Select(int.Parse).ToArray();
                switch (commands[0])
                {
                    case 1:

                        numbers.Push(commands[1]);

                        break;

                    case 2:

                        if (numbers.Count > 0)
                        {
                            numbers.Pop();
                        }

                        break;

                    case 3:
                        if (numbers.Count > 0)
                        {

                            int[] arr = numbers.ToArray();

                            foreach (var item in arr)
                            {

                                if (item > biggestNum)
                                {
                                    biggestNum = item;
                                }
                            }

                            Console.WriteLine(biggestNum);
                        }

                        break;

                    case 4:
                        if (numbers.Count > 0)
                        {

                            int[] arr2 = numbers.ToArray();

                            foreach (var item in arr2)
                            {

                                if (item < smallestNum)
                                {
                                    smallestNum = item;
                                }
                            }

                            Console.WriteLine(smallestNum);

                        }

                        break;

                    default:
                        break;
                }


            }


            Console.Write(String.Join(", ", numbers));

        }
    }
}
