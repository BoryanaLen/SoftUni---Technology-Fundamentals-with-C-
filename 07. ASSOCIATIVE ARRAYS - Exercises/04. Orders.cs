using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> prices = new Dictionary<string, double>();
            Dictionary<string, int> quantities = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "buy")
                {
                    break;
                }

                List<string> inputInfo = input.Split().ToList();

                string product = inputInfo[0];
                double price = double.Parse(inputInfo[1]);
                int quantity = int.Parse(inputInfo[2]);

                if (prices.ContainsKey(product))
                {
                    if(prices[product] != price)
                    {
                        prices[product] = price;
                    }
                }
                else
                {
                    prices.Add(product, price);
                }

                if (quantities.ContainsKey(product))
                {
                    quantities[product] += quantity;
                }
                else
                {
                    quantities.Add(product, quantity);
                }
            }

            foreach(var element in prices)
            {
                double currentPrice = element.Value;
                int currentQuantity = quantities[element.Key];

                double total = currentPrice * currentQuantity;

                Console.WriteLine($"{element.Key} -> {total:F2}");
            }
        }
    }
}
