using System;
using System.Linq;

namespace _04__Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string revresed = new string(input.Reverse().ToArray());

            Console.WriteLine(revresed);
        }
    }
}
