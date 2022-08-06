using System;
using System.Collections.Generic;

namespace _03._ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string[]> pieces = new Dictionary<string, string[]>();

            int numberOfPieces = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] pieceInfo = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

                string pieceName = pieceInfo[0];
                string composer = pieceInfo[1];
                string key = pieceInfo[2];

                pieces.Add(pieceName, new string[] { composer, key });
            }

            string command = Console.ReadLine();

            while (command != "Stop")
            {
                string[] tokens = command.Split("|", StringSplitOptions.RemoveEmptyEntries);

                string cmd = tokens[0];

                switch (cmd)
                {
                    case "Add":
                        Add(tokens[1], tokens[2], tokens[3], pieces);
                        break;
                    case "Remove":
                        Remove(tokens[1], pieces);
                        break;
                    case "ChangeKey":
                        ChangeKey(tokens[1], tokens[2], pieces);
                        break;
                }


                command = Console.ReadLine();
            }

            foreach (var piece in pieces)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value[0]}, Key: {piece.Value[1]}");
            }

        }

        static void Add(string pieceName, string composer, string key, Dictionary<string, string[]> pieces)
        {
            if (!pieces.ContainsKey(pieceName))
            {
                pieces.Add(pieceName, new string[] {composer, key});
                Console.WriteLine($"{pieceName} by {composer} in {key} added to the collection!");
            }
            else
            {
                Console.WriteLine($"{pieceName} is already in the collection!");
            }
        }

        static void Remove(string pieceName, Dictionary<string, string[]> pieces)
        {
            if (pieces.ContainsKey(pieceName))
            {
                pieces.Remove(pieceName);
                Console.WriteLine($"Successfully removed {pieceName}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
            }
        }

        static void ChangeKey(string pieceName, string newKey, Dictionary<string, string[]> pieces)
        {
            if (pieces.ContainsKey(pieceName))
            {
                pieces[pieceName][1] = newKey;
                Console.WriteLine($"Changed the key of {pieceName} to {newKey}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
            }
        }
    }
}
