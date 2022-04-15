using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfArticles = int.Parse(Console.ReadLine());
            List<Article> listOfArticles = new List<Article>();
            for (int i = 0; i < numOfArticles; i++)
            {
                string[] propsOfArticle = Console.ReadLine()
                         .Split(", ")
                         .ToArray();
                Article newArticle = new Article(propsOfArticle);
                listOfArticles.Add(newArticle);
            }
            string input = Console.ReadLine();
            Console.WriteLine(String.Join(Environment.NewLine, listOfArticles));
        }

    }
    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string[] propsOfArticle)
        {
            Title = propsOfArticle[0];
            Content = propsOfArticle[1];
            Author = propsOfArticle[2];
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
}
