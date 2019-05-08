using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Raw_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberLines = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberLines; i++)
            {
                List<string> personInfo = Console.ReadLine().Split(' ').ToList();

                string model = personInfo[0];
                int engineSpeed = int.Parse(personInfo[1]);
                int enginePower = int.Parse(personInfo[2]);
                int cargoWeight = int.Parse(personInfo[3]);
                string cargoType = personInfo[4];

                Car newCar = new Car(model);
                newCar.Engine.Speed = engineSpeed;
                newCar.Engine.Power = enginePower;
                newCar.Cargo.Weight = cargoWeight;
                newCar.Cargo.Type = cargoType;

                cars.Add(newCar);
            }

            string command = Console.ReadLine();

            if(command == "fragile")
            {
                foreach(Car car in cars)
                {
                    if(car.Cargo.Type == "fragile" && car.Cargo.Weight < 1000)
                    {
                        Console.WriteLine($"{car.Model}");
                    }
                }
            }
            else if(command == "flamable")
            {
                foreach (Car car in cars)
                {
                    if (car.Cargo.Type == "flamable" && car.Engine.Power > 250)
                    {
                        Console.WriteLine($"{car.Model}");
                    }
                }
            }
        }
    }

    class Car
    {
        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public Car(string model)
        {
            this.Model = model;
            Engine = new Engine();
            Cargo = new Cargo();
        }
    }

    class Cargo
    {
        public int Weight { get; set; }

        public string Type { get; set; }
    }

    class Engine
    {
        public int Speed { get; set; }

        public int Power { get; set; }
    }
}
