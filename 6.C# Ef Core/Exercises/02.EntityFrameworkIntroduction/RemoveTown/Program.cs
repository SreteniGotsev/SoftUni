using System;
using System.Linq;
using SoftUni.Data;

namespace SoftUni
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();

            string output = RemoveTown(context);

            Console.WriteLine(output);


        }

        public static string RemoveTown(SoftUniContext context)
        {
            var town = context.Towns.FirstOrDefault(x => x.Name == "Seattle");

            var addresses = town.Addresses.Select(x => x.AddressId).ToList();

            var employees = context.Employees.Where(x => addresses.Contains(x.AddressId.Value));


            foreach (var emp in employees)
            {
                emp.AddressId = null;
            }

            foreach (var add in addresses)
            {
                var addr = context.Addresses.FirstOrDefault(x => x.AddressId == add);

                context.Addresses.Remove(addr);
            }

            context.Towns.Remove(town);

            //context.SaveChanges();

            return $"{addresses.Count} addresses in Seattle were deleted";
        }
    }

}
