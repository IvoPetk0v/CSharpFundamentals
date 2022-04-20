using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._3___Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> plants = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                List<double> plantParameters = new List<double>();
                string[] input = Console.ReadLine().Split("<->");
                string currentPlant = input[0];
                double rarity = double.Parse(input[1]);
                if (!plants.ContainsKey(currentPlant))
                {
                    plantParameters.Add(rarity);
                    plants.Add(currentPlant, plantParameters);
                }
                else
                {
                    plantParameters.Add(rarity);
                    plants[currentPlant] = plantParameters;
                }
            }
            string cmds;
            while ((cmds = Console.ReadLine()) != "Exhibition")
            {
                string[] cmdsArgs = cmds
                .Split(": ")
                .ToArray();
                string plant;
                double value;
                if (cmdsArgs[0] == "Rate")
                {
                    string[] plantAndRating = cmdsArgs[1].Split(" - ");
                    plant = plantAndRating[0];
                    value = double.Parse(plantAndRating[1]);
                    if (IsPlantValid(plants, plant))
                    {
                        SetRateToPlants(plants, plant, value);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (cmdsArgs[0] == "Update")
                {
                    string[] plantAndRarety = cmdsArgs[1].Split(" - ");
                    plant = plantAndRarety[0];
                    value = double.Parse(plantAndRarety[1]);
                    if (IsPlantValid(plants, plant))
                    {
                        UpdateRarety(plants, plant, value);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (cmdsArgs[0] == "Reset")
                {
                    plant = cmdsArgs[1];
                    if (IsPlantValid(plants, plant))
                    {
                        foreach (var item in plants)
                        {
                            if (item.Key == plant)
                            {
                                item.Value.RemoveRange(1, item.Value.Count - 1);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in plants)
            {
                int rarety = (int)item.Value[0];
                item.Value.RemoveAt(0);
                double avgRating;
                if (item.Value.Count > 0)
                {
                    avgRating = item.Value.Average();
                }
                else
                {
                    avgRating = 0.0;
                }

                Console.WriteLine($"- {item.Key}; Rarity: {rarety}; Rating: {avgRating:f2}");
            }
        }
        static bool IsPlantValid(Dictionary<string, List<double>> plants, string plant)
        {
            if (plants.ContainsKey(plant))
            {
                return true;
            }
            return false;
        }
        static void SetRateToPlants(Dictionary<string, List<double>> plants, string plant, double rating)
        {
            foreach (var item in plants)
            {
                if (item.Key == plant)
                {
                    item.Value.Add(rating);
                }
            }
        }
        static void UpdateRarety(Dictionary<string, List<double>> plants, string plant, double rarety)
        {
            foreach (var item in plants)
            {
                if (item.Key == plant)
                {
                    item.Value.RemoveAt(0);
                    item.Value.Insert(0, rarety);
                }
            }
        }
    }
}
