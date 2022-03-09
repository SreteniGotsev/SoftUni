using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();

            List<Person> register = new List<Person>();

            while (comand != "End")
            {
                string[] input = comand.Split(" ");
                string name = input[0];
                int id = int.Parse(input[1]);
                int age = int.Parse(input[2]);

                Person individ = new Person(name, id, age);

                register.Add(individ);

                comand = Console.ReadLine();
            }

            foreach (Person person in register.OrderBy(x=>x.Age))
            {
                Console.WriteLine(person);
            }
        }
    }

    class Person
    {
        public Person(string name, int id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }

        public string Name { get; set; }
        public int ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
