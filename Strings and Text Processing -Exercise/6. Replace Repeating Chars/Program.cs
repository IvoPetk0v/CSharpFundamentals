using System;
using System.Text;

namespace _6._Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            sb.Append(input[0]);
            for (int i = 1; i < input.Length; i++)
            {
                if (sb[sb.Length - 1] == input[i])
                {
                    continue;
                }
                else
                {
                    sb.Append(input[i]);
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
