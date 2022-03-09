using System;
using System.Globalization;
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

            string output = GetEmployeesInPeriod(context);

            Console.WriteLine(output);
        }

        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            StringBuilder info = new StringBuilder();

            var employees = context.Employees.Where(x => x.EmployeesProjects.Any(e => e.Project.StartDate.Year <= 2003
            && e.Project.StartDate.Year >= 2001)).Select(x => new
            {
                EmployeeName = x.FirstName,
                EmployeeSurname = x.LastName,
                ManagerName = x.Manager.FirstName,
                ManagerSurname = x.Manager.LastName,
                Projects = x.EmployeesProjects.Select(p => new
                {
                    p.Project.Name,
                    p.Project.StartDate,
                    p.Project.EndDate
                })
            }).Take(10);

            //foreach (var employee in employees)
            //{
            //    info.AppendLine($"{employee.EmployeeName} {employee.EmployeeSurname} " +
            //        $"- Manager: {employee.ManagerName} {employee.ManagerSurname} ");

            //    foreach (var project in employee.Projects)
            //    {
            //        var endDate = project.EndDate.HasValue ? project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt",
            //            CultureInfo.InvariantCulture) : "not finished";

            //        if (project.StartDate.Year >= 2001 && project.StartDate.Year <= 2003)
            //        {
            //            info.AppendLine($"--{project.Name} - {project.StartDate} - {endDate}");
            //        }

            //    }
            //}

            foreach(var employee in employees)
            {
                info.AppendLine($"{employee.EmployeeName} {employee.EmployeeSurname} " +
                    $"- Manager: {employee.ManagerName} {employee.ManagerSurname}");

                foreach (var project in employee.Projects)
                {
                    info.AppendLine($"--{project.Name} -" +
                                       $" {project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)} - " +
                                       $"{(project.EndDate == null ? "not finished" : project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture))}");
                }
            }
        

            return info.ToString().TrimEnd();
        }
    }

}


