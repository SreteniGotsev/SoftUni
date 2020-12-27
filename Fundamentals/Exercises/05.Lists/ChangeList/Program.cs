using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> elements = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .Select(int.Parse)
                                        .ToList();
            List<string> input = Console.ReadLine()
                               .ToLower()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .ToList();
            while (input[0] != "end")
            {
                switch (input[0])
                {
                    case "insert":
                        elements.Insert(int.Parse(input[2]), int.Parse(input[1]));
                        break;

                    case "delete":
                        elements.Remove(int.Parse(input[1]));
                        for (int i = 0; i < elements.Count; i++)
                        {

                            if (elements.Contains(int.Parse(input[1])))
                            {
                                elements.Remove(int.Parse(input[1]));
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
            Console.WriteLine(string.Join(" ", elements));
        }
    }
}
