//using System;

//namespace AddAndSubtract
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int num1 = int.Parse(Console.ReadLine());
//            int num2 = int.Parse(Console.ReadLine());
//            int num3 = int.Parse(Console.ReadLine());

//            Console.WriteLine(Substraction(Sum(num1, num2), num3));
//        }

//        static int Sum(int number, int number2)
//        {
//            int sum = number + number2;
//            return sum;
//        }

//        static int Substraction(int num, int num2)
//        {
//            int substract = num - num2;
//            return substract;
//        }
//    }
//}

using System;
namespace TopNUmber
{
    class Programe
    {
        static void Main(string[] args)
        {
            int top = int.Parse(Console.ReadLine());
            TopNumber(top);
        }

        static void TopNumber(int top)
        {
            for (int i = 1; i <= top; i++)
            {
                string num = i.ToString();
                char[] item = num.ToCharArray();
                int curr = 0;
                bool contains = false;

                for (int j = 0; j < item.Length; j++)
                {
                    curr += int.Parse(item[j].ToString());
                    if(int.Parse(item[j].ToString()) % 2 == 1)
                    {
                        contains = true;
                    }
                }

                if (curr % 8 == 0 && contains)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

