using System;
using System.Globalization;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime inpytDate = DateTime.ParseExact(Console.ReadLine(), "d-MM-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(inpytDate.DayOfWeek);
        }
    }
}
