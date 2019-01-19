using System;
using System.Runtime.InteropServices;

namespace _03.HoneyMoon
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = Double.Parse(Console.ReadLine());
            string city = Console.ReadLine().ToLower();
            int numberNights = Int32.Parse(Console.ReadLine());
            double pricePerNight = 0;
            double priceTickets = 0;

            if (city == "tokyo")
            {
                pricePerNight = 350 * 2;
                priceTickets = 700;
            }
            
            else if (city == "new york")
            {
                pricePerNight = 300 * 2;
                priceTickets = 650;
            }

            else if (city == "lima")
            {
                pricePerNight = 400 * 2;
                priceTickets = 850;
            }
            
            else if (city == "paris")
            {
                pricePerNight = 150 * 2;
                priceTickets = 350;
            }
            
            else if (city == "cairo")
            {
                pricePerNight = 250 * 2;
                priceTickets = 600;
            }

            double totalPrice = priceTickets + pricePerNight * numberNights;

            if (numberNights >= 50)
            {
                totalPrice = totalPrice - 0.3 * totalPrice;
            }
            
            else if (numberNights >= 25)
            {
                if (city == "tokyo" || city == "cairo")
                {
                    totalPrice = totalPrice - 0.17 * totalPrice;
                }

                else if (city == "new york" || city == "lima")
                {
                    totalPrice = totalPrice - 0.19 * totalPrice;
                }

                else if (city == "paris")
                {
                    totalPrice = totalPrice - 0.22 * totalPrice;
                }
                
            }

            else if (numberNights >= 10)
            {
                if (city == "cairo")
                {
                    totalPrice = totalPrice - 0.1 * totalPrice;
                }

                else if (city == "paris" || city == "new york" || city == "tokyo")
                {
                    totalPrice = totalPrice - 0.12 * totalPrice;
                }
            }

            else if (numberNights >= 5)
            {
                if (city == "cairo" || city == "new york")
                {
                    totalPrice = totalPrice - 0.05 * totalPrice;
                }
                
                else if (city == "paris")
                {
                    totalPrice = totalPrice - 0.07 * totalPrice;
                }
            }

            else if (numberNights >= 1)
            {
                if (city == "cairo" || city == "new york")
                {
                    totalPrice = totalPrice - 0.03 * totalPrice;
                }
            }

            
            if (budget >= totalPrice)
            {
                Console.WriteLine($"Yes! You have {(budget - totalPrice):F2} leva left.");    
            }

            else
            {
                Console.WriteLine($"Not enough money! You need {(totalPrice - budget):F2} leva.");
            }
        }
    }
}