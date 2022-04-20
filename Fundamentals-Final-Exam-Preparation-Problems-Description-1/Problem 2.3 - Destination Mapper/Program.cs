using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem_2._3___Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\=|\/)([A-Z][A-Za-z]{2,})\1";
            string input = Console.ReadLine();
            int travelPoints = 0;
            MatchCollection matches = Regex.Matches(input, pattern);
            List<string> destinations = new List<string>();
            foreach (Match item in matches)
            {
                destinations.Add(item.Groups[2].ToString());
                travelPoints += item.Groups[2].ToString().Length;
            }
            Console.Write("Destinations: ");
            Console.WriteLine(string.Join(", ", destinations));
            Console.WriteLine($"Travel Points: {travelPoints}");
        }
    }
}
