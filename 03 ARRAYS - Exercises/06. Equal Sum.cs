using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int count = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                if(inputArray.Length==1 && inputArray[0] != 0)
                {
                    Console.WriteLine(i);
                    count++;
                    break;
                }

                int sumLeft = 0;
                int sumRight = 0;

                for (int a = 0; a<i; a++)
                {
                    sumLeft += inputArray[a];
                }

                for(int b= (i+1); b<inputArray.Length; b++)
                {
                    sumRight+= inputArray[b];
                }

                if (sumRight == sumLeft)
                {
                    Console.WriteLine(i);
                    count++;
                }
            }

            if (count == 0)
            {
                Console.WriteLine("no");
            }
        }
    }
}
