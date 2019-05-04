using System;

namespace _7.Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputCoins;
            string inputProduct;
            double coins;
            double totalMoney = 0;
            double price = 0;


            while (true)
            {
                inputCoins = Console.ReadLine();

                if(inputCoins== "Start")
                {
                    break;
                }

                coins = double.Parse(inputCoins);

                if(coins==0.1 || coins==0.2 || coins==0.5 || coins==1 || coins == 2)
                {
                    totalMoney += coins;   
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
            }

            while (true)
            {
                inputProduct = Console.ReadLine();

                if(inputProduct== "End")
                {
                    Console.WriteLine($"Change: {totalMoney:F2}");
                    break;
                }

                if(inputProduct== "Nuts")
                {
                    price = 2;
                }
                else  if (inputProduct == "Water")
                {
                    price = 0.7;
                }
                else if (inputProduct == "Crisps")
                {
                    price = 1.5;
                }
                else if (inputProduct == "Soda")
                {
                    price = 0.8;
                }
                else if (inputProduct == "Coke")
                {
                    price = 1;
                }
                else
                {
                    Console.WriteLine($"Invalid product");
                    price = 0;
                }

                if (price <= totalMoney & price!=0)
                {
                    Console.WriteLine($"Purchased {inputProduct.ToLower()}");
                    totalMoney -= price;
                }
                else if((price > totalMoney & price != 0))
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }

            

        }
    }
}
