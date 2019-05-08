using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            List<Truck> trucks = new List<Truck>();

            double sumCarsHorsePower = 0;

            double sumTrucksHorsePower = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                List<string> itemInfo = input.Split(' ').ToList();

                string model = itemInfo[1];
                string color = itemInfo[2];
                int horsePower = int.Parse(itemInfo[3]);

                switch (itemInfo[0].ToLower())
                {
                    case "truck":
                        trucks.Add(new Truck(model, color, horsePower));
                        sumTrucksHorsePower += horsePower;
                        break;
                    case "car":
                        cars.Add(new Car(model, color, horsePower));
                        sumCarsHorsePower += horsePower;
                        break;
                }
            }

            while (true)
            {
                string inputModel = Console.ReadLine();

                if (inputModel == "Close the Catalogue")
                {
                    if (cars.Count >= 1)
                    {
                        Console.WriteLine($"Cars have average horsepower of: {(sumCarsHorsePower / cars.Count):F2}.");
                    }
                    else
                    {
                        Console.WriteLine($"Cars have average horsepower of: 0.00.");
                    }

                    if (trucks.Count >= 1)
                    {
                        Console.WriteLine($"Trucks have average horsepower of: {(sumTrucksHorsePower / trucks.Count):F2}.");
                    }
                    else
                    {
                        Console.WriteLine($"Trucks have average horsepower of: 0.00.");
                    }

                    break;
                }

                foreach (Car car in cars)
                {
                    if (car.Model == inputModel)
                    {
                        Console.WriteLine("Type: Car");
                        Console.WriteLine($"Model: {car.Model}");
                        Console.WriteLine($"Color: {car.Color}");
                        Console.WriteLine($"Horsepower: {car.Horsepower}");
                    }
                }

                foreach (Truck truck in trucks)
                {
                    if (truck.Model == inputModel)
                    {
                        Console.WriteLine("Type: Truck");
                        Console.WriteLine($"Model: {truck.Model}");
                        Console.WriteLine($"Color: {truck.Color}");
                        Console.WriteLine($"Horsepower: {truck.Horsepower}");
                    }
                }
            }
        }
    }

    class Car
    {
        public string Model { get; set; }

        public string Color { get; set; }

        public int Horsepower { get; set; }

        public Car(string model, string color, int horsePower)
        {
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsePower;
        }
    }

    class Truck
    {
        public string Model { get; set; }

        public string Color { get; set; }

        public int Horsepower { get; set; }


        public Truck(string model, string color, int horsePower)
        {
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsePower;
        }
    }
}
