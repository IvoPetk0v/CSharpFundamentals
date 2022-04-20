using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 17; i <= num; i++)
            {
                if (CheckForTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }

        }
        static bool CheckForTopNumber(int i)
        {
            if (CheckIsDivisible(i) && CheckNumHoldsOddDigit(i))
            {
                return true;
            }
            return false;

        }
        static bool CheckNumHoldsOddDigit(int i)//•	Holds at least one odd digit, e.g. 232, 707, 87578
        {
            int currentDigit = 0;
            bool isOdd = false;
            while (i != 0)
            {
                currentDigit = i % 10;
                if (currentDigit % 2 != 0)
                {
                    isOdd = true;
                    break;
                }
                i = i / 10;
            }
            if (isOdd)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool CheckIsDivisible(int i)//  Its sum of digits is divisible by 8, e.g. 8, 17, 88
        {
            int sumOfDigits = 0;
            while (i != 0)
            {
                sumOfDigits += i % 10;
                i = i / 10;
            }
            if (sumOfDigits % 8 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
