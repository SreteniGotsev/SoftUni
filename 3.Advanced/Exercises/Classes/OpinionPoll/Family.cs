using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            this.Members = new List<Person>();
        }
        public List<Person> Members { get; set; }

        public void AddMemeber(Person member)
        {
            this.Members.Add(member);
        }

        public Person GetOldestMember()
        {
            Person person = this.Members.OrderByDescending(p => p.Age).First();
            return person;
        }

        public List<Person> GetOlderThanThirty()
        {
            List<Person> old = new List<Person>();

            foreach (var member in this.Members)
            {
                if (member.Age > 30)
                {
                    old.Add(member);
                }
            }           

            return old;
        }
    }
}
