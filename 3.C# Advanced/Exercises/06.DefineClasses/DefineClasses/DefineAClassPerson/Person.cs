using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        public Person()
        {
            Name = "No name";
            Age = 1;
        }
        public Person(int number)
        {
            Name = "No name";
            Age = number;
        }
        public Person(string text, int number)
        {
            this.Name = text;
            this.Age = number;
        }

        private string name;
        private int age;

        public string Name
        {
            get => this.name;
            set { this.name = value; }
        }
        public int Age {
            get => this.age;
            set { this.age = value; }
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }
}
