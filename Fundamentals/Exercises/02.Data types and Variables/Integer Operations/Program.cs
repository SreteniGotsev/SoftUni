using System;

namespace Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int subiraemo1 = int.Parse(Console.ReadLine());
            int subiraemo2 = int.Parse(Console.ReadLine());
            int delitel = int.Parse(Console.ReadLine());
            int mnojitel = int.Parse(Console.ReadLine());
            int chastno = 0;

            chastno = (subiraemo1 + subiraemo2) / delitel * mnojitel;
            Console.WriteLine(chastno);
        }
    }
}
