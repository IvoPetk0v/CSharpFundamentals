using System;
using System.Text;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(GiveMiddleChar(input));

        }
        static string GiveMiddleChar(string input)
        {
            int middleChar;
            int middleChar2;
            if (input.Length % 2 == 0)
            {
                middleChar = input[(input.Length / 2) - 1];
                middleChar2 = input[(input.Length / 2)];
                StringBuilder newString = new StringBuilder();
                newString.Append((char)middleChar);
                newString.Append((char)middleChar2);
                return newString.ToString();
            }
            else
            {
                middleChar = input[(input.Length / 2)];

                StringBuilder newString = new StringBuilder();
                newString.Append((char)middleChar);
                return newString.ToString();

            }
        }
    }
}
