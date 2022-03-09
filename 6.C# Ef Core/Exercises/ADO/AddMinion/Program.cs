using Microsoft.Data.SqlClient;
using System;

namespace AddMinion
{
    class Program
    {
        const string connectionString = "Server=.;Database=MinionsDB; Integrated security = true;";
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(":");
            string[] minionInfo = input[1].Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] input2 = Console.ReadLine().Split(": ");
            string villainInfo = input2[1];

            string town = minionInfo[2];

            

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string townM = $@"Select Id From Towns                              
                              where Name =@townName like";


                using (SqlCommand command = new SqlCommand(townM,connection))
                {
                  
                }

            }
        }
    }
}
