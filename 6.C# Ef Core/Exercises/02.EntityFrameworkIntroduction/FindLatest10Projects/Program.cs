using System;
using System.Globalization;
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

            string output = GetLatestProjects(context);

            Console.WriteLine(output);
        }

        public static string GetLatestProjects(SoftUniContext context)
        {
            StringBuilder content = new StringBuilder();

            var projects = context.Projects.OrderByDescending(x => x.StartDate).Take(10);

            foreach (var project in projects.OrderBy(x=>x.Name))
            {
                content.AppendLine(project.Name);
                content.AppendLine(project.Description);
                content.AppendLine(project.StartDate.ToString("M/d/yyyy h:mm:ss tt",CultureInfo.InvariantCulture));
            }

            return content.ToString().TrimEnd();
        }
    }
}
