using System;

namespace _01.WeddingTime
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceWhiskey = double.Parse(Console.ReadLine());
            double quantityWater = double.Parse(Console.ReadLine());
            double quantityWine = double.Parse(Console.ReadLine());
            double quantityChampagne = double.Parse(Console.ReadLine());
            double quantityWhiskey = double.Parse(Console.ReadLine());

            double priceChampagne = priceWhiskey - priceWhiskey * 0.5;
            double priceWine = priceChampagne - 0.6 * priceChampagne;
            double priceWater = priceChampagne - 0.9 * priceChampagne;

            double totalExpenses = priceWhiskey * quantityWhiskey + priceChampagne * quantityChampagne + priceWine * quantityWine + priceWater * quantityWater;
            Console.WriteLine($"{totalExpenses:F2}");
        }
    }
}
