using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharsinAStrimg
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> text = new Dictionary<char, int>();

            List<string> input = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToList();
           
            for (int i = 0; i < input.Count; i++)
            {            
                string a = input[i];

                foreach (var charecte in a)
                {
                    if (!text.ContainsKey(charecte))
                    {
                        text.Add(charecte, 1);
                    }
                    else
                    {
                        text[charecte]++;
                    }

                }
            }

            foreach (var item in text)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");

            }
        }
    }
}
