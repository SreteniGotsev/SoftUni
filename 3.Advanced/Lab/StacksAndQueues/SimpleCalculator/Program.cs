using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Stack<string> nums = new Stack<string>();

            foreach (var item in input.Reverse())
            {
                nums.Push(item);
            }

            int firstNum = 0;
            int secondNum = 0;
            string sign = "";


            while (nums.Count > 1)
            {
                firstNum = int.Parse(nums.Pop());
                sign = nums.Pop();
                secondNum = int.Parse(nums.Pop());

                if (sign == "+")
                {
                    nums.Push((firstNum + secondNum).ToString());
                }
                else if (true)
                {
                    nums.Push((firstNum - secondNum).ToString());
                }

            }

            Console.WriteLine(nums.Pop());
        }
    }
}
