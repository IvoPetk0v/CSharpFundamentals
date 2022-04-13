using System;
using System.Collections.Generic;

namespace _2._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourses = new Dictionary<string, int>();
            string input;
            while ((input = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());
                if (!resourses.ContainsKey(input))
                {
                    resourses.Add(input, quantity);
                }
                else
                {
                    resourses[input] += quantity;
                }
            }
            foreach (var item in resourses)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
