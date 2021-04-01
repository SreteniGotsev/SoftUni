using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> address = Console.ReadLine().Split("\\").ToList();
            string[] output = address[address.Count - 1].Split(".");
            Console.WriteLine($"File name: {output[0]}");
            Console.WriteLine($"File extension: {output[1]}");
        }
    }
}
