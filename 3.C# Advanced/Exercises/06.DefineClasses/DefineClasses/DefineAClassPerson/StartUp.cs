using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
  public  class StartUp
    {
        static void Main(string[] args)
        {
            int members = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < members; i++)
            {
                string input = Console.ReadLine();
                string[] inputs = input.Split();
                Person person = new Person(inputs[0], int.Parse(inputs[1]));
                family.AddMember(person);
            }

            //family.GetOldestMember();
            family.Above30();
        }
    }
}
