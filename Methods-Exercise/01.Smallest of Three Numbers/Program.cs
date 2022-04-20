using System;

namespace _01.Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(GiveSmallestNum(num1, num2, num3));

        }
        static int GiveSmallestNum(int num1, int num2, int num3)
        {

            if (num1 < num2 && num1 < num3)
            {
                return num1;

            }
            else if (num2 < num1 && num2 < num3)
            {
                return num2;

            }
            else
            {
                return num3;
            }
        }
    }
}
