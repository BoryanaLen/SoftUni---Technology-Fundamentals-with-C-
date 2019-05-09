using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06._Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> tickets = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> symbols = new List<string>() { "@", "#", "$", @"\^" };

            //string pattern = @"([\@]{6,10})?([\$]{6,10})?([\^]{6,10})?([\#]{6,10})?";

            foreach (string ticketList in tickets)
            {
                string ticket = ticketList.Trim();

                if(ticket.Length == 20)
                {
                    string leftHalf = ticket.Substring(0, 10);
                    string rightHalf = ticket.Substring(10, 10);
                    int countMatch = 0;

                    for (int i = 0; i < symbols.Count; i++)
                    {
                        string currentPattern = $@"[{symbols[i]}]+";
                        int countLeft = 0;
                        int countRight = 0;

                        if (Regex.IsMatch(leftHalf, currentPattern) && Regex.IsMatch(leftHalf, currentPattern))
                        {
                            countLeft = Regex.Match(leftHalf, currentPattern).Value.Length;
                            countRight = Regex.Match(rightHalf, currentPattern).Value.Length;
                            int count = Math.Min(countLeft, countRight);

                            if (count >= 6 && count < 10)
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {count}{leftHalf[4]}");
                                countMatch++;
                                break;
                            }
                            else if (count == 10)
                            {
                                Console.WriteLine($"ticket \"{ticket}\" - {count}{leftHalf[4]} Jackpot!");
                                countMatch++;
                                break;
                            }
                        }
                    }

                    if(countMatch == 0)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                } 
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
