using System;

namespace _08._Town_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            uint population = uint.Parse(Console.ReadLine());
            int meters = int.Parse(Console.ReadLine());

            Console.WriteLine($"Town {town} has population of {population} and area {meters} square km.");
        }
    }
}
