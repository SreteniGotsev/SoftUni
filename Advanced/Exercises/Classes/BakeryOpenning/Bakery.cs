using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakeryOpenning
{
    public class Bakery
    {

        private List<Employee> employees;


        public Bakery(string name, int capacity)
        {
            this.Name = name;

            this.Employees = new List<Employee>();

            this.Capacity = capacity;
        }

        public string Name { get; set; }

        public List<Employee> Employees { get; set; }

        public int Capacity { get; set; }

        public void Add(Employee employee)
        {
            if (this.Employees.Count < this.Capacity)
            {
                this.Employees.Add(employee);
            }
        }

        public bool Remove(string name)
        {
            Employee employee = this.Employees.FirstOrDefault(e => e.Name == name);
            if (employee != null)
            {
                Employees.Remove(employee);
                return true;

            }
            return false;
        }

        public Employee GetOldestEmployee()
        {
            Employee oldestEmployee = this.Employees.OrderByDescending(x => x.Age).First();

            return oldestEmployee;
        }

        public Employee GetEmployee(string name)
        {
            Employee employee = this.Employees.First(x => x.Name == name);
            return employee;
        }

        public int Count => this.Employees.Count;

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Employees working at Bakery {this.Name}:" + Environment.NewLine);

            foreach (var item in this.Employees)
            {
                sb.Append(item + Environment.NewLine);
            }

            return sb.ToString();
        }



    }
}
