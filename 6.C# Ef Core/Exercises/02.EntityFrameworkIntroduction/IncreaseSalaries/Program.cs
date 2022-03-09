using System;
using System.Linq;
using System.Text;
using SoftUni.Data;

namespace SoftUni
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();

            string output = IncreaseSalaries(context);

            Console.WriteLine(output);
        }

        public static string IncreaseSalaries(SoftUniContext context)
        {
            StringBuilder content = new StringBuilder();


            var employees = context.Employees.Where(x => x.Department.Name == "Engineering" || x.Department.Name == "Tool Design" 
                                      || x.Department.Name == "Marketing" || x.Department.Name == "Information Services")
                                          .OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

            foreach (var employee in employees)
            {
                employee.Salary *= 1.12m;
            }

            context.SaveChanges();

            foreach (var emp in employees)
            {
                content.AppendLine($"{emp.FirstName} {emp.LastName} (${emp.Salary:f2})");
            }

            return content.ToString().TrimEnd();
        }
    }
}
