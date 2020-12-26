using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> competitors = Console.ReadLine().Split(", ").ToList();

            Dictionary<string, int> results = new Dictionary<string, int>();

            foreach (var name in competitors)
            {
                results.Add(name, 0);
            }

            string patternName = @"[\W\d]";
            string patternDistance = @"[\WA-Za-z]";

            string comand = Console.ReadLine();

            while (comand != "end of race")
            {
                string name = Regex.Replace(comand, patternName, "");
                string distance = Regex.Replace(comand, patternDistance, "");

                int sum = 0;

                foreach (var digit in distance)
                {
                    int curr = int.Parse(digit.ToString());
                    sum += curr;
                }

                if (results.ContainsKey(name))
                {
                    results[name] += sum;
                }

                comand = Console.ReadLine();
            }

            int count = 1;

            foreach (var item in results.OrderByDescending(v=>v.Value))
            {
                string text = count == 1 ? "st" : count == 2 ? "nd" : "rd";

                Console.WriteLine($"{count++}{text} place: {item.Key}");

                if (count == 4)
                {
                    break;
                }
            }
        }
    }
}
