using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> bombs = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int[] bombNpower = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int bomb = bombNpower[0];
            int power = bombNpower[1];
            while (bombs.Contains(bomb))
            {
                int index = bombs.FindIndex(n => n == bomb);
                //                1 2 2 4 2 2 2 9
                //      4 2       0 1 2 3 4 5 6 7 
                int highThresh = index + power;
                for (int i = index; i <= highThresh; i++)
                {
                    if (index >= bombs.Count)
                    {
                        break;
                    }
                    bombs.RemoveAt(index);
                }
                int lowThresh = index - power;
                if (lowThresh < 0)
                {
                    lowThresh = 0;
                }
                for (int i = lowThresh; i < index; i++)
                {
                    if (lowThresh >= bombs.Count)
                    {
                        break;
                    }
                    bombs.RemoveAt(lowThresh);
                }
            }
            Console.WriteLine(bombs.Sum());
        }
    }
}

