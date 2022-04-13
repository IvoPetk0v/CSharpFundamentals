using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> newlist = Console.ReadLine()
                  .Split(" ")
                  .Select(int.Parse)
                  .ToList();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int element = 0;
                if (commands.Length == 2)
                {
                    element = int.Parse(commands[1]);
                    newlist.RemoveAll(n => n == element);
                }
                else
                {
                    element = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                    newlist.Insert(index, element);
                }
            }
            Console.WriteLine(string.Join(" ", newlist));
        }
    }
}
