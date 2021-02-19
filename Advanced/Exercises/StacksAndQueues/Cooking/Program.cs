using System;
using System.Collections.Generic;
using System.Linq;

namespace Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liquids = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> ingredients = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            int sum = 0;

            int bread = 0;
            int cake = 0;
            int pastry = 0;
            int fruitPie = 0;

            while (liquids.Count > 0 && ingredients.Count > 0)
            {
                int liquid = liquids.Dequeue();
                int ingredient = ingredients.Pop();
                sum = liquid + ingredient;

                switch (sum)
                {
                    case 25:
                        bread++;
                        break;

                    case 50:
                        cake++;
                        break;

                    case 75:
                        pastry++;
                        break;

                    case 100:
                        fruitPie++;
                        break;

                    default:

                        ingredients.Push(ingredient + 3);

                        break;
                }
            }

            if (IsFull(bread,cake,pastry,fruitPie))
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquids.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.WriteLine("Liquids left: " + string.Join(", ",liquids));
            }

            if (ingredients.Count == 0)
            {
                Console.WriteLine("Ingredients left: none");
            }
            else
            {
                Console.WriteLine("Ingredients left: " + string.Join(", ", ingredients));
            }

            Console.WriteLine($"Bread: {bread}");
            Console.WriteLine($"Cake: {cake}");
            Console.WriteLine($"Fruit Pie: {fruitPie}");
            Console.WriteLine($"Pastry: {pastry}");

        }

        static bool IsFull(int bread, int cake, int pastry, int fruitPie )
        {
            bool IsAll = false;
            if (bread >0 && cake >0 && pastry >0 && fruitPie >0)
            {
                IsAll = true;
            }
            return IsAll;
        }
    }
}
