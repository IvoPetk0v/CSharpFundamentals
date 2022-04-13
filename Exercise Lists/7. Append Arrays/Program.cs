using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] array = Console.ReadLine()
                 .Split("|", StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();

            List<int> newlist = new List<int>();
            for (int i = array.Length - 1; i >= 0; i--)
            {

                List<int> current = array[i]
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToList();
                newlist.AddRange(current);
            }

            Console.WriteLine(String.Join(" ", newlist));
        }
    }
}
