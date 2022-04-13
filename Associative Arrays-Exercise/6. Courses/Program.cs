using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> currentList = new List<string>();
                string[] array = input
                .Split(":")
                .ToArray();
                array[0] = array[0].TrimEnd();
                if (!courses.ContainsKey(array[0]))
                {
                    currentList.Add(array[1].Insert(0, "--"));
                    courses.Add(array[0], currentList);
                }
                else
                {
                    currentList = courses[array[0]];
                    currentList.Add(array[1].Insert(0, "--"));
                    courses[array[0]] = currentList;
                }
            }
            foreach (var item in courses)
            {
                List<string> currentList = item.Value;

                Console.WriteLine($"{item.Key}: {currentList.Count}");
                Console.WriteLine(String.Join(Environment.NewLine, currentList));
            }
        }
    }
}
