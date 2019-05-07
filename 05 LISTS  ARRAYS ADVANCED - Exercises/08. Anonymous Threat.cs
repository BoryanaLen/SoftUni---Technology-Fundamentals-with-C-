using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split(' ').ToList();

            while (true)
            {
                List<string> commands = Console.ReadLine().Split(' ').ToList();

                if(commands[0] == "3:1")
                {
                    Console.WriteLine(string.Join(' ', text));

                    break;
                }

                if (commands[0] == "merge")
                {
                    int start = int.Parse(commands[1]);
                    int end = int.Parse(commands[2]);

                    if(start > (text.Count - 1) || end <= 0)
                    {
                       continue;
                    }

                    if (end > (text.Count - 1))
                    {
                        end = text.Count - 1;
                    }

                    if(start < 0)
                    {
                        start = 0;
                    }

                    for (int i = start + 1; i <= end; i++)
                    {
                        text[start] = text[start] + (text[i]);
                    }

                    int count = 0;

                    while(true)
                    {
                        if(count == (end - start))
                        {
                            break;
                        }

                        text.RemoveAt(start+1);
                        count++;
                    }
                }
                else if (commands[0] == "divide")
                {
                    int positionForDivide = int.Parse(commands[1]);
                    int length = text[positionForDivide].Length;
                    int divide = int.Parse(commands[2]);
                    string textForDivide = text[positionForDivide];
                    string output = string.Empty;
                    int count = 0;

                    if(positionForDivide >(text.Count - 1))
                    {
                        continue;
                    }

                    if (divide <= 0 || divide > length)
                    {
                        continue;
                    }

                    if (length % divide == 0)
                    {
                        text.RemoveAt(positionForDivide);

                        foreach(char ch in textForDivide)
                        {
                            output += ch;
                            count++;

                            if (count == length / divide)
                            {
                                text.Insert(positionForDivide, output);
                                positionForDivide++;
                                output = string.Empty;
                                count = 0;
                            }
                        }                        
                    }
                    else
                    {
                        text.RemoveAt(positionForDivide);
                        int countEqualStrings = 0;
                        int rest = length % divide;
                        int lastcount = length / divide + rest;

                        foreach (char ch in textForDivide)
                        {
                            output += ch;
                            count++;

                            if (count == length / divide && countEqualStrings <= (divide-2))
                            {
                                text.Insert(positionForDivide, output);
                                positionForDivide++;
                                output = string.Empty;
                                count = 0;
                                countEqualStrings++;
                            }

                            if(countEqualStrings == (divide-1) && count == lastcount)
                            {
                                text.Insert(positionForDivide, output);
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
