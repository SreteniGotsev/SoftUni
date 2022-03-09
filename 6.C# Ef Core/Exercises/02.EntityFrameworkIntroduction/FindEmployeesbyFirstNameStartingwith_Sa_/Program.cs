using System;
using System.Globalization;
using System.Linq;
using System.Text;
using SoftUni.Data;

namespace SoftUni
{
    public class StartUp
    {
        public static CultureInfo CulturalInfo { get; private set; }

        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();

            string output = GetEmployeesByFirstNameStartingWithSa(context);

            Console.WriteLine(output);
        }

        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            StringBuilder content = new StringBuilder();


            var employees = context.Employees.Where(x => x.FirstName.StartsWith("Sa"))
                .Select(p=> new{
                                  p.FirstName,
                                  p.LastName,
                                  p.JobTitle,
                                  p.Salary
                                               })
                .OrderBy(x=>x.FirstName).ThenBy(x=>x.LastName);

            
            foreach (var emp in employees)
            {
                content.AppendLine($"{emp.FirstName} {emp.LastName} - {emp.JobTitle} - (${emp.Salary:f2})");
            }

            return content.ToString().TrimEnd();
        }
    }
}
