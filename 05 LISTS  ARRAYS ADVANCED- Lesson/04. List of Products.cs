using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for(int i =0; i<numberLines; i++)
            {
                string product = Console.ReadLine();

                products.Add(product);
            }

            products.Sort();

            for(int j =1; j<=numberLines; j++)
            {
                Console.WriteLine($"{j}.{products[j-1]}");
            }
        }
    }
}
