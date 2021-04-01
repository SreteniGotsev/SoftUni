using System;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using SoftUni.Data;

namespace SoftUni
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();

            string output = GetEmployee147(context);

            Console.WriteLine(output);
        }

        public static string GetEmployee147(SoftUniContext context)
        {
            StringBuilder content = new StringBuilder();

            var employee = context.Employees.Where(x => x.EmployeeId == 147).Select(e => new
            {
                e.FirstName,
                e.LastName,
                e.JobTitle,
                Projects = e.EmployeesProjects.Select(p => new
                {
                    p.Project.Name,
                    p.Project.StartDate,
                    p.Project.EndDate
                })
            }).FirstOrDefault();


            content.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");

            foreach (var project in employee.Projects.OrderBy(x=>x.Name))
            {
                content.AppendLine($"{project.Name}");

            }


            return content.ToString().TrimEnd();
        }
    }
}
