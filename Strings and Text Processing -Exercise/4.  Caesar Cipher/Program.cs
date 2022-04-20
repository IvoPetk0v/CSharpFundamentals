using System;
using System.Linq;
using System.Text;

namespace _4.__Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {

            char[] input = Console.ReadLine().ToCharArray();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                int currCh = input[i] + 3;
                sb.Append((char)currCh);
            }
            Console.WriteLine(sb.ToString());

        }
    }
}
