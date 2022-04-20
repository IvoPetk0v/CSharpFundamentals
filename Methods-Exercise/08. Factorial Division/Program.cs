using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{(double)FactorialsOfNumber(num1) /(double)FactorialsOfNumber(num2):f2}");
        }
        
        static long FactorialsOfNumber(int num1)
        {
            long result = 1;
            for (int i = 1; i <= num1; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
