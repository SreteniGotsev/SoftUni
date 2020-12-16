using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double money = 0.0;
            double sum = 0.0;

            while (input != "Start")
            {
                money = double.Parse(input);

                if (money == 0.1 || money == 0.2 || money == 0.5 || money == 1 || money == 2)
                {
                    sum += money;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                }

                input = Console.ReadLine();
            }

            string item = Console.ReadLine();
            double itemPrice = 0.0;
            bool isValid;

            while (item != "End")
            {
                isValid = true;
                switch (item)
                {
                    case "Nuts":
                        itemPrice = 2.0;
                        break;
                    case "Water":
                        itemPrice = 0.7;
                        break;
                    case "Crisps":
                        itemPrice = 1.5;
                        break;
                    case "Soda":
                        itemPrice = 0.8;
                        break;
                    case "Coke":
                        itemPrice = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        isValid = false;
                        break;
                }
                if (isValid)
                {

                    if (itemPrice <= sum)
                    {
                        Console.WriteLine($"Purchased {item.ToLower()}");
                        sum -= itemPrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }

                item = Console.ReadLine();

            }

            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
