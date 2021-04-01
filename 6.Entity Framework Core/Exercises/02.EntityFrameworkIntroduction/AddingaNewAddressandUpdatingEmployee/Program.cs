using System;
using System.Linq;
using System.Text;
using SoftUni.Data;
using SoftUni.Models;

namespace SoftUni
{
   public  class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();

            string output = AddNewAddressToEmployee(context);

            Console.WriteLine(output);
        }

        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            StringBuilder info = new StringBuilder();

            var address = new Address
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };

            context.Addresses.Add(address);
            context.SaveChanges();

            var person = context.Employees.Where(x => x.LastName == "Nakov").FirstOrDefault();

            person.AddressId = address.AddressId;

            context.SaveChanges();

            var addresses = context.Employees.Select(x => new { x.Address.AddressText, x.AddressId }).OrderByDescending(x => x.AddressId).Take(10);

            foreach (var curraddress in addresses)
            {
                info.AppendLine(curraddress.AddressText);
            }

            return info.ToString();
        }
    }
}
