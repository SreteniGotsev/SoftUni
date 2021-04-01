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

            string output = DeleteProjectById(context);

            Console.WriteLine(output);
        }

        public static string DeleteProjectById(SoftUniContext context)
        {
            StringBuilder content = new StringBuilder();

            var project = context.Projects.Where(project => project.ProjectId == 2).FirstOrDefault();

            var empProj = context.EmployeesProjects.Where(x => x.ProjectId == 2);

            context.EmployeesProjects.RemoveRange(empProj);

            context.Projects.Remove(project);

            //context.SaveChanges();

            var projects = context.Projects.Take(10).Select(p=> new { p.Name});

            foreach (var proj in projects)
            {
                content.AppendLine(proj.Name);
            }

            return content.ToString().TrimEnd();
        }
    }
}
