using System;
using System.Collections.Generic;
using System.Linq;

namespace BomBnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList();
            List<int> bomb = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .Select(int.Parse)
                                    .ToList();

            int detonation = bomb[0];
            int power = bomb[1];
            int startIndex = 0;
            int finalIndex = 0;
            int detonationRange = 0;

            for (int i = 0; i < nums.Count; i++)
            {
               
                if (nums[i] == bomb[0])
                {
                    
                    startIndex = i - power;

                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }

                    finalIndex = i + power;

                    if (finalIndex > nums.Count - 1)
                    {
                        finalIndex = nums.Count - 1;
                    }

                    detonationRange = finalIndex - startIndex + 1;

                    nums.RemoveRange(startIndex, detonationRange);

                    i = 0;

                }
            }

            int sum = 0;

            for (int i = 0; i < nums.Count; i++)
            {
                sum += nums[i];
            }

            Console.WriteLine(sum);

        }
    }
}
