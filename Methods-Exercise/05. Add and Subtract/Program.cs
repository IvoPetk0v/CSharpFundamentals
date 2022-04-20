using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine(SubtractFromSum(num1, num2, num3));
        }

        static int SumFirstTwoNumber(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        static int SubtractFromSum(int num1, int num2, int num3)
        {
            int result = SumFirstTwoNumber(num1, num2) - num3;
            return result;
        }
    }
}
