using Microsoft.Data.SqlClient;
using System;

namespace VillainNames
{
    class Program
    {
        const string connectionString = "Server=.; database = MinionsDB; Integrated security = true";
        static void Main(string[] args)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"Select v. Name, Count(*) as C From Villains v 
                               Join MinionsVillains m on v.Id = m.VillainID
                               Group by v.Id, v.Name
                               Having Count(m.MinionId) > 3
                               order by c desc";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            object name = reader[0] as string;
                            object count = reader[1];

                            Console.WriteLine($"{name} - {count}");
                        }
                    }
                }
            }
        }
    }
}
