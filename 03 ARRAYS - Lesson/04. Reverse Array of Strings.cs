using System;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string[] arrayOne = input.Split(' ');

            for(int i= (arrayOne.Length-1); i>=0; i--)
            {
                Console.Write($"{arrayOne[i]} ");
            }
        }
    }
}
