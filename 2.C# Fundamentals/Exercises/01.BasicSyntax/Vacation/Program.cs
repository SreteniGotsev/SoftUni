using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int guestNumber = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();
            double totalPrice = 0;

            switch (day)
            {
                case "friday":
                    if (groupType == "students")
                    {
                        if (guestNumber >= 30)
                        {
                            totalPrice = guestNumber * 8.45 - (guestNumber * 0.15 * 8.45);
                        }
                        else
                        {
                            totalPrice = guestNumber * 8.45; 
                        }
                    }
                    else if (groupType == "business")
                    {
                        if (guestNumber >= 100)
                        {
                            totalPrice = (guestNumber - 10) * 10.90;
                        }
                        else
                        {
                            totalPrice = guestNumber * 10.90;
                        }
                    }
                    else if (groupType == "regular")
                    {
                        if (guestNumber >= 10 && guestNumber <= 20)
                        {
                            totalPrice = guestNumber * 15 - (guestNumber * 15 * 0.05);
                        }
                        else
                        {
                            totalPrice = guestNumber * 15;
                        }
                    }
                    
                    break;

                case "saturday":

                    if (groupType == "students")
                    {
                        if (guestNumber >= 30)
                        {
                            totalPrice = guestNumber * 9.80 - (guestNumber * 0.15 * 9.80);
                        }
                        else
                        {
                            totalPrice = guestNumber * 9.80;
                        }
                    }
                    else if (groupType == "business")
                    {
                        if (guestNumber >= 100)
                        {
                            totalPrice = (guestNumber - 10) * 15.60;
                        }
                        else
                        {
                            totalPrice = guestNumber * 15.60;
                        }
                    }
                    else if (groupType == "regular")
                    {
                        if (guestNumber >= 10 && guestNumber <= 20)
                        {
                            totalPrice = guestNumber * 20 - (guestNumber * 15 * 0.05);
                        }
                        else
                        {
                            totalPrice = guestNumber * 20;
                        }
                    }

                    break;

                case "sunday":

                    if (groupType == "students")
                    {
                        if (guestNumber >= 30)
                        {
                            totalPrice = guestNumber * 10.46 - (guestNumber * 0.15 * 10.46);
                        }
                        else
                        {
                            totalPrice = guestNumber * 10.46;
                        }
                    }
                    else if (groupType == "business")
                    {
                        if (guestNumber >= 100)
                        {
                            totalPrice = (guestNumber - 10) * 16;
                        }
                        else
                        {
                            totalPrice = guestNumber * 16;
                        }
                    }
                    else if (groupType == "regular")
                    {
                        if (guestNumber >= 10 && guestNumber <= 20)
                        {
                            totalPrice = guestNumber * 22.50 - (guestNumber * 15 * 0.05);
                        }
                        else
                        {
                            totalPrice = guestNumber * 22.50;
                        }
                    }

                    break;
                default:
                    break;
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
