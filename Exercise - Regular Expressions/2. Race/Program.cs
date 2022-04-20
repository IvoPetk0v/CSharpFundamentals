using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace wtf3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string namesOfRacers = Console.ReadLine();
            Dictionary<string, int> racers = new Dictionary<string, int>();
            string[] array = namesOfRacers
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                racers.Add(array[i], 0);
            }
            string input;
            string name = "[A-Z a-z]";
            string digits = @"[\d]";
            while ((input = Console.ReadLine()) != "end of race")
            {
                if (Regex.IsMatch(input, name))
                {
                    MatchCollection matchName = Regex.Matches(input, name);
                    string currentRacer = string.Join("", matchName);
                    foreach (var item in racers)
                    {
                        if (item.Key == currentRacer)
                        {
                            MatchCollection matchValue = Regex.Matches(input, digits);
                            racers[item.Key] += SumOfDigits(matchValue);
                            break;
                        }
                    }
                }
            }
            List<string> winners = new List<string>();
            foreach (var item in racers.OrderByDescending(value => value.Value))
            {
                if (item.Value > 0)
                {
                    winners.Add(item.Key);
                }

            }

            // winners.RemoveRange(3, winners.Count - 3);

            PrintResult(winners);


        }
        static int SumOfDigits(MatchCollection matchValue)
        {
            int sum = 0;
            foreach (Match item in matchValue)
            {
                sum += int.Parse(item.Value);
            }
            return sum;
        }
        static void PrintResult(List<string> orderedRacers)
        {
            Console.WriteLine($"1st place: {orderedRacers[0]}");
            Console.WriteLine($"2nd place: {orderedRacers[1]}");
            Console.WriteLine($"3rd place: {orderedRacers[2]}");
        }
    }
}