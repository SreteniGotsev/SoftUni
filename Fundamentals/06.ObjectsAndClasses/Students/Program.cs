using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < count; i++)
            {
                string[] comand = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string forename = comand[0];
                string surname = comand[1];
                double grade = double.Parse(comand[2]);

                Student student = new Student(forename, surname, grade);

                students.Add(student);
            }

            students = students.OrderByDescending(s => s.Grade).ToList();

            Console.WriteLine(string.Join(Environment.NewLine,students));

        }

        class Student
        {
            public Student(string forename, string surname, double grade)
            {
                Forename = forename;
                Surname = surname;
                Grade = grade;
            }

            public string Forename { get; set; }
            public string Surname { get; set; }
            public double Grade { get; set; }

            public override string ToString()
            {
                return $"{Forename} {Surname}: {Grade:f2}"; 
            }


        }
    }

}

