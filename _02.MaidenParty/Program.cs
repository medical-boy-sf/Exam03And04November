using System;

namespace _03.MaidenParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double expensesMaidenParty = double.Parse(Console.ReadLine());
            double numberLoveMessages = Double.Parse(Console.ReadLine());
            double numberWaxRoses = Double.Parse(Console.ReadLine());
            double numberKeychain = Double.Parse(Console.ReadLine());
            double numberCaricatures = Double.Parse(Console.ReadLine());
            double numberLuckySurprises = Double.Parse(Console.ReadLine());

            double priceLoveMessage = 0.6;
            double priceWaxRose = 7.2;
            double priceKeychain = 3.6;
            double priceCaricature = 18.2;
            double priceLuckySurprise = 22;
            double totalNumberItems = numberLoveMessages + numberWaxRoses + numberKeychain + numberCaricatures +
                                   numberLuckySurprises;
            
            double totalSum = numberLoveMessages * priceLoveMessage + numberWaxRoses * priceWaxRose +
                              numberKeychain * priceKeychain + numberCaricatures * priceCaricature +
                              numberLuckySurprises * priceLuckySurprise;

            if (totalNumberItems >= 25)
            {
                totalSum = totalSum - totalSum * 0.35;
            }
            
            totalSum = totalSum - totalSum * 0.1;

            if (totalSum >= expensesMaidenParty)
            {
                Console.WriteLine($"Yes! {(totalSum - expensesMaidenParty):F2} lv left.");
            }

            else
            {
                Console.WriteLine($"Not enough money! {(expensesMaidenParty - totalSum):F2} lv needed.");
            }

        }
    }
}