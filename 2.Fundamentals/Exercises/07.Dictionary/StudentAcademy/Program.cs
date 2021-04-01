using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();


            for (int i = 0; i < rows * 2; i += 2)
            {
                string comand = Console.ReadLine();                
                double great = double.Parse(Console.ReadLine());


                if (!students.ContainsKey(comand))
                {
                    students.Add(comand, new List<double>());
                }

                students[comand].Add(great);
            }

            foreach (var item in students.OrderByDescending(x => x.Value.Average()))
            {
                if (item.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.Average():f2}");
                }
            }
        }
    }
}
