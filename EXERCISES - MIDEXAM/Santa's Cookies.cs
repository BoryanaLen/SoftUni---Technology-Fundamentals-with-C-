using System;
using System.Collections.Generic;

namespace _01._Santa_s_Cookies
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberBatches = int.Parse(Console.ReadLine());
            int totalBoxes = 0;

            for (int i = 0; i < numberBatches; i++)
            {
                int flour = int.Parse(Console.ReadLine());
                int sugar = int.Parse(Console.ReadLine());
                int cocoa = int.Parse(Console.ReadLine());

                int flourCups = flour / 140;
                int sugarSpoons = sugar / 20;
                int cocoaSpoons = cocoa / 10;

                List<int> values = new List<int> { flourCups, sugarSpoons, cocoaSpoons };
                values.Sort();

                int totalCockiesPerBake = 170 * values[0] / 25;

                int boxesFromBake = totalCockiesPerBake / 5;

                if (totalCockiesPerBake < 5)
                {
                    Console.WriteLine("Ingredients are not enough for a box of cookies.");
                }
                else
                {
                    Console.WriteLine($"Boxes of cookies: {boxesFromBake}");
                    totalBoxes += boxesFromBake;
                }
            }

            Console.WriteLine($"Total boxes: {totalBoxes}");
        }
    }
}
