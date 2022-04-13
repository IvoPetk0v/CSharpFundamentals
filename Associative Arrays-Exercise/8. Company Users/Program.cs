using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyStaff = new Dictionary<string, List<string>>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] array = input
                .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                List<string> currentList = new List<string>();
                if (!companyStaff.ContainsKey(array[0]))
                {
                    currentList.Add(array[1]);
                    companyStaff.Add(array[0], currentList);
                }
                else
                {
                    if (!companyStaff[array[0]].Contains(array[1]))
                    {
                        companyStaff[array[0]].Add(array[1]);
                    }
                }
            }
            foreach (var item in companyStaff)
            {
                Console.WriteLine($"{item.Key}");
                foreach (string student in item.Value)
                {
                    string newString = student.Insert(0, "-- ");
                    Console.WriteLine(newString);
                }

            }
        }
    }
}