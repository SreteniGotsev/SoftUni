using System;
using System.Collections.Generic;

namespace AMinarTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> miner = new Dictionary<string, int>();

            int counter = 1;
            string comand = Console.ReadLine();
            string keeper = string.Empty;

            while (comand.ToLower() != "stop" )
            {
                if (counter % 2 == 1)
                {
                    if (!miner.ContainsKey(comand))
                    {
                        miner.Add(comand, 0);
                        keeper = comand;
                    }
                    else
                    {
                        keeper = comand;
                    }
                   
                }            
                else
                {
                    int value = int.Parse(comand);
                    miner[keeper] += value;
                }

                counter++;

                comand = Console.ReadLine();
            }

            foreach (var item in miner)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
