using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] materials = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                        .ToArray();

            Dictionary<string, int> items = new Dictionary<string, int>();
            Dictionary<string, int> legendary = new Dictionary<string, int>();

            bool toBreak = false;

            legendary["shards"] = 0;
            legendary["motes"] = 0;
            legendary["fragments"] = 0;



            while (true)
            {

                string material = string.Empty;
                int value = 0;

                for (int i = 0; i < materials.Length; i += 2)
                {
                    value = int.Parse(materials[i]);
                    material = materials[i + 1].ToLower();

                    if (material == "shards" || material == "motes" || material == "fragments")
                    {
                        legendary[material] += value;

                        if (legendary[material] >= 250)
                        {
                            if (legendary["shards"] >= 250)
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                                
                            }
                            else if (legendary["motes"] >= 250)
                            {                               
                                Console.WriteLine("Dragonwrath obtained!");
                               
                            }
                            else if (legendary["fragments"] >= 250)
                            {                               
                                Console.WriteLine("Valanyr obtained!");
                                
                            }
                            legendary[material] -= 250;

                            toBreak = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!items.ContainsKey(material))
                        {
                            items.Add(material, value);
                        }
                        else
                        {
                            items[material] += value;
                        }
                    }

                }

                if (toBreak)
                {
                    break;
                }

                materials = Console.ReadLine()
                                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                   .ToArray();
            }

            foreach (var item in legendary.OrderByDescending(k => k.Value).ThenBy(k => k.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in items.OrderBy(k => k.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
