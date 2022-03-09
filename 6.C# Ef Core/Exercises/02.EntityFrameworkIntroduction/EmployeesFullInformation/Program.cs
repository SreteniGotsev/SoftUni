using SoftUni.Data;
using System;
using System.Linq;
using System.Text;

namespace SoftUni
{
    public  class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();

            string output = GetEmployeesFullInformation(context);

            Console.WriteLine(output);
        }

        public static string GetEmployeesFullInformation(SoftUniContext context)
        {

            var employees = context.Employees.OrderBy(x=>x.EmployeeId);

            StringBuilder information = new StringBuilder();

            foreach (var employee in employees)
            {
                information.AppendLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary:f2}");
               
            }
            

            return information.ToString();
        }
    }
}
