using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Problem_2._2___Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\||\#)([A-Za-z\s]+)\1(\d{2}/\d{2}/\d{2})\1([0-9]{1,5})\1";
            string input = Console.ReadLine();
            List<Food> foodReserve = new List<Food>();
            MatchCollection matches = Regex.Matches(input, pattern);
            int totalCalories = 0;
            const int dailyCaloryNeeds = 2000;
            foreach (Match item in matches)
            {
                string name = item.Groups[2].ToString();
                string date = item.Groups[3].ToString();
                int nutry = int.Parse(item.Groups[4].ToString());
                if (nutry>10000)
                {
                    continue;
                }
                totalCalories += nutry;
                Food newfood = new Food(name, date, nutry);
                foodReserve.Add(newfood);
            }
            int days = totalCalories / dailyCaloryNeeds;
            Console.WriteLine($"You have food to last you for: {days} days!");
            Console.WriteLine(string.Join(Environment.NewLine, foodReserve));
        }
    }
    public class Food
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public int Nutrition { get; set; }
        public Food(string name, string date, int nutry)
        {
            Name = name;
            Date = date;
            Nutrition = nutry;
        }
        public override string ToString()
        {
            return $"Item: {this.Name}, Best before: {this.Date}, Nutrition: {this.Nutrition}";
        }
    }
}
