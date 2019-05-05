using System;

namespace _05._Orders
{
    class Program
    {
        static void CalculatePrice(string product, int ququantity)
        {
            double price = 0;

            switch (product)
            {
                case "coffee": price = 1.5 * ququantity; break;
                case "water": price = 1 * ququantity; break;
                case "coke": price = 1.4 * ququantity; break;
                case "snacks": price = 2 * ququantity; break;
            }

            Console.WriteLine($"{price:F2}");
        }


        static void Main(string[] args)
        {
            CalculatePrice(Console.ReadLine(), int.Parse(Console.ReadLine()));
        }
    }
}
