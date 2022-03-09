using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace EvenLines
{
    class EvenLines
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader("../../../Reader.txt");
            using (reader)
            {
                List<string> lines = reader.ReadToEnd().Split('-').ToList();

                for (int i = 0; i < lines.Count; i++)
                {
                    Regex pattern = new Regex("[.,?!]");
                    if (i % 2 == 1)
                    {

                        var line = lines[i];

                        line = pattern.Replace(line, "@");

                        char[] charArray = line.ToCharArray();
                        Array.Reverse(charArray);

                        Console.WriteLine(charArray);
                    }
                }
            }



            //Example:
            //var reader = new StreamReader("../../../input.txt");
            //using (reader)
            //{
            //    int counter = 0;
            //    string line = reader.ReadLine();
            //    using (var writer = new StreamWriter("../../../Output.txt"))
            //    {
            //        while (line != null)
            //        {
            //            if (counter%2 == 0)
            //            {
            //                writer.WriteLine(line);
            //            }
            //            counter++;

            //            line = reader.ReadLine();
            //        }
            //    }
            //}
        }
    }
}
