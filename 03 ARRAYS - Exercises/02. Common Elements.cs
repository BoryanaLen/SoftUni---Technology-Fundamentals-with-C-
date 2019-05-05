using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] inputArray1 = Console.ReadLine().Split(' ').ToArray();
            string [] inputArray2 = Console.ReadLine().Split(' ').ToArray();

            for(int i =0; i< inputArray2.Length; i++)
            {
                for(int j=0; j<inputArray1.Length; j++)
                {
                    if(inputArray2[i] == inputArray1[j])
                    {
                        Console.Write($"{inputArray2[i]} ");
                    }
                }
            }
        }
    }
}
