using System;
using System.Text.RegularExpressions;

namespace Problem_2___Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"(\@\#+)(?<barcode>[A-Z][A-Za-z\d]{4,}[A-Z])\@\#+";
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);
                if (!match.Success)
                {
                    Console.WriteLine("Invalid barcode");
                    continue;
                }
                string barcode = match.Groups["barcode"].Value;
                string group = null;
                foreach (char ch in barcode)
                {
                    if (char.IsDigit(ch))
                    {
                        group += ch;
                    }
                }
                if (group == null)
                {
                    group = "00";
                }
                Console.WriteLine($"Product group: {group}");
            }
        }
    }
}
