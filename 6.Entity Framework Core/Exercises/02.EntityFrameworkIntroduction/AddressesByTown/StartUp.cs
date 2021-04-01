using System;
using System.Linq;
using System.Text;
using SoftUni.Data;

namespace Softuni
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();

            string output = GetAddressesByTown(context);

            Console.WriteLine(output);
        }


        public static string GetAddressesByTown(SoftUniContext context)
        {
            StringBuilder content = new StringBuilder();

            var addresses = context.Addresses
                .Select(a=> new 
                { 
                    a.AddressText,
                    a.Town.Name,
                    a.Employees.Count
                }).OrderByDescending(x => x.Count)
                .ThenBy(x => x.Name).ThenBy(x => x.AddressText).Take(10);

            foreach (var address in addresses)
            {
                content.AppendLine($"{address.AddressText}, {address.Name} - {address.Count} employees");
            }

            return content.ToString().TrimEnd();

        }
    }
}
