using System;

namespace _01._Data_Types
{
    class Program
    {
        static int IntMultiply2 (int number)
        {
            return number * 2;
        }

        static double RealmMltiply(double number)
        {
            return number * 1.5;

        }

        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string input = Console.ReadLine();

            if(command == "string")
            {
                Console.WriteLine($"${input}$");
            }
            else if(command == "int")
            {
                Console.WriteLine($"{IntMultiply2(int.Parse(input))}");
            }
            else if(command == "real")
            {
                Console.WriteLine($"{(RealmMltiply(double.Parse(input))):F2}");
            }
           
        }
    }
}
