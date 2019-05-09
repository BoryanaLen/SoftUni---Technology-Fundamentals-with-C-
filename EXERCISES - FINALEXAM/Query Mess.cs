using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _01.Regex___07._Query_Mess
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();

                if(input == "END")
                {
                    break;
                }

                Dictionary<string, List<string>> keys = new Dictionary<string, List<string>>();

                StringBuilder sb = new StringBuilder();

                if (input.IndexOf('?') >= 0)
                {
                    int position = input.IndexOf('?');
                    input = input.Substring(position + 1);
                }

                sb.Append(input);
                sb.Replace('+', ' ');
                sb.Replace("%20", " ");
                //sb.Replace(" ", "");

                string series = sb.ToString();

                List<string> SeriesInfo = series.Split('&').ToList();

                for (int i = 0; i < SeriesInfo.Count; i++)
                {
                    List<string> current = SeriesInfo[i].Split('=').ToList();

                    string key = Regex.Replace(current[0], @"\s+", " ").Trim();

                    string value = Regex.Replace(current[1], @"\s+", " ").Trim();

                    if (keys.ContainsKey(key))
                    {
                        keys[key].Add(value);
                    }
                    else
                    {
                        keys.Add(key, new List<string>() { value });
                    }
                }

                foreach(var kvp in keys)
                {
                    Console.Write($"{kvp.Key}=[{string.Join(", ", kvp.Value)}]");
                }

                Console.WriteLine();
            }
        }
    }
}
