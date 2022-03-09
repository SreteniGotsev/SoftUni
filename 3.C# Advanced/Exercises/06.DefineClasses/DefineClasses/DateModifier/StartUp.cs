using System;
using System.Linq;

namespace DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {
     

            int[] data = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] data2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            DateTime dateOne = new DateTime(data[0], data[1], data[2]);
            DateTime datTwo = new DateTime(data2[0], data2[1], data2[2]);

            Console.WriteLine(Math.Abs((dateOne - datTwo).TotalDays));
           
        }

    }
}
