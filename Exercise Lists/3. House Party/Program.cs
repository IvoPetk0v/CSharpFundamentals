using System;
using System.Collections.Generic;
using System.Linq;


namespace _3._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandCount = int.Parse(Console.ReadLine());
            List<string> GuestList = new List<string>();
            for (int i = 0; i < commandCount; i++)
            {
                string[] command = Console.ReadLine()
                        .Split(" ")
                        .ToArray();
                string name = command[0];
                if (command.Length == 3)
                {
                    if (!GuestList.Contains(name))
                    {
                        GuestList.Add(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                }
                else if (command.Length > 3)
                {
                    if (!GuestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                    else
                    {
                        GuestList.Remove(name);
                    }
                }
            }
            Console.WriteLine(String.Join(Environment.NewLine, GuestList));
        }
    }
}
