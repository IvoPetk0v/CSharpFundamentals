using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                if (input == CheckPalidromeNumber(input))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                input = Console.ReadLine();
            }
        }
        static string CheckPalidromeNumber(string input)
        {
            char[] array = input.ToCharArray();
            Array.Reverse(array);
            return new string(array);

        }
    }
}
