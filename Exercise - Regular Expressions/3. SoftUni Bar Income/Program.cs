using System;
using System.Text.RegularExpressions;

namespace _3._SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = 0.0;
            string pattern = @"%([A-Z]{1}[a-z]+)%[^%$|.]*?<(\w+)\>[^%$|.]*?\|(\d+)\|[^%$|.]*?(\d+(\.\d+)?)\$";
            string input;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match match = Regex.Match(input, pattern);
                if (match.Success)
                {
                    //"{customerName}: {product} - {totalPrice}"
                    string customerName = match.Groups[1].ToString();
                    string product = match.Groups[2].ToString();
                    int quantity = int.Parse(match.Groups[3].ToString());
                    double price = double.Parse(match.Groups[4].ToString());
                    income += quantity * price;
                    Console.WriteLine($"{customerName}: {product} - {quantity * price:f2}");
                }
            }
            Console.WriteLine($"Total income: {income:f2}");
        }
    }
}
