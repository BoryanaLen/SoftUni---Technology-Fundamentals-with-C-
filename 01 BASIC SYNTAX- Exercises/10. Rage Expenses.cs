using System;

namespace _10.Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double priceHeadset = double.Parse(Console.ReadLine());
            double priceMouse = double.Parse(Console.ReadLine());
            double priceKeyboard = double.Parse(Console.ReadLine());
            double priceDisplay = double.Parse(Console.ReadLine());

            double totalExpenses = 0;

            for(int i=1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    totalExpenses += priceHeadset;
                }
                if (i % 3 == 0)
                {
                    totalExpenses += priceMouse;
                }
                if (i % 6 == 0)
                {
                    totalExpenses += priceKeyboard;
                }
                if (i % 12 == 0)
                {
                    totalExpenses += priceDisplay;
                }
            }

            Console.WriteLine($"Rage expenses: {totalExpenses:F2} lv.");
        }
    }
}
