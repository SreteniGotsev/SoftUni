using System;

namespace TriplesOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                char firstCart = (char)('a' + i);
                for (int j = 0; j < number; j++)
                {
                    char secondCart = (char)('a' + j);
                    for (int k = 0; k < number; k++)
                    {
                        char thirdCart = (char)('a' + k);
                        Console.WriteLine($"{firstCart}{secondCart}{thirdCart}");
                    }
                }
            }
        }
    }
}
