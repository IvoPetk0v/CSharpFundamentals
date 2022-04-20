using System;
using System.Collections.Generic;
using System.Text;

namespace _5.__Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = Console.ReadLine();
            int second = int.Parse(Console.ReadLine());
            if (second == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                List<int> bigNumber = new List<int>();
                int toAdd = 0;
                for (int i = first.Length - 1; i >= 0; i--)
                {
                    int result = 0;
                    result += toAdd;
                    result += ((first[i] - 48) * second);
                    toAdd = result / 10;
                    result = result % 10;

                    bigNumber.Add(result);
                    if (i == 0 && toAdd > 0)
                    {
                        bigNumber.Add(toAdd);
                    }
                }
                bigNumber.Reverse();
                Console.WriteLine(String.Join("", bigNumber));
            }
        }
    }
}
