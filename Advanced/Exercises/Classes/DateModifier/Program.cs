using System;
using DateModifier;
namespace DateModifier
{
   public class Program
    {
        public static void Main(string[] args)
        {
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            int days = DateModifier.DateDiff(date1, date2);

            Console.WriteLine(Math.Abs(days));
        }
    }
}
