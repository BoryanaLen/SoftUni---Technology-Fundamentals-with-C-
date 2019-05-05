using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] arrayOne = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] arrayTwo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sum = 0;
            int count = 0;

            for (int i = 0; i < arrayOne.Length; i++)
            {
                if(arrayOne[i] == arrayTwo[i])
                {
                    sum += arrayOne[i];
                    count++;
                }
                else
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
            }

            if (count == (arrayOne.Length))
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}
