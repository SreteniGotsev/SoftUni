using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string chislo = Console.ReadLine();
            char c;
            int current = 0;
            int total = 0;
            int currentTotal = 1;
            for (int i = chislo.Length; i > 0; i--)
            {
                c = chislo[i - 1];
                current = int.Parse(c.ToString());
                for (int k = current; k > 0; k--)
                {
                    currentTotal = currentTotal * k;
                }
                total += currentTotal;
                currentTotal = 1;
            }
            if (total == int.Parse(chislo))
            {
                Console.WriteLine("yes");
            } 
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
