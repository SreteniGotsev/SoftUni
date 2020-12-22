using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();

            string[] comand = Console.ReadLine()
                                     .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            string company = comand[0];
            string user = comand[1];

            while (comand[0].ToLower() != "end")
            {
                company = comand[0];

                if (!users.ContainsKey(company))
                {
                    user = comand[1];
                    users.Add(company, new List<string>());
                    users[company].Add(user);
                }
                else if (users.ContainsKey(company) && !users[company].Contains(comand[1]))
                {
                    user = comand[1];
                    users[company].Add(user);
                }

                comand = Console.ReadLine()
                                        .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var item in users.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var curr in item.Value)
                {
                    Console.WriteLine($"-- {curr}");
                }
            }
        }
    }
}
