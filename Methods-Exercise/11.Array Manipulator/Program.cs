using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                int index = -1, number = 0;
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (command[0] == "exchange")
                {
                    index = int.Parse(command[1]);
                    if (index >= array.Length || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        array = ExchangeArray(array, index);
                    }
                }
                else if (command[0] == "max")// command[1] odd or even 
                {
                    GiveMaXIndex(command, array);
                }
                else if (command[0] == "min")// comand[1] odd or even 
                {
                    GiveMinIndex(command, array);
                }
                else if (command[0] == "first")
                {
                    number = int.Parse(command[1]);
                    if (number > array.Length || number <= 0)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        GiveFirstNElements(command, number, array);
                    }
                }
                else if (command[0] == "last")
                {
                    number = int.Parse(command[1]);
                    if (number > array.Length || number <= 0)
                    {
                        Console.WriteLine("Invalid count");
                    }
                    else
                    {
                        GiveLastNElements(command, number, array);
                    }
                }
            }
            Console.WriteLine($"[{ string.Join(", ", array)}]");
        }
        static int[] ExchangeArray(int[] array, int index)
        {
            int[] newArray = new int[array.Length];
            int indexCounter = 0;

            for (int i = index + 1; i < array.Length; i++)
            {
                newArray[indexCounter] = array[i];
                indexCounter++;
            }
            for (int i = 0; i <= index; i++)
            {
                newArray[indexCounter] = array[i];
                indexCounter++;
            }
            return array = newArray;
        }
        static void GiveMaXIndex(string[] command, int[] array)
        {
            int maxIndex = -1;
            int maxValue = int.MinValue;
            if (command[1] == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0 && maxIndex <= i && maxValue <= array[i])
                    {
                        maxIndex = i;
                        maxValue = array[i];
                    }
                }
                if (maxIndex < 0)
                {
                    Console.WriteLine("No matches");
                    return;
                }
            }
            else if (command[1] == "odd")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0 && maxIndex <= i && maxValue <= array[i])
                    {
                        maxIndex = i;
                        maxValue = array[i];
                    }
                }
                if (maxIndex < 0)
                {
                    Console.WriteLine("No matches");
                    return;
                }
            }
            Console.WriteLine(maxIndex);
            return;
        }
        static void GiveMinIndex(string[] command, int[] array)
        {
            int minIndex = -1;
            int minValue = int.MaxValue;
            if (command[1] == "even")
            {

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0 && minIndex <= i && minValue >= array[i])
                    {
                        minIndex = i;
                        minValue = array[i];
                    }
                }
                if (minIndex < 0)
                {
                    Console.WriteLine("No matches");
                    return;
                }
            }
            else if (command[1] == "odd")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0 && minIndex <= i && minValue >= array[i])
                    {
                        minIndex = i;
                        minValue = array[i];
                    }
                }
                if (minIndex < 0)
                {
                    Console.WriteLine("No matches");
                    return;
                }
            }
            Console.WriteLine(minIndex);
            return;
        }
        static void GiveFirstNElements(string[] command, int number, int[] array)
        {
            List<int> newList = new List<int>();
            if (command[2] == "even")
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 == 0 && newList.Count < number)
                    {
                        newList.Add(array[i]);
                    }
                }
                newList.ToArray();
                Console.WriteLine($"[{ string.Join(", ", newList)}]");
                return;
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] % 2 != 0 && newList.Count < number)
                    {
                        newList.Add(array[i]);
                    }
                }
                newList.ToArray();
                Console.WriteLine($"[{ string.Join(", ", newList)}]");
                return;
            }
        }
        static void GiveLastNElements(string[] command, int number, int[] array)
        {
            List<int> newList = new List<int>();
            if (command[2] == "even")
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i] % 2 == 0 && newList.Count < number)
                    {
                        newList.Add(array[i]);
                    }
                }
                if (newList.Count == 0)
                {
                    Console.WriteLine("[]");
                    return;
                }
                newList.Reverse();
                newList.ToArray();
                Console.WriteLine($"[{ string.Join(", ", newList)}]");
                return;
            }
            else
            {
                for (int i = array.Length - 1; i >= 0; i--)
                {
                    if (array[i] % 2 != 0 && newList.Count < number)
                    {
                        newList.Add(array[i]);
                    }
                }
                if (newList.Count == 0)
                {
                    Console.WriteLine("[]");
                    return;
                }
                newList.Reverse();
                newList.ToArray();
                Console.WriteLine($"[{ string.Join(", ", newList)}]");
                return;
            }
        }
    }
}
