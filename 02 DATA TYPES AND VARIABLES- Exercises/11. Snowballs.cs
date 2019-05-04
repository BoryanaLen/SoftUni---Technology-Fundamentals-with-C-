using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberSnowBalls = int.Parse(Console.ReadLine());
            BigInteger maxValue = new BigInteger (-1);
            int maxSnow = 0;
            int maxTime = 0;
            int maxQuality = 0;

            for(int i=0; i < numberSnowBalls; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger value = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
 
                if (value > maxValue)
                {
                    maxValue = value;
                    maxSnow = snowballSnow;
                    maxTime = snowballTime;
                    maxQuality = snowballQuality;
                }
            }

            Console.WriteLine($"{maxSnow} : {maxTime} = {maxValue} ({maxQuality})");
        }
    }
}
