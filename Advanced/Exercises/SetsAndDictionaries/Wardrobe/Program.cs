using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            int length = int.Parse(Console.ReadLine());

            string colour = string.Empty;
            string item = string.Empty;

            for (int i = 0; i < length; i++)
            {
                string[] input = Console.ReadLine().Split(new string[] { "->", "," , " " }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 1; j < input.Length; j++)
                {

                    colour = input[0];
                    item = input[j];

                    if (!wardrobe.ContainsKey(colour))
                    {
                        wardrobe.Add(colour, new Dictionary<string, int>());
                    }

                    if (!wardrobe[colour].ContainsKey(item))
                    {
                        wardrobe[colour].Add(item, 0);
                    }

                    wardrobe[colour][item]++;
                }
            }

            string[] clothes = Console.ReadLine().Split();

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var cloth in color.Value)
                {


                    if (color.Key == clothes[0] && cloth.Key == clothes[1])
                    {
                        Console.WriteLine($"* {cloth.Key} - {cloth.Value} (found!)");
                    }

                    Console.WriteLine($"* {cloth.Key} - {cloth.Value}");

                }
            }


        }
    }
}
