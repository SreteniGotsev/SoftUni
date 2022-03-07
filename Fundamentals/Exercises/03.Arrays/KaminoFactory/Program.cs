using System;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLenght = int.Parse(Console.ReadLine());

            int[] dna = new int[dnaLenght];
            int[] dnaPrint = new int[dnaLenght];

            string comand = Console.ReadLine();

            int bestCount = 0;
            int bestSequence = 0;
            int firstPosition = dnaLenght;
            int sampleCount = 0;
            int bestSampleHolder = 0;

            bool isFirst = true;
            bool inSequence = false;

            while (comand.ToLower() != "clone them!")
            {
                dna = comand.Split('!', StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();

                sampleCount++;

                int counter = 0;
                int currSequence = 0;
                int currBestSequence = 0;
                int currFirst = 0;

                for (int i = 0; i < dna.Length; i++)
                {                    
                    if (dna[i] == 1)
                    {
                        counter++;

                        if (inSequence)
                        {
                            currSequence++;
                            if (isFirst)
                            {
                                firstPosition = i - 1;
                                isFirst = false;
                            }
                        }
                        else
                        {
                            currSequence = 1;
                            inSequence = true;
                        }

                    }
                    else
                    {
                        if (currSequence > currBestSequence)
                        {
                            currBestSequence = currSequence;
                        }
                        inSequence = false;
                    }
                }

                if (currBestSequence > bestSequence)
                {
                    dnaPrint = dna;
                    bestCount = counter;
                    firstPosition = currFirst;
                    bestSampleHolder = sampleCount;
                    bestSequence = currBestSequence;
                }
                else if (currBestSequence == bestSequence)
                {

                    if (firstPosition > currFirst)
                    {
                        dnaPrint = dna;
                        bestCount = counter;
                        firstPosition = currFirst;
                        bestSampleHolder = sampleCount;
                        bestSequence = currBestSequence;
                    }
                    else if (firstPosition == currFirst && counter > bestCount)
                    {
                        dnaPrint = dna;
                        bestCount = counter;
                        firstPosition = currFirst;
                        bestSampleHolder = sampleCount;
                        bestSequence = currBestSequence;
                    }
                }

                comand = Console.ReadLine();
                isFirst = true;
            }

            Console.WriteLine($"Best DNA sample {bestSampleHolder} with sum: {bestCount}.");
            Console.WriteLine(String.Join(' ', dnaPrint));
        }
    }
}
