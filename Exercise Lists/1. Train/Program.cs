using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Train
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> wagons = Console.ReadLine()
                            .Split(" ")
                            .Select(int.Parse)
                            .ToList();
            int capacityWagons = int.Parse(Console.ReadLine());
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int passengers;
                if (command.Length == 1)
                {

                    passengers = int.Parse(command[0]);
                    FindPlaceForNewPassenger(wagons, capacityWagons, passengers);
                }
                else
                {
                    passengers = int.Parse(command[1]);
                    wagons.Add(passengers);
                }
            }
            Console.WriteLine(String.Join(" ", wagons));
        }
        static void FindPlaceForNewPassenger(List<int> wagons, int capacityWagons, int passengers)
        {
            for (int i = 0; i < wagons.Count; i++)
            {
                int freeSeats = capacityWagons - wagons[i];
                if (passengers <= freeSeats)
                {
                    wagons[i] += passengers;
                    break;
                }
            }
            return;
        }
    }
}
