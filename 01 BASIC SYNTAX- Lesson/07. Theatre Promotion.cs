using System;

namespace _07.Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double price = 0;

            if(day== "Weekday")
            {
                if (age >= 0 & age <= 18)
                {
                    price = 12;
                }
                else if (age > 18 & age <= 64)
                {
                    price = 18;
                }
                else if (age > 18 & age <= 122)
                {
                    price = 12;
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else if(day== "Weekend")
            {
                if (age >= 0 & age <= 18)
                {
                    price = 15;
                }
                else if (age > 18 & age <= 64)
                {
                    price = 20;
                }
                else if (age > 18 & age <= 122)
                {
                    price = 15;
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }
            else if (day == "Holiday")
            {
                if (age >= 0 & age <= 18)
                {
                    price = 5;
                }
                else if (age > 18 & age <= 64)
                {
                    price = 12;
                }
                else if (age > 18 & age <= 122)
                {
                    price = 10;
                }
                else
                {
                    Console.WriteLine("Error!");
                }
            }

            if (price > 0)
            {
                Console.WriteLine($"{price}$");
            }
        }
    }
}
