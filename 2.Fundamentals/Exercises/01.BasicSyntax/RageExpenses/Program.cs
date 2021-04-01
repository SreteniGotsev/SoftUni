using System;

namespace RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int games = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            double cost = 0.0;

            cost = headsetPrice * (games / 2) + mousePrice * (games / 3) + keyboardPrice * (games / 6) + displayPrice * (games / 12);
            Console.WriteLine($"Rage expenses {cost:f2}lv.");


        }
    }
}
