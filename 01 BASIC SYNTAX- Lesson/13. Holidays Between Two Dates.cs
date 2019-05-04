using System;

namespace _13.Holidays_Between_Two_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            DateTime startDate = DateTime.Parse(input1);
            DateTime endtDate = DateTime.Parse(input2);
            double count = 0;

            for(DateTime i=startDate; i<=endtDate; )
            {
                if(i.ToString("dddd")=="Saturday" || i.ToString("dddd") == "Sunday")
                {
                    count++;
                }

               i= i.AddDays(1);
            }

            Console.WriteLine(count);
        }
    }
}
