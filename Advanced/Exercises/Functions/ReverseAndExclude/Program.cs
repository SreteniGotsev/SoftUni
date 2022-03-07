using System;
using System.Linq;
using System.Collections.Generic;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> nums = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();
            int num = int.Parse(Console.ReadLine());

            Action<List<int>, int> play = RecerseAndExckude;

            play(nums, num);
            
        }

        private static void RecerseAndExckude(List<int> nums, int num)
        {
          nums.Reverse();


            for (int i = 0; i < nums.Count; i++)
            {            
                if (nums[i] % num == 0  )
                {
                    nums.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
