using System;
using System.Linq;

namespace _2._Articles
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] propsOfArticle = Console.ReadLine()
                .Split(", ")
                .ToArray();
            Article newArticle = new Article(propsOfArticle);
            int numOfCommand = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfCommand; i++)
            {
                string input = Console.ReadLine();
                string[] commands = input.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                if (commands[0] == "Edit")
                {
                    newArticle.Edit(commands);
                }
                else if (commands[0] == "ChangeAuthor")
                {
                    newArticle.ChangeAuthor(commands);
                }
                else if (commands[0] == "Rename")
                {
                    newArticle.Rename(commands);
                }
            }
            Console.WriteLine(newArticle);
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
        public string Edit(string[] newContent)
        {
            return this.Content = newContent[1];
        }
        public string ChangeAuthor(string[] newAuthor)
        {
            return this.Author = newAuthor[1];
        }
        public string Rename(string[] newTitle)
        {
            return this.Title = newTitle[1];
        }
        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";

        }
    }
}
