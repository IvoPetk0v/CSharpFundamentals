using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> playerOne = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> playerTwo = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            while (playerOne.Count > 0 && playerTwo.Count > 0)
            {
                if (playerOne[0].CompareTo(playerTwo[0]) == 1)//player1 win
                {
                    playerOne.Add(playerTwo[0]);
                    playerTwo.RemoveAt(0);
                    playerOne.Add(playerOne[0]);
                    playerOne.RemoveAt(0);
                }
                else if (playerOne[0].CompareTo(playerTwo[0]) == -1)//player2 win
                {
                    playerTwo.Add(playerOne[0]);
                    playerOne.RemoveAt(0);
                    playerTwo.Add(playerTwo[0]);
                    playerTwo.RemoveAt(0);
                }
                else if (playerOne[0].CompareTo(playerTwo[0]) == 0)//no win 
                {
                    playerOne.RemoveAt(0);
                    playerTwo.RemoveAt(0);
                }
            }
            if (playerOne.Count > 0)
            {
                Console.WriteLine($"First player wins! Sum: {playerOne.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {playerTwo.Sum()}");
            }
        }
    }
}
