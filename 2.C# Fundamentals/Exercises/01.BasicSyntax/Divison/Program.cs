using System;

namespace Divison
{
    class Program
    {
        static void Main(string[] args)
        {
            int delimo = int.Parse(Console.ReadLine());

            if (delimo % 10 == 0)
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else if (delimo % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if (delimo % 6 == 0)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (delimo % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if (delimo % 2 == 0)
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else  
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
