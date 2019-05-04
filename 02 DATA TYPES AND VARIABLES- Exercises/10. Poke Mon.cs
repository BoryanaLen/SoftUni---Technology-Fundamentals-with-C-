using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int count = 0;
            int restPower = power;

            while (true)
            {
                if (restPower == power / 2 && exhaustionFactor!=0)
                {
                   restPower = restPower / exhaustionFactor;
                }

                if (restPower < distance)
                {
                    break;
                }

                restPower -= distance;
                count++;
            }

            Console.WriteLine(restPower);
            Console.WriteLine(count);
        }
    }
}
