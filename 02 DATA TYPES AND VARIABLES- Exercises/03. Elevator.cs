using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = numberPeople / capacity;

            if (numberPeople % capacity != 0)
            {
                courses += 1;
            }

            Console.WriteLine(courses);
        }
    }
}
