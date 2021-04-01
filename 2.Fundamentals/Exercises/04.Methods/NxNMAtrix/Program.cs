using System;
using System.Numerics;

namespace NxNMAtrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {

            Console.WriteLine(Matrix(num));
            }
        }

        static string Matrix(int num)
        {
            int[] arr = new int [num];

            for (int i = 0; i < num; i++)
            {
               
               arr[i] = num;
                
            }
            string output = String.Join(" ", arr);

            return output;
        }
    }
}
