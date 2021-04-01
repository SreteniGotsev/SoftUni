using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
    private int age;

    public int Age
    {
        get => this.age;

        set => this.age = value;
    }
    public string Name
    {
        get => this.name;
        set => this.name = value;
    }
}
}
