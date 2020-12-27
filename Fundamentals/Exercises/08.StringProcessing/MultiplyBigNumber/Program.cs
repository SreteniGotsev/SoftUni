using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sum = new StringBuilder();
            string num = Console.ReadLine().TrimStart('0');
            int num2 = int.Parse(Console.ReadLine());
            int ost = 0;
            bool addOne = false;

            if (num2 == 0 || num == null )
            {
                Console.WriteLine(0);
                return;
            }

            foreach (var item in num.Reverse())
            {
                int num1 = int.Parse(item.ToString());

                int holder = num1 * num2;


                if (addOne)
                {
                    holder += ost;
                }


                if (holder <= 9)
                {

                    sum.Insert(0, holder);
                    addOne = false;
                    ost = 0;
                }
                else
                {
                    ost = holder / 10;
                    sum.Insert(0, holder % 10);
                    addOne = true;
                }

            }

            if (ost != 0)
            {
                sum.Insert(0, ost);
            }


            Console.WriteLine(sum);
        }
    }
}
