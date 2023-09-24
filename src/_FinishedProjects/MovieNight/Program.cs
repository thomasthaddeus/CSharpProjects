namespace SwitchStatement
{
    class Program
    {
        static void Main()
        {
            string drama = "Citizen Kane";
            string comedy = "Duck Soup";
            string adventure = "King Kong";
            string horror = "Psycho";
            string scifi = "2001: A Space Odyssey";

            Console.WriteLine("Please pick a genre for a movie reccomendation");
            string genre = Console.ReadLine();

            switch (genre)
            {
                case "Drama":
                    Console.WriteLine($"{drama} is Drama");
                    break;
                case "Comedy":
                    Console.WriteLine($"{comedy} is Comedy");
                    break;
                case "Adventure":
                    Console.WriteLine($"{adventure} is Adventure");
                    break;
                case "Horror":
                    Console.WriteLine($"{horror} is Horror");
                    break;
                case "Science Fiction":
                    Console.WriteLine($"{scifi} is Science Fiction");
                    break;
                default:
                    Console.WriteLine("No movie found");
                    break;
            }
        }
    }
}
