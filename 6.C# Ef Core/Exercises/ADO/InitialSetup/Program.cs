using Microsoft.Data.SqlClient;
using System;

namespace InitialSetup
{
    class Program
    {
        const string sqlStartConectionString = "Server=.;Database = master; Integrated security =true";

        const string connectionString = "Server=.; database = MinionsDB; Integrated security = true";
        static void Main(string[] args)
        {
            using (SqlConnection connection = new SqlConnection(sqlStartConectionString))
            {
                connection.Open();

                string createDatabase = "Create Database MinionsDB";

                using (SqlCommand command = new SqlCommand(createDatabase, connection))
                {
                    command.ExecuteNonQuery();
                }
            }

            using (SqlConnection connection1 = new SqlConnection(connectionString))
            {
                connection1.Open();

                string[] commands = new string[]
                {
                    "Create Table Countries" +
                    "(Id Int Primary Key Identity," +
                    "Name Varchar(50) Not Null)",

                    "Create Table Towns" +
                    "(Id Int Primary Key Identity," +
                    "Name Varchar(50) Not Null," +
                    "CountryCod Int Foreign Key References Countries(Id) Not Null)",

                    "Create table Minions" +
                    "(Id Int Primary Key Identity," +
                    "Name Varchar(50) Not Null," +
                    "Age Int Not Null," +
                    "TownId Int Foreign Key References " +
                    "Towns(Id) Not Null)",

                    "Create table EvilnessFactors"+
                    "(Id Int Primary Key Identity,"+
                    "Name Varchar(50) Not Null)",

                    "Create table Villains"+
                    "(Id Int Primary Key Identity,"+
                    "Name Varchar(50) Not Null,"+
                    "EvilnessFactorId Int Foreign Key References EvilnessFactors(Id) Not Null)",

                    "Create table MinionsVillains"+
                    "(MinionId Int Foreign Key References Minions(Id) Not Null,"+
                    "VillainId Int Foreign Key References Villains(Id) Not Null,"+
                    "Primary Key (MinionId,VillainId))"
                };

                foreach (var item in commands)
                {

                    using (SqlCommand command = new SqlCommand(item, connection1))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }

            using (SqlConnection connection1 = new SqlConnection(connectionString))
            {
                connection1.Open();

                string[] commands = new string[]
                {
                    "Insert Into Countries(Name)Values"+
                    "('Bulgaria'),('Germany'),('France'),('Italy'),('Spain')",

                    "Insert Into Towns(Name, CountryCod)Values"+
                    "('Sofia',1),('Berlin',2),('Paris',3),('Rome',4),('Madrid',5)",

                    "Insert Into Minions(Name,Age,TownId)Values"+
                    "('Ganio', 18,1),('Muler',19,2),('Lui',20,3),('Masimo',21,4),('Jose',22,5),"+
                    "('Pesho', 99,1),('Gosho',67,1),('Misho',40,1),('Pachoti',21,4),('Jose',22,4),"+
                    "('DrugiqPesho', 99,1),('DrugiqGosho',67,1),('MishoDrugiq',40,1),('PachotiVtori',21,4),('Jose3',22,4)",

                    "Insert Into EvilnessFactors(Name)Values"+
                    "('super good'),('good'),('bad'),('evil'),('super evil')",

                    "Insert Into Villains(Name,EvilnessFactorId)Values"+
                    "('Vil1',1),('Vil2',2),('Vil3',3),('Vil4',4),('Vil5',5)",

                    "Insert Into MinionsVillains(MinionId,VillainId)Values"+
                    "(1,1),(2,2),(3,3),(4,4),(5,5),(6,1),(7,1),(8,1),(9,4),(10,4),(11,4),(12,3),(13,3),(14,3),(15,1)"

                };

                foreach (var item in commands)
                {

                    using (SqlCommand command = new SqlCommand(item, connection1))
                    {
                        command.ExecuteNonQuery();
                    }
                }

            }

        }

    }
}
