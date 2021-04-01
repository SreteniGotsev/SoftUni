using Microsoft.Data.SqlClient;
using System;

namespace MinionNames
{
    class Program
    {
        const string connectionString = "Server=.; database = MinionsDB; Integrated security = true";
        static void Main(string[] args)
        {
            int id = int.Parse(Console.ReadLine());

            string name = GetName(id);

            if (name == "empty")
            {
                Console.WriteLine($"No villain with ID {id} exists in the database.");
                return;
            }

            Console.WriteLine($"Villain: {name}");

            GetMinions(id);
        }

        private static void GetMinions(int Id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $@"Select m.Name, m.Age From MinionsVillains mv
                                  Join Minions m on mv.MinionId = m.Id
                                  where VillainId = {Id}";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            Console.WriteLine("(no minions)");
                            return;
                        }

                        int count = 1;

                        while (reader.Read())
                        {
                            Console.WriteLine($"{count}.{reader[0]} {reader[1]}");
                            count++;
                        }
                    }
                }
            }
        }

        private static string GetName(int Id)
        {
            string output = string.Empty;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = $@"Select v. Name, Count(*) as C From Villains v 
                                 Join MinionsVillains m on v.Id = m.VillainID
                                 Group by v.Id, v.Name
                                 Having Id = {Id}";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    string name = command.ExecuteScalar() as string;

                    if (name == null)
                    {
                        return "empty";
                    }

                    output = name;
                }
            }

            return output;
        }
    }
}
