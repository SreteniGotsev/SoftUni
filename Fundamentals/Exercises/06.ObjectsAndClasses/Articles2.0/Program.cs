using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string title = input[0];
                string content = input[1];
                string author = input[2];


                Article article = new Article(title, content, author);

                articles.Add(article);


            }

            string comand = Console.ReadLine();

            switch (comand)
            {
                case "title":
                    articles = articles.OrderBy(a => a.Title).ToList();
                    break;

                case "content":
                    articles = articles.OrderBy(a => a.Content).ToList();
                    break;

                case "author":
                    articles = articles.OrderBy(a=> a.Author).ToList();
                    break;

                default:
                    break;
            }

            foreach (Article item in articles)
            {
                Console.WriteLine(item);
            }
        }
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;

        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}

