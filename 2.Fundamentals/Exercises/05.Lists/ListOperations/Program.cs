using System;
using System.Collections.Generic;
using System.Linq;


namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nums = Console.ReadLine()
                                       .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                       .ToList();

            List<string> input = Console.ReadLine()
                                        .ToLower()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToList(); ;

            while (input[0] != "end")
            {
                switch (input[0])
                {
                    case "add":

                        nums.Add(input[1]);

                        break;

                    case "insert":

                        if (int.Parse(input[2]) >= 0 && int.Parse(input[2]) <= nums.Count)
                        {
                            nums.Insert(int.Parse(input[2]), input[1]);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }

                        break;

                    case "remove":

                        if (int.Parse(input[1]) <= nums.Count - 1 && int.Parse(input[1]) >= 0)
                        {
                            nums.RemoveAt(int.Parse(input[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }

                        break;

                    case "shift":
                        //Hasn't been finished!!!
                        int rotations = int.Parse(input[2]);


                        if (input[1] == "left")
                        {

                            for (int i = 0; i < rotations; i++)
                            {
                                string firstElement = nums[0];

                                for (int j = 0; j < nums.Count - 1; j++)
                                {
                                    nums[j] = nums[j + 1];
                                }

                                nums[nums.Count - 1] = firstElement;
                            }


                        }
                        else
                        {

                            for (int i = 0; i < rotations; i++)
                            {
                                string lastElement = nums[nums.Count - 1];

                                for (int j = nums.Count - 1; j > 0; j--)
                                {
                                    nums[j] = nums[j - 1];
                                }

                                nums[0] = lastElement;
                            }
                        }


                        break;

                    default:
                        break;

                }

                input = Console.ReadLine()
                               .ToLower()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .ToList();
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}