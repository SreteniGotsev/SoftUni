using System;


namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] token = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(Console.ReadLine());

            Article article = new Article(token[0],token[1],token[2]);

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string comand = input[0];
                string argument = input[1];

                switch (comand)
                {
                    case "Edit":
                        article.Edit(argument);
                        break;

                    case "ChangeAuthor":
                        article.ChangeAuthor(argument);
                        break;

                    case "Rename":
                        article.Rename(argument);
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine(article.ToString());

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

        public void Edit(string argument)
        {
            Content = argument;
        }
        public void ChangeAuthor(string argument)
        {
            Author = argument;
        }
        public void Rename(string argument)
        {
            Title = argument;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}"; 
        }
    }
}
