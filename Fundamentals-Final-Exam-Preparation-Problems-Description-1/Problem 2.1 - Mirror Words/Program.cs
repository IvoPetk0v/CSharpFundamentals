using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_2._1___Mirror_Words
{
    class Program
    {
        public static object Matches { get; private set; }

        static void Main(string[] args)
        {
            string pattern = @"(@|#)([A-Za-z]{3,})\1\1([A-Za-z]{3,})\1";
            string input = Console.ReadLine();
            Dictionary<string, string> mirrorString = new Dictionary<string, string>();
            MatchCollection matches = Regex.Matches(input, pattern);
            if (matches.Count <= 0)
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
                foreach (Match item in matches)
                {
                    string wordOne = item.Groups[2].Value;
                    string wordTwo = item.Groups[3].Value;
                    StringBuilder sb = new StringBuilder();
                    for (int i = wordTwo.Length - 1; i >= 0; i--)
                    {
                        sb.Append(wordTwo[i]);
                    }
                    if (wordOne == sb.ToString())
                    {
                        mirrorString[wordOne] = wordTwo;
                    }
                    sb.Clear();
                }
                if (mirrorString.Count > 0)
                {

                    Console.WriteLine("The mirror words are:");
                    List<string> pairsPrint = new List<string>();
                    foreach (var kvp in mirrorString)
                    {
                        pairsPrint.Add($"{kvp.Key} <=> {kvp.Value}");
                    }
                    Console.WriteLine(string.Join(", ", pairsPrint));
                }
                else
                {
                    Console.WriteLine("No mirror words!");
                }
            }
        }
    }
}
