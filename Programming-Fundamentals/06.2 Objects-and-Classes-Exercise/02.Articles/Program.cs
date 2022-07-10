using System;
using System.Linq;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] articleProperties = Console.ReadLine().Split(", ").ToArray();

            Article article = new Article(articleProperties[0], articleProperties[1], articleProperties[2]);

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] tokens = Console.ReadLine().Split(": ");

                string command = tokens[0];

                switch (command)
                {
                    case"Edit":
                        article.Edit(tokens[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(tokens[1]);
                        break;
                    case "Rename":
                        article.Rename(tokens[1]);
                        break;
                }
            }

            Console.WriteLine(article);
        }
    }

    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string content) => this.Content = content;
        public void ChangeAuthor(string author) => this.Author = author;
        public void Rename(string title) => this.Title = title;
        public override string ToString() => $"{this.Title} - {this.Content}: {this.Author}";
    }
}
