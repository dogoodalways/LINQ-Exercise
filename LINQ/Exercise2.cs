using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Exercise2
    {
        public static void Main(string[] args)
        {
            List<string> games = new List<string>
            {
                "Moshiach Man",
                "Doing Good Deeds",
                "Smiles On Faces",
                "Yankel",
                "More Light"

            };

            var orderedGames = games.OrderBy(game => game.Length);

            Console.WriteLine("Games ordered by name length:");
            foreach (var game in orderedGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}