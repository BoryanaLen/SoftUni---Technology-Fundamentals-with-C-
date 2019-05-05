using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for(int i = 0; i<inputArray.Length; i++)
            {
                int count = 0;

                if (i == (inputArray.Length - 1))
                {
                    Console.Write(inputArray[i]);
                    break;
                }

                for(int j = i+1; j<inputArray.Length; j++)
                {
                    if(inputArray[i] > inputArray[j])
                    {
                        count++;
                    }
                }
     
                if(count == (inputArray.Length-i -1))
                {
                    Console.Write($"{inputArray[i]} ");
                }
            }
        }
    }
}
