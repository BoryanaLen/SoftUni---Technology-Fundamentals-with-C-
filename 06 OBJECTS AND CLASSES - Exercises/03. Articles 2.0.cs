using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            for (int i = 0; i < number; i++)
            {
                List<string> articleElements = Console.ReadLine().Split(", ").ToList();

                Article createdArticle = new Article(articleElements[0], articleElements[1], articleElements[2]);

                articles.Add(createdArticle);
            }

            string order = Console.ReadLine();

            List<Article> orderedArticles = new List<Article>();

            switch (order)
            {
                case "title": orderedArticles = articles.OrderBy(sortBy => sortBy.Title).ToList(); break;
                case "content": orderedArticles = articles.OrderBy(sortBy => sortBy.Content).ToList(); break;
                case "author": orderedArticles = articles.OrderBy(sortBy => sortBy.Author).ToList(); break;
            }

            foreach(Article art in orderedArticles)
            {
                Console.WriteLine(art.ToString());
            }
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


        override public string ToString()
        {
            string result = this.Title + " - " + this.Content + ": " + this.Author;

            return result;
        }
    }
}

