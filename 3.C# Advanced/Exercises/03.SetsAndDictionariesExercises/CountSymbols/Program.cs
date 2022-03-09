using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<char, int> dict = new Dictionary<char, int>();

            char[] text = Console.ReadLine().ToCharArray();

            for (int i = 0; i < text.Length; i++)
            {
                
                if (!dict.ContainsKey(text[i]))
                {
                    dict.Add(text[i], 0);
                }

                dict[text[i]]++;
            }

            foreach (var item in dict.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
