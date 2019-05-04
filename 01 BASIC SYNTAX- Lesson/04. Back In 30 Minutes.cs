using System;

namespace _04.Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int inputMinutes = int.Parse(Console.ReadLine());

            int minutes = inputMinutes + 30;

            if (minutes >= 60)
            {
                minutes -= 60;
                hours += 1;
            }

            if (hours >= 24)
            {
                hours -= 24;
            }

            Console.WriteLine($"{hours}:{minutes.ToString().PadLeft(2, '0')}");
        }
    }
}
