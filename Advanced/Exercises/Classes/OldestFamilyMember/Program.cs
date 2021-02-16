using System;
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

            Person oldestMember = family.GetOldestMember();

            Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");

        }
    }
}
