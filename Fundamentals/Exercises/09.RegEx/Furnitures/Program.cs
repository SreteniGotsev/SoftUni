using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furnitures
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>([A-Za-z]+)<<(\d+\.?\d+)!(\d+)";
            Regex reg = new Regex(pattern);

            string input = Console.ReadLine();

            double sum = 0;

            Console.WriteLine("Bought furniture:");

            while (input != "Purchase")
            {
                Match hit = reg.Match(input);

                if (hit.Success)
                {
                    string item = hit.Groups[1].Value;
                    double price = double.Parse(hit.Groups[2].Value);
                    int quantity = int.Parse(hit.Groups[3].Value);

                    Console.WriteLine(item);

                    sum += price * quantity;

                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total money spend: {sum}");
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Text.RegularExpressions;

//namespace Furnitures
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string input = Console.ReadLine();
//            List<string> items = new List<string>();
//            double sum = 0.0;
//            string pattern = @">>([A-Za-z]+)<<(\d+\.?\d+)!(\d+)";

//            Regex reg = new Regex(pattern);

//            while (input != "Purchase")
//            {
//                Match hit = reg.Match(input);

//                if (hit.Success)
//                {
//                    items.Add(hit.Groups[1].Value);

//                    sum += double.Parse(hit.Groups[2].Value) * int.Parse(hit.Groups[3].Value);

//                }

//                input = Console.ReadLine();
//            }

//            Console.WriteLine("Bought furniture:");
//            Console.WriteLine(string.Join(Environment.NewLine, items));
//            Console.WriteLine($"Total money spend: {sum}");
//        }
//    }
//}

