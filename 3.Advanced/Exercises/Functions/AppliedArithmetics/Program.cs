using System;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToArray();

            Action<int[], string> calculate = Calculator;

            string command = Console.ReadLine();

            while (command != "end")
            {
                calculate(nums, command);

                command = Console.ReadLine();
            }
        }

        private static void Calculator(int[] nums, string command)
        {
            switch (command)
            {
                case "add":

                    for (int i = 0; i < nums.Length; i++)
                    {
                        nums[i] += 1;
                    }

                    break;

                case "multiply":

                    for(int i = 0; i < nums.Length; i++)
                    {
                        nums[i] *= 2;
                    }

                    break;

                case "subtract":

                    for (int i = 0; i < nums.Length; i++)
                    {
                        nums[i] -= 1;
                    }

                    break;

                case "print":

                    Console.WriteLine(string.Join(" ", nums));
                            
                    break;
                
                default:
                    
                    break;
            }
        }
    }
}
