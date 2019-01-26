using System;

namespace _01.WeddingHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double sideBar = double.Parse(Console.ReadLine());

            double totalArea = width * length;
            double barArea = Math.Pow(sideBar, 2);
            double dancingArea = 0.19 * totalArea;

            double freeArea = totalArea - (barArea + dancingArea);

            int numberOfPeople = (int)Math.Ceiling(freeArea / 3.2);

            Console.WriteLine(numberOfPeople);
        }
    }
}
