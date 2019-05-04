using System;

namespace _09.Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = double.Parse(Console.ReadLine());
            int countStudents = int.Parse(Console.ReadLine());
            double priceLightsabers = double.Parse(Console.ReadLine());
            double priceRobes = double.Parse(Console.ReadLine());
            double priceBelts = double.Parse(Console.ReadLine());
            double totatPrice = 0;

            double countLightsabers =(Math.Ceiling(countStudents * 1.1));
            double freeBelts = countStudents / 6;

            totatPrice = countStudents * priceRobes + countStudents * priceBelts - freeBelts * priceBelts
                + countLightsabers * priceLightsabers;

            if (totatPrice <= amount)
            {
                Console.WriteLine($"The money is enough - it would cost {totatPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(totatPrice-amount):F2}lv more.");
            }
        }
    }
}
