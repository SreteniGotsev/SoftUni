using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {

            int waves = int.Parse(Console.ReadLine());

            Queue<int> plates = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));


            Stack<int> orcs = new Stack<int>();

            int wavesCounter = 0;


            for (int i = 0; i < waves; i++)
            {
                orcs = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

                wavesCounter++;


                if (wavesCounter % 3 == 0)
                {
                    plates.Enqueue(int.Parse(Console.ReadLine()));
                }

                int defence = plates.Dequeue();
                int count = orcs.Count;

                for (int k = 0; k < count; k++)
                {

                    int ork = orcs.Pop();

                    if (defence == 0)
                    {
                        defence = plates.Dequeue();
                    }

                    if (defence > ork)
                    {
                        defence -= ork;

                    }
                    else if (defence == ork)
                    {
                        defence -= ork;
                    }
                    else if (ork > defence)
                    {
                        orcs.Push(ork - defence);
                        defence = 0;
                    }

                    if (plates.Count == 0 && defence == 0)
                    {
                        break;
                    }

                }

                if (defence > 0)
                {
                    plates.Enqueue(defence);

                    for (int j = 0; j < plates.Count - 1; j++)
                    {
                        plates.Enqueue(plates.Dequeue());
                    }
                }

                if (plates.Count == 0 && defence == 0)
                {
                    break;
                }

            }

            if (orcs.Count != 0)
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {string.Join(", ", orcs)}");
            }
            else
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }


        }
    }
}
