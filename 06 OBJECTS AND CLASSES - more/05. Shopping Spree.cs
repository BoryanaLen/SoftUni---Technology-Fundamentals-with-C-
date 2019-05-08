using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            List<string> peopleList = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach(string personInfo in peopleList)
            {
                List<string> inputPerson = personInfo.Split('=').ToList();

                string name = inputPerson[0];
                double money = double.Parse(inputPerson[1]);

                people.Add(new Person(name, money));

            }

            List<string> productList = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (string productInfo in productList)
            {
                List<string> inputProduct = productInfo.Split('=').ToList();

                string name = inputProduct[0];
                double cost = double.Parse(inputProduct[1]);

                products.Add(new Product(name, cost));

            }

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "END")
                {
                    break;
                }

                List<string> command = input.Split(' ').ToList();

                string personName = command[0];
                string product = command[1];

                for(int i =0; i<people.Count; i++)
                {
                    if(people[i].Name == personName)
                    {
                        double price = products.Find(order => order.Name == product).Cost;

                        if (price > people[i].Money)
                        {
                            Console.WriteLine($"{people[i].Name} can't afford {product}");
                        }
                        else
                        {
                            people[i].products.Add(product);
                            Console.WriteLine($"{people[i].Name} bought {product}");
                            people[i].Money -= price;
                        }
                    }
                }
            }

            foreach(Person person in people)
            {
                if(person.products.Count == 0)
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.products)} ");
                }
            }
        }
    }

    class Person
    {
        public string Name { get; set; }

        public double Money { get; set; }

        public List<string> products { get; set; }

        public Person(string name, double money)
        {
            this.Name = name;
            this.Money = money;
            products = new List<string>();
        }
    }

    class Product
    {
        public string Name { get; set; }

        public double Cost { get; set; }

        public Product(string name, double cost)
        {
            this.Name = name;
            this.Cost = cost;
        }
    }
}
