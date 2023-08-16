namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>
            {
                "Moshiach Man",
                "Doing Good Deeds",
                "Smiles On Faces",
                "Yankel",
                "More Light"

            };

            var orderedGames  = videoGames.OrderBy(game => game.Length);

            foreach (var game in orderedGames )
            {
                Console.WriteLine(game);
            }
        }
    }
}
