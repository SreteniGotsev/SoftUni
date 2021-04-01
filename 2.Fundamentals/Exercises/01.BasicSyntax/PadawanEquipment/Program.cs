using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double saberPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            double cost = 0.0;
            double extrSabers = Math.Ceiling(students * 0.1);

            cost = students * saberPrice + extrSabers * saberPrice + students * robesPrice + students * beltPrice - ((students / 6) * beltPrice);

            if (money >= cost)
            {
                Console.WriteLine($"The money is enough - it would cost {cost:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {cost - money:f2}lv more.");
            }
            
        }
    }
}
