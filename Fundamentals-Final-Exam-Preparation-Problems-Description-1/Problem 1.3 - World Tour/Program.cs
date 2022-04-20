using System;
using System.Linq;

namespace Problem_1._3___World_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "Travel")
            {
                string[] cmdsArgs = input
                .Split(":")
                .ToArray();
                if (cmdsArgs[0] == "Add Stop")
                {
                    int index = int.Parse(cmdsArgs[1]);
                    string substring = cmdsArgs[2];
                    if (IsIndexValid(index, stops))
                    {
                        stops = stops.Insert(index, substring);
                    }
                    Console.WriteLine(stops);
                }
                else if (cmdsArgs[0] == "Remove Stop")
                {
                    int startIndex = int.Parse(cmdsArgs[1]);
                    int endIndex = int.Parse(cmdsArgs[2]);
                    if (IsIndexValid(startIndex, stops) && IsIndexValid(endIndex, stops))
                    {
                        stops = stops.Remove(startIndex, endIndex - startIndex + 1);
                    }
                    Console.WriteLine(stops);
                }
                else if (cmdsArgs[0] == "Switch")
                {
                    string oldString = cmdsArgs[1];
                    string newString = cmdsArgs[2];
                    if (stops.Contains(oldString))
                    {
                        stops = stops.Replace(oldString, newString);

                    }
                    Console.WriteLine(stops);
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }

        static bool IsIndexValid(int index, string stops)
        {
            if (index >= 0 && index < stops.Length)
            {
                return true;
            }
            return false;
        }
    }
}
