using System;
using System.Linq;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = new string(username.Reverse().ToArray());
            string input;
            int count = 0;

            for(int i =0; i<4; i++)
            {
                input = Console.ReadLine();

                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }

                if (count == 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }

                    Console.WriteLine($"Incorrect password. Try again.");
                    count += 1;
            }
        }
    }
}
