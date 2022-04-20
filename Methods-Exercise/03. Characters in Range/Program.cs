using System;
using System.Text;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            Console.WriteLine(GiveAllCharInThreshold(first, second));

        }
        static string GiveAllCharInThreshold(char first, char second)
        {
            StringBuilder newString = new StringBuilder();

            if (first > second)
            {
                for (int i = second + 1; i < first; i++)
                {
                    newString.Append($"{(char)i} ");
                }
            }
            else
            {
                for (int i = first + 1; i < second; i++)
                {
                    newString.Append($"{(char)i} ");
                }
            }
            return newString.ToString();

        }
    }
}
