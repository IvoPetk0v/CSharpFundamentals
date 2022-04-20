using System;
using System.Text;

namespace _7.__String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int removeChar = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    sb.Append(input[i]);
                    removeChar += input[i + 1] - 48;
                }
                else
                {
                    if (removeChar == 0)
                    {
                        sb.Append(input[i]);
                    }
                    else
                    {
                        removeChar--;
                        continue;
                    }
                }
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
