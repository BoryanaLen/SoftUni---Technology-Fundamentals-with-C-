using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());
            string typeGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double totalPrice = 0;

            if(typeGroup== "Students")
            {
                if(day== "Friday")
                {
                    totalPrice = numberPeople * 8.45;
                }
                else if (day == "Saturday")
                {
                    totalPrice = numberPeople * 9.8;
                }
                else if (day == "Sunday")
                {
                    totalPrice = numberPeople * 10.46;
                }

                if (numberPeople >= 30)
                {
                    totalPrice = totalPrice * 0.85;
                }
            }
            else if (typeGroup == "Business")
            {
                if (day == "Friday")
                {
                    totalPrice = numberPeople * 10.9;

                    if (numberPeople >= 100)
                    {
                        totalPrice -= 109;
                }
                }
                else if (day == "Saturday")
                {
                    totalPrice = numberPeople * 15.6;

                    if (numberPeople >= 100)
                    {
                        totalPrice -= 156;
                }
                }
                else if (day == "Sunday")
                {
                    totalPrice = numberPeople * 16;

                    if (numberPeople >= 100)
                    {
                        totalPrice -= 160;
                    }
                }
            }
            else if (typeGroup == "Regular")
            {
                if (day == "Friday")
                {
                    totalPrice = numberPeople * 15;
                }
                else if (day == "Saturday")
                {
                    totalPrice = numberPeople * 20;
                }
                else if (day == "Sunday")
                {
                    totalPrice = numberPeople * 22.5;
                }

                if(numberPeople>=10 & numberPeople <= 20)
                {
                    totalPrice = totalPrice * 0.95;
                }
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
