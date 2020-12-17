using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string model = String.Empty;
            double radius = 0.0;
            int hight = 0;
            double volume = 0.0;
            double bigger = 0.0;
            string winner = String.Empty;

            for (int i = 0; i < number; i++)
            {
                model = Console.ReadLine();
                radius = double.Parse(Console.ReadLine());
                hight = int.Parse(Console.ReadLine());

                volume = Math.PI * radius * radius * hight;

                if (volume > bigger )
                {
                    winner = model;
                    bigger = volume;
                }

            }

            Console.WriteLine(winner);
        }
    }
}
