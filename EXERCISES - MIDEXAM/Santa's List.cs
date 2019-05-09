using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Santa_s_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine().Split('&').ToList();

            while (true)
            {
                string input = Console.ReadLine();

                if(input == "Finished!")
                {
                    Console.WriteLine(string.Join(", ", names));
                    break;
                }

                List<string> commandInfo = input.Split(' ').ToList();

                string command = commandInfo[0];
                string name = commandInfo[1];

                if (command == "Bad")
                {
                    if(!IsKidExist(name, names))
                    {
                        names.Insert(0, name);
                    }
                }
                else if(command == "Good")
                {
                    if (IsKidExist(name, names))
                    {
                        names.Remove(name);
                    }
                }
                else if (command == "Rename")   
                {
                    string newName = commandInfo[2];

                    if (IsKidExist(name, names))
                    {
                        for(int i=0; i<names.Count; i++)
                        {
                            if(names[i] == name)
                            {
                                names[i] = newName;
                            }
                        }
                    }
                }
                else if (command == "Rearrange")
                {
                    if (IsKidExist(name, names))
                    {
                        names.Remove(name);
                        names.Add(name);
                    }
                }
            }
        }

        static bool IsKidExist(string name, List<string> names)
        {
            bool result = false;

            foreach(string kid in names)
            {
                if(kid == name)
                {
                    result = true;
                }
            }

            return result;
        }
    }
}
