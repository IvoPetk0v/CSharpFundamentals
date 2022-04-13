using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> newlist = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] operations = command
                 .Split(" ")
                 .ToArray();
                if (operations.Length == 2)
                {
                    if (operations[0] == "Add")
                    {
                        int number = int.Parse(operations[1]);
                        newlist.Add(number);
                    }
                    else
                    {
                        int index = int.Parse(operations[1]);
                        if (index < 0 || index >= newlist.Count)
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            newlist.RemoveAt(index);
                        }
                    }
                }
                else if (operations[0] == "Insert")
                {
                    int number = int.Parse(operations[1]);
                    int index = int.Parse(operations[2]);
                    if (index < 0 || index >= newlist.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        newlist.Insert(index, number);
                    }
                }
                else if (operations[0] == "Shift")
                {
                    ShiftList(newlist, operations);
                }
            }
            Console.WriteLine(String.Join(" ", newlist));
        }
        static void ShiftList(List<int> newlist, string[] operations)
        {
            if (operations[1] == "left")
            {
                int rotation = int.Parse(operations[2]);
                rotation = rotation % newlist.Count;
                for (int i = 0; i < rotation; i++)
                {
                    newlist.Add(newlist[0]);
                    newlist.RemoveAt(0);
                }
                return;
            }
            else
            {
                int rotation = int.Parse(operations[2]);
                rotation = rotation % newlist.Count;
                for (int i = 0; i < rotation; i++)
                {
                    newlist.Insert(0, newlist[newlist.Count - 1]);
                    newlist.RemoveAt(newlist.Count - 1);
                }
                return;
            }
        }
    }
}
