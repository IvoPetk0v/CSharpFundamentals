using System;
using System.Linq;

namespace _2.__Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            long result = 0;
            string[] inputStrings = Console.ReadLine()
                .Split(" ")
                .OrderByDescending(x => x.Length)
                .ToArray();
            result = MultiplyTheChCodes(inputStrings[0], inputStrings[1]);
            Console.WriteLine(result);
        }
        static long MultiplyTheChCodes(string first, string second)
        {
            long result = 0;
            for (int i = 0; i < second.Length; i++)
            {
                result += first[i] * second[i];
            }
            if (first.Length > second.Length)
            {
                for (int i = second.Length; i < first.Length; i++)
                {
                    result += first[i];
                }
            }
            return result;

        }
    }
}
