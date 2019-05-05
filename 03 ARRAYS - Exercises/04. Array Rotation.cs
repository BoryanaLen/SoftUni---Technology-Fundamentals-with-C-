using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int number = int.Parse(Console.ReadLine());

            int count = 0;

            while(true)
            {
                if(count == number)
                {
                    break;
                }

                int current = inputArray[0];

                for (int i = 1; i <= inputArray.Length; i++)
                {
                    if(i == inputArray.Length)
                    {
                        inputArray[i-1] = current;
                        break;
                    }
                  
                    inputArray[i - 1] = inputArray[i];                  
                }

                count++;
            }

            for (int i = 0; i < inputArray.Length; i++)
            {
                Console.Write($"{inputArray[i]} ");
            }
        }
    }
}
