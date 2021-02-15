using System;
using DefiningClasses;


namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person personOne = new Person();
            personOne.Name = "Gosho";
            personOne.Age = 22;

            Person personTwo = new Person()
            {
                Name = "Misho",
                Age = 34
            };

            Console.WriteLine(personOne.Name);
            Console.WriteLine(personTwo.Age);

        }
    }
}
