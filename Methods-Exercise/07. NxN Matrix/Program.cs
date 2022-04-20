using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            WriteMatrix(num);

        }
        static void WriteMatrix(int num)
        {
            for (int row = 0; row < num; row++)
            {
                for (int columbs = 0; columbs < num; columbs++)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
        }
    }
}
