using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> parkingList = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine()
                .Split(" ")
                .ToArray();
                if (commands[0] == "register")
                {
                    if (!parkingList.ContainsKey(commands[1]))
                    {
                        parkingList.Add(commands[1], commands[2]);
                        Console.WriteLine($"{commands[1]} registered {commands[2]} successfully");
                    }
                    else
                    {
                        foreach (var item in parkingList)
                        {
                            if (item.Key == commands[1])
                            {
                                Console.WriteLine($"ERROR: already registered with plate number {item.Value}");
                            }
                        }
                    }
                }
                else
                {
                    if (!parkingList.ContainsKey(commands[1]))
                    {
                        Console.WriteLine($"ERROR: user {commands[1]} not found");
                    }
                    else
                    {
                        parkingList.Remove(commands[1]);
                        Console.WriteLine($"{commands[1]} unregistered successfully");
                    }
                }
            }
            foreach (var item in parkingList)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
