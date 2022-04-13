using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> word = new Dictionary<char, int>();
            string input = Console.ReadLine();


            foreach (var item in input)
            {
                if (item == ' ')
                {
                    continue;
                }
                if (!word.ContainsKey(item))
                {
                    word.Add(item, 1);
                }
                else
                {
                    word[item] += 1;
                }
            }
            foreach (var item in word)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
