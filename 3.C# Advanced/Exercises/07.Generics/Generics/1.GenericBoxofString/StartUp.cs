using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.GenericBoxofString
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());

            List<Box<double>> boxes = new List<Box<double>>();

            for (int i = 0; i < times; i++)
            {
                //int value = 0;

                // char[] input = Console.ReadLine().ToCharArray();

                //for (int j = 0; j < input.Length; j++)
                //{
                //    value += input[j]; 
                //}
                double value = double.Parse(Console.ReadLine());
                Box<double> box = new Box<double>(value);
                boxes.Add(box);
            }

            //int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //var holder = boxes[indexes[0]];
            //boxes[indexes[0]] = boxes[indexes[1]];
            //boxes[indexes[1]] = holder;

            //int num = 0;

            //char[] some = Console.ReadLine().ToCharArray();

            //for (int j = 0; j < some.Length; j++)
            //{
            //    num += some[j];
            //}

            double num = double.Parse(Console.ReadLine());

            boxes = boxes.Where(x => x.Name > num).ToList();
            Console.WriteLine(boxes.Count);

            //foreach (var box in boxes.Where(x=>x.Name > num))
            //{
            //    Console.WriteLine(box);
            //}

            s
        }
    }
}
