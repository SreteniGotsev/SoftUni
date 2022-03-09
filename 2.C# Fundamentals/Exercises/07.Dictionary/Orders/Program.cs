using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, double> itemPrice = new Dictionary<string, double>();
            Dictionary<string, int> itemQuantity = new Dictionary<string, int>();
            Dictionary<string, double> itemTotalPrice = new Dictionary<string, double>();

            

            while (input[0].ToLower() != "buy")
            {
                string item = input[0];
                double currPrice = double.Parse(input[1]);
                int currQuantity = int.Parse(input[2]);

                if (!itemPrice.ContainsKey(item))
                {
                    itemPrice.Add(item, currPrice);
                    itemQuantity.Add(item, currQuantity);
                    itemTotalPrice.Add(item, 0);
                }
                else
                {
                    itemQuantity[item] += currQuantity;

                    if (currPrice != itemPrice[item])
                    {
                        itemPrice[item] = currPrice;
                    }
                }


                input = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in itemTotalPrice)
            {
                Console.WriteLine($"{item.Key} -> {itemPrice[item.Key] * itemQuantity[item.Key]:f2}");
            }


        }
    }
}
