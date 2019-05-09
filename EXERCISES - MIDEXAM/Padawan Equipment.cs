using System;

namespace _01._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberStudents = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double totalLights = lightsaberPrice * Math.Ceiling(numberStudents * 1.1);
            double totalRobes = robePrice * numberStudents;
            int countBelts = 0;

            for (int i = 1; i <= numberStudents; i++)
            {
                if (i % 6 != 0)
                {
                    countBelts++;
                }
            }

            double totalBelts = countBelts * beltPrice;

            double totalExpenses = totalBelts + totalLights + totalRobes;

            if (budget >= totalExpenses)
            {
                Console.WriteLine($"The money is enough - it would cost {totalExpenses:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(totalExpenses - budget):F2}lv more.");
            }
        }
    }
}
