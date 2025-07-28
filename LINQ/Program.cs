namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> nameOfGames = new List<string>()
                { "God Of War", "GTA V", "EA FC25", "Dishonered", "Assasin's Creed" };
           var orderedGames = nameOfGames.OrderBy(name => name.Length).ToList();
            foreach (string name in orderedGames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
