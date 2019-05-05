using System;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int[] result = new int[number];

            string vowel = "aeiouAEIOU";
            int index = 0;

            for (int i=0; i<number; i++)
            {
                int sum = 0;

                string input = Console.ReadLine();

                foreach(char ch in input)
                {
                    if (vowel.IndexOf(ch)>=0)
                    {
                        sum += ch * input.Length;
                    }
                    else
                    {
                        sum += ch / input.Length;
                    }
                }

                result[index] = sum;

                index++;
            }

            int minValue = int.MaxValue;

            for(int a=0; a<result.Length; a++)
            {
                for(int b = a+1; b<result.Length; b++)
                {
                    if (result[a] > result[b])
                    {
                        minValue = result[b];
                        result[b] = result[a];
                        result[a] = minValue;
                     }
                }
            }

            for(int k=0; k<result.Length; k++)
            {
                Console.WriteLine(result[k]);
            }
        }
    }
}
