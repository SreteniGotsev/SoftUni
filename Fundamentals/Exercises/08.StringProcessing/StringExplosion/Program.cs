using System;
using System.Text;

namespace StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringBomb = Console.ReadLine();

            int bomb = 0;

            for (int i = 0; i < stringBomb.Length; i++)
            {
               
                char exp = stringBomb[i];
               

                if (exp == '>')
                {
                    bomb += int.Parse(stringBomb[i + 1].ToString());
                    continue;                   
                }

                if (bomb > 0)
                {
                    stringBomb = stringBomb.Remove(i, 1);
                    i--;
                    bomb--;
                }
            }

                Console.Write(stringBomb);

            
        }
    }
}
