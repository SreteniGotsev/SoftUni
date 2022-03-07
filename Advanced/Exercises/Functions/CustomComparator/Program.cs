using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    even.Add(nums[i]);
                }
                else
                {
                    odd.Add(nums[i]);
                }
            }

            Action<List<int>, List<int>> change = Play;

            change(even, odd);
        }

        private static void Play(List<int> even, List<int> odd)
        {
            for (int i = 0; i < even.Count; i++)
            {
                Console.Write(even[i] + " ");
            }

            for (int j = 0; j < odd.Count; j++)
            {
                Console.Write(odd[j] + " ");
            }
        }
    }
}
