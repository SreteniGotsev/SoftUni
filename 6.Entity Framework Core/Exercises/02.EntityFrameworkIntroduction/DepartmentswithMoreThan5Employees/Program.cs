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

            string output = GetDepartmentsWithMoreThan5Employees(context);

            Console.WriteLine(output);
        }

        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            StringBuilder content = new StringBuilder();

            //var departments = context.Departments.Where(x => x.Employees.Count > 5).Select(x => new
            //{
            //    DepartmentName = x.Name,
            //    ManagerFirstName = x.Manager.FirstName,
            //    ManagerLastName = x.Manager.LastName,
            //    Employees = x.Employees.Select(e => new
            //    {
            //        EmployeeFirstName = e.FirstName,
            //        EmployeeLastName = e.LastName,
            //        EmployeeJobTitle = e.JobTitle
            //    }),
            //    ECount = x.Employees.Count

            //});
            var departments = context
            .Departments.Where(department => department.Employees.Count > 5)
            .Include(x => x.Manager)
            .Include(x => x.Employees)
            .OrderBy(department => department.Employees.Count)
            .ThenBy(x => x.Name)
            .ToArray();

            foreach (var department in departments)
            {
                content.AppendLine($"{department.Name} - {department.Manager.FirstName} {department.Manager.LastName}");

                var employees = department.Employees.OrderBy(x => x.FirstName).ThenBy(x => x.LastName);

                foreach (var employee in employees)
                {
                    content.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");
                }
            }


            //foreach (var department in departments.OrderBy(x => x.ECount).ThenBy(x => x.DepartmentName))
            //{

            //    content.AppendLine($" {department.DepartmentName} - {department.ManagerFirstName} {department.ManagerLastName}");

            //    foreach (var employee in department.Employees.OrderBy(x => x.EmployeeFirstName).ThenBy(x => x.EmployeeLastName))
            //    {

            //        content.AppendLine($" {employee.EmployeeFirstName} {employee.EmployeeLastName} - {employee.EmployeeJobTitle}");

            //    }
            //}

            return content.ToString().TrimEnd();
        }
    }
}
