using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<Cities> listOfCities = new List<Cities>();
            while ((input = Console.ReadLine()) != "Sail")
            {

                string[] citiesProps = input
                .Split("||", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                string name = citiesProps[0];
                int people = int.Parse(citiesProps[1]);
                int gold = int.Parse(citiesProps[2]);
                Cities currentCity = new Cities(name, people, gold);
                if (IsCityContainInList(listOfCities, name, gold, people))
                {
                    continue;
                }
                else
                {
                    listOfCities.Add(currentCity);
                }
            }
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmds = input
                .Split("=>", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                string cmdType = cmds[0];
                if (cmdType == "Plunder")
                {
                    string cityName = cmds[1];
                    int killPeople = int.Parse(cmds[2]);
                    int stealGold = int.Parse(cmds[3]);
                    PlunderingCity(listOfCities, cityName, killPeople, stealGold);
                }
                else
                {
                    string cityName = cmds[1];
                    int goldToAdd = int.Parse(cmds[2]);
                    if (goldToAdd < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                    foreach (var item in listOfCities)
                    {
                        if (item.Name == cityName)
                        {
                            item.Gold = item.Gold + goldToAdd;
                            Console.WriteLine($"{goldToAdd} gold added to the city treasury. {cityName} now has {item.Gold} gold.");
                            break;
                        }
                    }
                }
            }
            if (listOfCities.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {listOfCities.Count} wealthy settlements to go to:");
                foreach (var item in listOfCities)
                {
                    Console.WriteLine($"{item.Name} -> Population: {item.People} citizens, Gold: {item.Gold} kg");
                }
            }
        }
        static bool IsCityContainInList(List<Cities> listOfCities, string name, int gold, int people)
        {
            foreach (var item in listOfCities)
            {
                if (item.Name == name)
                {
                    item.Gold += gold;
                    item.People += people;
                    return true;
                }
            }
            return false;
        }
        static void PlunderingCity(List<Cities> listOfCities, string cityName, int killPeople, int stealGold)
        {
            foreach (var item in listOfCities)
            {
                if (item.Name == cityName)
                {
                    if (item.Gold >= stealGold && item.People >= killPeople)
                    {
                        item.Gold = item.Gold - stealGold;
                        item.People = item.People - killPeople;
                        Console.WriteLine($"{cityName} plundered! {stealGold} gold stolen, {killPeople} citizens killed.");
                        if (item.Gold == 0 || item.People == 0)
                        {
                            Console.WriteLine($"{item.Name} has been wiped off the map!");
                            listOfCities.Remove(item);
                        }
                        break;
                    }
                    else if (item.Gold < stealGold && item.People > killPeople)
                    {
                        Console.WriteLine($"{cityName} plundered! {item.Gold} gold stolen, {killPeople} citizens killed.");
                        listOfCities.Remove(item);
                        Console.WriteLine($"{item.Name} has been wiped off the map!");
                        listOfCities.Remove(item);
                        break;
                    }
                    else if (item.Gold > stealGold && item.People < killPeople)
                    {
                        Console.WriteLine($"{cityName} plundered! {stealGold} gold stolen, {item.People} citizens killed.");
                        Console.WriteLine($"{item.Name} has been wiped off the map!");
                        listOfCities.Remove(item);
                        break;
                    }
                }
            }
        }
    }
}
public class Cities
{
    public string Name { get; set; }
    public int People { get; set; }
    public int Gold { get; set; }

    public Cities(string name, int people, int gold)
    {
        Name = name;
        People = people;
        Gold = gold;
    }
}
