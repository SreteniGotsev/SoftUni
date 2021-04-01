using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

            
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();


            while (input[0].ToLower() != "end" )
            {
                string course = input[0];
                string student = input[1];

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string>());
                    courses[course].Add(student);
                }
                else
                {
                    courses[course].Add(student);
                }

                input = Console.ReadLine()
                               .Split(" : ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: { item.Value.Count}");

                foreach (var curritem in item.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {curritem}");
                }
                
            }
        }
    }
}
