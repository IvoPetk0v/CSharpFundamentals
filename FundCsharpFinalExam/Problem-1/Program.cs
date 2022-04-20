using System;
using System.Linq;

namespace Problem_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string spell = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "Abracadabra")
            {
                string[] cmdsArg = input
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();
                if (cmdsArg[0] == "Abjuration")
                {
                    spell = spell.ToUpper();
                    Console.WriteLine(spell);
                }
                else if (cmdsArg[0] == "Necromancy")
                {
                    spell = spell.ToLower();
                    Console.WriteLine(spell);
                }
                else if (cmdsArg[0] == "Illusion")
                {
                    int index = int.Parse(cmdsArg[1]);
                    string letter = cmdsArg[2];
                    if (IsIndexValid(spell, index))
                    {
                        spell = spell.Remove(index, 1);
                        spell = spell.Insert(index, letter);
                        Console.WriteLine("Done!");
                    }
                    else
                    {
                        Console.WriteLine("The spell was too weak.");
                    }
                }
                else if (cmdsArg[0] == "Divination")
                {
                    string substringFirst = cmdsArg[1];
                    string substringSecond = cmdsArg[2];
                    if (spell.Contains(substringFirst))
                    {
                        spell = spell.Replace(substringFirst, substringSecond);
                        Console.WriteLine(spell);

                    }
                }
                else if (cmdsArg[0] == "Alteration")
                {
                    string substring = cmdsArg[1];
                    if (spell.Contains(substring))
                    {
                        spell = spell.Remove(spell.IndexOf(substring), substring.Length);
                        Console.WriteLine(spell);
                    }
                }
                else
                {
                    Console.WriteLine("The spell did not work!");
                }
            }
        }
        static bool IsIndexValid(string spell, int index)
        {
            if (index >= 0 && index < spell.Length)
            {
                return true;
            }
            return false;
        }
    }
}
