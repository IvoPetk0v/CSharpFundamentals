using System;
using System.Linq;
using System.Text;

namespace Problem_1._1___Password_Reset
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string input;
            while ((input = Console.ReadLine()) != "Done")
            {
                string[] cmds = input
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                if (cmds[0] == "TakeOdd")
                {
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            sb.Append(password[i]);
                        }
                    }
                    password = sb.ToString();
                    Console.WriteLine(password);
                }
                else if (cmds[0] == "Cut")
                {
                    int index = int.Parse(cmds[1]);
                    int lenght = int.Parse(cmds[2]);
                    password = password.Remove(index, lenght);
                    Console.WriteLine(password);
                }
                else if (cmds[0] == "Substitute")
                {
                    string substring = cmds[1];
                    string subtitute = cmds[2];
                    if (!password.Contains(substring))
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                    else
                    {
                        password = password.Replace(substring, subtitute);
                        Console.WriteLine(password);
                    }
                }
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
