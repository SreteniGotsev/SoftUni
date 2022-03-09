using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine().ToLower();
            string pass = string.Empty;
           
            for (int i = user.Length; i > 0; i--)
            {
                pass += user[i - 1];
            }
            string password = Console.ReadLine();
            int counter = 0;
            while (pass != password)
            {
                counter++;
                if (counter > 3)
                {
                    Console.WriteLine($"User {user} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                password = Console.ReadLine();
                
            }
            if (pass == password)
            {
            Console.WriteLine($"User {user} logged in.");

            }
        }
    }
}
