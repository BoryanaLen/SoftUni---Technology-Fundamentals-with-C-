using System;

namespace _01._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if(input == "END")
                {
                    break;
                }

                if(int.TryParse(input, out int resultInt))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if(double.TryParse(input, out double resultDouble))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (bool.TryParse(input, out bool resultBool))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else if (input.Length == 1)
                {
                    Console.WriteLine($"{input} is character type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
            }
        }
    }
}
