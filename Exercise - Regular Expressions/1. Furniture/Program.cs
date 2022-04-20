using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _1._Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[>]{2}(?<product>[A-z]+[a-z]*)[<]{2}(?<price>\d+(\.\d+)?)\!(?<quantity>\d+)";
            string input;
            List<string> furniture = new List<string>();
            double moneySpend = 0.0;
            while ((input = Console.ReadLine()) != "Purchase")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    string name = match.Groups["product"].Value;
                    furniture.Add(name);
                    double currPrice = double.Parse(match.Groups["price"].Value);
                    double currQuantity = double.Parse(match.Groups["quantity"].Value);
                    moneySpend += currPrice * currQuantity;
                }
            }
            Console.WriteLine("Bought furniture: ");
            if (furniture.Count >= 1)
            {
                Console.WriteLine(String.Join(Environment.NewLine, furniture));
            }
            Console.WriteLine($"Total money spend: {moneySpend:f2}");
        }
    }
}
