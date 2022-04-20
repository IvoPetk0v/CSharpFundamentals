using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.__Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] userNames = Console.ReadLine()
                            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();
            List<string> validUserNames = new List<string>();
            for (int i = 0; i < userNames.Length; i++)
            {
                char[] userName = userNames[i].ToCharArray();
                if (IsItValid(userName))
                {
                    validUserNames.Add(userNames[i]);
                }
            }
            Console.WriteLine(String.Join(Environment.NewLine, validUserNames));
        }
        static bool IsItValid(char[] userName)
        {
            if (userName.Length >= 3 && userName.Length <= 16)
            {
                for (int i = 0; i < userName.Length; i++)
                {
                    if (Char.IsLetterOrDigit(userName[i]) || userName[i] == '-' || userName[i] == '_')
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
