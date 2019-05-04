using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double spendMoney = 0;
            string input;
            double price;

            while (true)
            {
                input = Console.ReadLine();

                if(input== "Game Time")
                {
                    Console.WriteLine($"Total spent: ${spendMoney:F2}. Remaining: ${(balance-spendMoney):F2}");
                    break;
                }

                if(input== "OutFall 4")
                {
                    price = 39.99;
                }
                else if(input== "CS: OG")
                {
                    price = 15.99;
                }
                else if (input == "Zplinter Zell")
                {
                    price = 19.99;
                }
                else if (input == "Honored 2")
                {
                    price = 59.99;
                }
                else if (input == "RoverWatch")
                {
                    price = 29.99;
                }
                else if (input == "RoverWatch Origins Edition")
                {
                    price = 39.99;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    price = 0;
                }

                if (price <= (balance-spendMoney) & price!=0)
                {
                    Console.WriteLine($"Bought {input}");
                    spendMoney += price;
                }
                else if(price> (balance - spendMoney) & price != 0)
                {
                    Console.WriteLine("Too Expensive");
                }

                if (balance == spendMoney)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }
        }
    }
}
