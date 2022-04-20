using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3._2___The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> pianoProgram = new Dictionary<string, List<string>>();
            string input;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                string[] currentPiece = input
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                string key = currentPiece[2];
                string author = currentPiece[1];
                List<string> pieceArgs = new List<string> { key, author };
                pianoProgram.Add(currentPiece[0], pieceArgs);
                input = null;
            }

            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] cmds = input
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                string piece;
                string key;
                string author;
                if (cmds[0] == "Add")
                {
                    piece = cmds[1];
                    author = cmds[2];
                    key = cmds[3];
                    if (!pianoProgram.ContainsKey(piece))
                    {
                        List<string> pieceArgs = new List<string> { key, author };
                        pianoProgram.Add(piece, pieceArgs);
                        Console.WriteLine($"{piece} by {author} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }

                }
                else if (cmds[0] == "Remove")
                {
                    piece = cmds[1];
                    if (pianoProgram.ContainsKey(piece))
                    {
                        pianoProgram.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (cmds[0] == "ChangeKey")
                {
                    piece = cmds[1];
                    key = cmds[2];
                    if (pianoProgram.ContainsKey(piece))
                    {
                        foreach (var item in pianoProgram)
                        {
                            if (item.Key == piece)
                            {
                                item.Value.RemoveAt(0);
                                item.Value.Insert(0, key);
                                Console.WriteLine($"Changed the key of {piece} to {key}!");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
            }
            foreach (var piece in pianoProgram)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value[1]}, Key: {piece.Value[0]}");
            }
        }
    }
}
