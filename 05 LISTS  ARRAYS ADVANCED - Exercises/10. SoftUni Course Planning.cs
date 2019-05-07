using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> courseSchedule = Console.ReadLine().Split(", ").ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if(command == "course start")
                {
                    for(int i =1; i<=courseSchedule.Count; i++)
                    {
                        Console.WriteLine($"{i}.{courseSchedule[i-1]}");
                    }

                    break;
                }

                List<string> commands = command.Split(':').ToList();

                string exercise = string.Empty;
                exercise += commands[1];
                exercise += "-Exercise";

                if (commands[0] == "Add")
                {
                    int count = 0;

                    foreach(string schedule in courseSchedule)
                    {
                        if(schedule == commands[1])
                        {
                            count++;
                        }
                    }

                    if(count == 0)
                    {
                        courseSchedule.Add(commands[1]);
                    }
                }
                else if (commands[0] == "Insert")
                {
                    int index = int.Parse(commands[2]);

                    if(index >=0 && index <= (courseSchedule.Count - 1))
                    {
                        int count = 0;

                        foreach (string schedule in courseSchedule)
                        {
                            if (schedule == commands[1])
                            {
                                count++;
                            }
                        }

                        if (count == 0)
                        {
                            courseSchedule.Insert(index, commands[1]);
                        }
                    }
                }
                else if (commands[0] == "Remove")
                {
                    int indexExist = -1;

                    for(int i =0; i<courseSchedule.Count; i++)
                    {
                        if(courseSchedule[i] == commands[1])
                        {                          
                            indexExist = i;

                            if (i < courseSchedule.Count-1) 
                            {
                                if(courseSchedule[i + 1] == exercise)
                                {
                                    courseSchedule.RemoveRange(indexExist, 2);
                                }
                                else
                                {
                                    courseSchedule.RemoveAt(i);
                                }
                            }
                            else
                            {
                                courseSchedule.RemoveAt(i);
                            }                           
                        }
                    }

                    if (indexExist >= 0)
                    {
                        
                    }
                }
                else if (commands[0] == "Swap")
                {
                    string exerciseOne = commands[1] + "-Exercise";
                    string exerciseTwo = commands[2] + "-Exercise";
                    int countOne = 0;
                    int countTwo = 0;
                    int indexOne = -1;
                    int indexTwo = -1;

                    for (int i = 0; i < courseSchedule.Count; i++)
                    {
                        if (courseSchedule[i] == commands[1])
                        {
                            countOne++;
                            indexOne = i;
                        }
                    }

                    for (int j = 0; j < courseSchedule.Count; j++)
                    {
                        if (courseSchedule[j] == commands[2])
                        {
                            countTwo++;
                            indexTwo = j;
                        }
                    }

                    if(countOne > 0 && countTwo > 0)
                    {
                        string schedule = courseSchedule[indexOne];
                        courseSchedule[indexOne] = courseSchedule[indexTwo];
                        courseSchedule[indexTwo] = schedule;
                    }

                    if(indexOne < courseSchedule.Count - 1)
                    {
                        if (courseSchedule[indexOne + 1] == exerciseOne)
                        {
                            courseSchedule.Insert(indexTwo + 1, exerciseOne);
                            courseSchedule.RemoveAt(indexOne + 1);
                        }
                    }

                    if (indexTwo < courseSchedule.Count - 1)
                    {
                        if (indexTwo != courseSchedule.Count - 1 && courseSchedule[indexTwo + 1] == exerciseTwo)
                        {
                            courseSchedule.Insert(indexOne + 1, exerciseTwo);
                            courseSchedule.RemoveAt(indexTwo + 2);
                        }
                    }                      
                }
                else if (commands[0] == "Exercise")
                {
                    int countExists = 0;
                    int indexExist = -1;
 
                    for (int i = 0; i < courseSchedule.Count; i++)
                    {
                        if (courseSchedule[i] == commands[1])
                        {
                            countExists++;
                            indexExist = i;
                        }
                    }

                    if(countExists == 0)
                    {
                        courseSchedule.Add(commands[1]);
                        courseSchedule.Add(exercise);
                    }
                    else if(indexExist == (courseSchedule.Count - 1))
                    {
                        courseSchedule.Add(exercise);
                    }
                    else if (countExists > 0)
                    {
                        if(courseSchedule[indexExist+1] != exercise)
                        {
                            courseSchedule.Insert(indexExist + 1, exercise);
                        }
                    }
                }
            }
        }
    }
}
