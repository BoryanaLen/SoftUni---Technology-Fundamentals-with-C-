using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int sum = 0;

            while (true)
            {
                if (numbers.Length == 1)
                {
                    sum = numbers[0];
                    Console.WriteLine(sum);
                    break;
                }

                int[] newArray = new int[numbers.Length - 1];

                for (int i = 1; i < numbers.Length; i++)
                {                     
                    newArray[i - 1] = numbers[i-1] + numbers[i];
                }

                if(newArray.Length == 2)
                {
                    sum = newArray[0] + newArray[1];
                    Console.WriteLine(sum);
                    break;
                }

                numbers = newArray;
            }         
        }
    }
}
