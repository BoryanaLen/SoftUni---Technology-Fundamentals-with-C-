using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> path = Console.ReadLine().Split('\\').ToList();

            List<string> fileName = path[path.Count - 1].Split('.').ToList();

            Console.WriteLine($"File name: {fileName[0]}");
            Console.WriteLine($"File extension: {fileName[1]}");
        }
    }
}
