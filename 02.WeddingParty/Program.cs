using System;

namespace _02.WeddingParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberGuests = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            int expenses = numberGuests * 20;

            if (budget >= expenses)
            {
                int remaining = budget - expenses;
                double expensesFirework = 0.4 * remaining;
                Console.WriteLine($"Yes! {(Math.Round(expensesFirework))} lv are for fireworks and {Math.Round(remaining - expensesFirework)} lv are for donation.");
            }

            else
            {
                Console.WriteLine($"They won't have enough money to pay the covert. They will need {expenses - budget} lv more.");
            }
        }
    }
}
