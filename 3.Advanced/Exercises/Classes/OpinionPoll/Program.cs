using System;
using System.Collections.Generic;
using System.Linq;
using DefiningClasses;


namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person personOne = new Person(name, age);
                family.AddMemeber(personOne);
            }

            List<Person> oldMembers = family.GetOlderThanThirty();

            foreach (var person in oldMembers.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

        }
    }
}
