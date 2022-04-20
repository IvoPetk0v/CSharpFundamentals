using System;
using System.Linq;

namespace Problem_1___Secret_Chat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "Reveal")
            {
                string[] cmds = input
                .Split(":|:")
                .ToArray();
                if (cmds[0] == "InsertSpace")
                {
                    int insertIndex = int.Parse(cmds[1]);
                    message = message.Insert(insertIndex, " ");
                    Console.WriteLine(message);
                }
                else if (cmds[0] == "Reverse")
                {
                    string subString = cmds[1];
                    if (!message.Contains(subString))
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                    message = message.Remove(message.IndexOf(subString), subString.Length);
                    char[] reversedSubStr = subString.Reverse().ToArray();

                    subString = string.Join("", reversedSubStr);

                    message = message.Insert(message.Length, subString);
                    Console.WriteLine(message);
                }
                else if (cmds[0] == "ChangeAll")
                {
                    string subString = cmds[1];
                    string newString = cmds[2];
                    if (message.Contains(subString))
                    {
                        message = message.Replace(subString, newString).ToString();
                        Console.WriteLine(message);
                    }
                }
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
