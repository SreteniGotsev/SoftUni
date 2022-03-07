using System;
using System.Text.RegularExpressions;


namespace SoftUniBarIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%([A-Z][a-z]+)%[^|$%.]*<(\w*)>[^|$%.]*\|(\d+)\|[^|$%.]*?(\d+\.?\d?)\$";

            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            double totalPrice = 0.0;

            while (input != "end of shift")
            {
                Match order = regex.Match(input);

                if (order.Success)
                {
                    string costumer = order.Groups[1].Value;
                    string product = order.Groups[2].Value;
                    int quantity = int.Parse(order.Groups[3].Value);
                    double price = double.Parse(order.Groups[4].Value);

                    double sum = price * quantity;
                    totalPrice += sum;

                    Console.WriteLine($"{costumer}: {product} - {sum:f2}");

                }


                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalPrice:f2}");
        }
    }
}
