using System;
using System.Text.RegularExpressions;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\@|\#)+([a-z]{3,})(\@|\#)+([^a-zA-Z0-9]*)/+(\d+)/+";
            string input = Console.ReadLine();
            MatchCollection matchedEggs = Regex.Matches(input, pattern);

            foreach (Match egg in matchedEggs)
            {
                Console.WriteLine($"You found {egg.Groups[5].Value} {egg.Groups[2].Value} eggs!");
            }

        }
    }
}
