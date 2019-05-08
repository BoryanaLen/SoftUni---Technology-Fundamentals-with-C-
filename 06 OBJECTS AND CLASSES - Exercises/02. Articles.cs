using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> articleElements = Console.ReadLine().Split(", ").ToList();

            Article createdArticle = new Article(articleElements[0], articleElements[1], articleElements[2]);

            int number = int.Parse(Console.ReadLine());

            for(int i =0; i<number; i++)
            {
                List<string> command = Console.ReadLine().Split(": ").ToList();

                switch (command[0])
                {
                    case "Edit": createdArticle.Edit(command[1]); break;
                    case "ChangeAuthor": createdArticle.ChangeAuthor(command[1]); break;
                    case "Rename": createdArticle.Rename(command[1]); break;
                }
            }

            Console.WriteLine(createdArticle.ToString());
        }
    }

    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public void Edit(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            this.Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            this.Title = newTitle;
        }

        override public string ToString()
        {
            string result = this.Title + " - " + this.Content + ": " + this.Author;

            return result;
        }
    }
}
