using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Speed_Racing
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
                double fuelAmount = double.Parse(personInfo[1]);
                double fuelConsumation = double.Parse(personInfo[2]);

                Car newCar = new Car(model, fuelAmount, fuelConsumation);

                cars.Add(newCar);
            }

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "End")
                {
                    break;
                }

                List<string> command = input.Split(' ').ToList();

                string model = command[1];
                double km = double.Parse(command[2]);
                int position = -1;

                for (int i = 0; i < cars.Count; i++)
                {
                    if(cars[i].Model == model)
                    {
                        position = i;
                    }
                }

                if (cars[position].IfCarCanMove(km))
                {
                    cars[position].TraveledDistance += km;

                    cars[position].FuelAmount -= cars[position].FuelConsumption * km;
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }

            foreach(Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TraveledDistance}");
            }
        }
    }

    class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumption { get; set; }
        public double TraveledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumation)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumption = fuelConsumation;
            this.TraveledDistance = 0;
        }

        public bool IfCarCanMove(double kilometersForRun)
        {
            bool result = false;

            double possibleKM = this.FuelAmount / this.FuelConsumption;

            if (possibleKM >= kilometersForRun)
            {
                result = true;
            }

            return result;
        }
    }
}
