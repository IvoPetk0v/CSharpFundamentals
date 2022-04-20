using System;
using System.Linq;

namespace Problem_1._2___The_Imitation_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "Decode")
            {
                string[] cmds = input
                .Split("|")
                .ToArray();
                if (cmds[0] == "Move")
                {
                    int charsCount = int.Parse(cmds[1]);
                    char[] substring = message.Take(charsCount).ToArray();
                    string newString = string.Join("", substring).ToString();
                    message = message.Remove(0, charsCount);
                    message = message.Insert(message.Length, newString);
                }
                else if (cmds[0] == "Insert")
                {
                    int index = int.Parse(cmds[1]);
                    string substring = cmds[2];

                    message = message.Insert(index, substring);
                }

                else if (cmds[0] == "ChangeAll")
                {
                    string oldString = cmds[1];
                    string newString = cmds[2];
                    message = message.Replace(oldString, newString);
                }
            }
            Console.WriteLine($"The decrypted message is: {message}");

        }
    }
}

