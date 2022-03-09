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

            string output = GetEmployeesFromResearchAndDevelopment(context);

            Console.WriteLine(output);
        }

        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            StringBuilder info = new StringBuilder();

            var employees = context.Employees.Where(x => x.Department.Name == "Research and Development").Select(x => new
            {
                x.FirstName,
                x.LastName,
                x.Department.Name,
                x.Salary

            }).OrderBy(x => x.Salary).ThenByDescending(x => x.FirstName);

            foreach (var employee in employees)
            {
                info.AppendLine($"{employee.FirstName} {employee.LastName} from {employee.Name} - ${employee.Salary:f2}");
            }

            return info.ToString();
        }

    }
}
