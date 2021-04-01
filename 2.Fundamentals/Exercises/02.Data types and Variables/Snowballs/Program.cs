using System;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballs = int.Parse(Console.ReadLine());
            double bigger = 0;
            int holderSnow = 0;
            int holderTime = 0;
            int holderQuality = 0;
            for (int i = 0; i < snowballs; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());
                double snowballValue = Math.Pow((snow / time), quality);

                if (snowballValue >= bigger)
                {
                    bigger = snowballValue;
                    holderSnow = snow;
                    holderQuality = quality;
                    holderTime = time;
                }
            }
            Console.WriteLine($"{holderSnow} : {holderTime} = {bigger} ({holderQuality})");
        }
    }
}
