using System;
using System.Collections.Generic;

namespace _05._HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = Console.ReadLine();
            string content = Console.ReadLine();
            List<string> comments = new List<string>();

            while (true)
            {
                string comment = Console.ReadLine();

                if(comment == "end of comments")
                {
                    break;
                }

                comments.Add(comment);
            }

            Console.WriteLine("<h1>");
            Console.WriteLine($"    {title}");
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine($"    {content}");
            Console.WriteLine("</article>");

            foreach(string com in comments)
            {
                Console.WriteLine("<div>");
                Console.WriteLine($"    {com}");
                Console.WriteLine("</div>");
            }
        }
    }
}
