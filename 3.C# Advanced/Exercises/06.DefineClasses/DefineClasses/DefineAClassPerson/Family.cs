using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
     public  class Family
    {
        private List<Person> members = new List<Person>();

        public void AddMember(Person person)
        {
            members.Add(person);
        }

        public void GetOldestMember()
        {
            Console.WriteLine(members.OrderByDescending(x=> x.Age).FirstOrDefault());
        }

        public void Above30()
        {
            members = members.Where(x => x.Age > 30).OrderBy(x => x.Name).ToList();
            foreach (var member in members)
            {
                Console.WriteLine($"{member.Name} - {member.Age }");
            }

           // Console.WriteLine(String.Join(Environment.NewLine, this.members.Where(x => x.Age > 30).OrderByDescending(x=>x.Age)));
        }
    }
}
