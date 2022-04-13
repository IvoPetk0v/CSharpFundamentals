using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> junks = new Dictionary<string, int>();
            Dictionary<string, int> items = new Dictionary<string, int>
            {
                ["fragments"] = 0,
                ["motes"] = 0,
                ["shards"] = 0
            };
            while (true)
            {

                string[] array = Console.ReadLine()
                                .ToLower()
                                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                .ToArray();
                for (int i = 1; i < array.Length; i += 2)
                {
                    if (items.ContainsKey(array[i]))
                    {
                        items[array[i]] += int.Parse(array[i - 1]);
                        if (IsItEnough(items))
                        {
                            break;
                        }
                    }

                    else
                    {
                        if (!junks.ContainsKey(array[i]))
                        {
                            junks.Add(array[i], int.Parse(array[i - 1]));

                        }
                        else
                        {
                            junks[array[i]] += int.Parse(array[i - 1]);
                        }
                    }
                }
                if (IsItEnough(items))
                {
                    break;
                }

            }
            foreach (var item in items)
            {
                if (item.Value >= 250)
                {
                    if (item.Key == "fragments")
                    {
                        Console.WriteLine("Valanyr obtained!");
                        items["fragments"] -= 250;
                    }
                    else if (item.Key == "motes")
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        items["motes"] -= 250;

                    }
                    else if (item.Key == "shards")
                    {
                        Console.WriteLine("Shadowmourne obtained!");

                        items["shards"] -= 250;
                       
                    }
                }
            }
            Console.WriteLine($"shards: {items.GetValueOrDefault("shards")}");
            Console.WriteLine($"motes: {items.GetValueOrDefault("motes")}");
            Console.WriteLine($"fragments: {items.GetValueOrDefault("fragments")}");
            foreach (var item in junks)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
        static bool IsItEnough(Dictionary<string, int> items)
        {
            const int neededValue = 250;
            if (items.Any(x => x.Value >= neededValue))
            {
                return true;
            }
            return false;
        }
    }
}
