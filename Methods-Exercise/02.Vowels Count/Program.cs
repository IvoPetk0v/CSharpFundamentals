using System;
using System.Linq;

namespace _02.Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(GiveVowelsChars(word.ToLower()));

        }
        static int GiveVowelsChars(string word)
        {
            int vowelsCounter = 0;
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            foreach (char ch in word)
            {
                if (vowels.Contains(ch))
                {
                    vowelsCounter++;
                }
            }
            return vowelsCounter;
        }
    }
}
