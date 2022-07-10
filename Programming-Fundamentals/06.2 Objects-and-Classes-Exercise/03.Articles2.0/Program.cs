using System;
using System.Linq;
using System.Collections.Generic;


namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> listOfArticles = new List<Article>();

            int numberOfArticles = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfArticles; i++)
            {
                string[] articleProperties = Console.ReadLine().Split(", ").ToArray();

                Article article = new Article(articleProperties[0], articleProperties[1], articleProperties[2]);

                listOfArticles.Add(article);
            }

            foreach (var article in listOfArticles)
            {
                Console.WriteLine(article);
            }

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

        public override string ToString() => $"{this.Title} - {this.Content}: {this.Author}";
    }
}