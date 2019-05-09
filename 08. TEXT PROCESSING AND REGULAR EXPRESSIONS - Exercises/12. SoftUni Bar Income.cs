using System;
using System.Text.RegularExpressions;

namespace _12._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\%(?<customer>[A-Z][a-z]+)\%[^$|.%]*\<(?<product>[\w]+)\>[^$|.%]*\|(?<count>[0-9]+)\|[^$|.%]*?(?<price>\d+([.]\d+)?)\$";

            double income = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "end of shift")
                {
                    break;
                }

                if(Regex.IsMatch(input, pattern))
                {
                    string customer = Regex.Match(input, pattern).Groups["customer"].Value;
                    string product = Regex.Match(input, pattern).Groups["product"].Value;
                    int count = int.Parse(Regex.Match(input, pattern).Groups["count"].Value);
                    double price = double.Parse(Regex.Match(input, pattern).Groups["price"].Value);

                    double totalPrice = price * count;

                    Console.WriteLine($"{customer}: {product} - {totalPrice:F2}");

                    income += totalPrice;
                }
            }

            Console.WriteLine($"Total income: {income:F2}");
        }
    }
}
