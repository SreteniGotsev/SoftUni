//using System;

//namespace Triangle
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//           int a = int.Parse(Console.ReadLine());
//            for (int i = 1; i <= a; i++)
//            {
//                for (int j = 1; j <= i; j++)
//                {
//                    Console.Write(i + " ");
//                }
//                Console.WriteLine();


//            }
//        }
//    }
//}
using System;
namespace Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            if (age > 0 && age <= 2)
            {
                Console.WriteLine("baby");
            }
            else if (age >= 3 && age <= 13)
            {
                Console.WriteLine("child");
            }
            else if (age >= 14 && age <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (age >= 20 && age <= 65)
            {
                Console.WriteLine("adult");
            }
            else
            {
                Console.WriteLine("elder");
            }
        }
    }
}
