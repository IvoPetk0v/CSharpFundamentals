using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<double> currentList = new List<double>();
            Dictionary<string, List<double>> orders = new Dictionary<string, List<double>>();
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] array = input
                .Split(" ")
                .ToArray();
                List<double> inputList = new List<double> { double.Parse(array[1]), double.Parse(array[2]) };
                if (!orders.ContainsKey(array[0]))
                {
                    orders.Add(array[0], inputList);
                }
                else
                {
                    currentList = orders[array[0]];
                    currentList[0] = inputList[0];
                    currentList[1] += inputList[1];
                    orders[array[0]] = currentList;
                }
            }
            foreach (var item in orders)
            {
                currentList = item.Value;
                double total = currentList[0] * currentList[1];
                Console.WriteLine($"{item.Key} -> {total:F2}");
            }
        }
    }
}
