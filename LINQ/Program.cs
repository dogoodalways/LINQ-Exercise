using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
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
            /*
             *
             * Complete every task using Method OR Query syntax.
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your gitHub when completed!
             *
             */
        }

    }
}