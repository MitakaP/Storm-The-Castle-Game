namespace StormtheCastleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrawMainMenu();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Choose an option: ");
                string command = ReadCommand();
                HandleCommand(command);
            }
        }
        private static string ReadCommand()
        {
            return Console.ReadLine();
        }

        private static void HandleCommand(string command)
        {
            switch (command)
            {
                case "1":
                    CitySquare(command);
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Wrong command! Try Again...");
                    break;
            }
        }

        private static void DrawMainMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" --------------------------------------------------------------------");
            Console.WriteLine("\r\n░██████╗████████╗░█████╗░██████╗░███╗░░░███╗  ████████╗██╗░░██╗███████╗\r\n██╔════╝╚══██╔══╝██╔══██╗██╔══██╗████╗░████║  ╚══██╔══╝██║░░██║██╔════╝" +
                "\r\n╚█████╗░░░░██║░░░██║░░██║██████╔╝██╔████╔██║  ░░░██║░░░███████║█████╗░░\r\n░╚═══██╗░░░██║░░░██║░░██║██╔══██╗██║╚██╔╝██║  ░░░██║░░░██╔══██║██╔══╝░░" +
                "\r\n██████╔╝░░░██║░░░╚█████╔╝██║░░██║██║░╚═╝░██║  ░░░██║░░░██║░░██║███████╗" +
                "\r\n╚═════╝░░░░╚═╝░░░░╚════╝░╚═╝░░╚═╝╚═╝░░░░░╚═╝  ░░░╚═╝░░░╚═╝░░╚═╝╚══════╝" +
                "\r\n\r\n░█████╗░░█████╗░░██████╗████████╗██╗░░░░░███████╗\r\n██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██║░░░░░██╔════╝" +
                "\r\n██║░░╚═╝███████║╚█████╗░░░░██║░░░██║░░░░░█████╗░░\r\n██║░░██╗██╔══██║░╚═══██╗░░░██║░░░██║░░░░░██╔══╝░░" +
                "\r\n╚█████╔╝██║░░██║██████╔╝░░░██║░░░███████╗███████╗\r\n░╚════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚══════╝╚══════╝");
            Console.WriteLine(" --------------------------------------------------------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("|====================================================================|");
            Console.WriteLine("|                           Enter City                               |");
            Console.WriteLine("|====================================================================|");
            Console.WriteLine("| <- 1. Start Game ->                                                |");
            Console.WriteLine("| <- 2. Exit   ->                                                    |");
            Console.WriteLine("|====================================================================|");
            Console.WriteLine();
        }

        private static void CitySquare(string command)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\n██████████████████████████████████████████████████████████████████" +
                "\r\n███─▄▄▄─█▄─▄█─▄─▄─█▄─█─▄███─▄▄▄▄█─▄▄▄─█▄─██─▄██▀▄─██▄─▄▄▀█▄─▄▄─███" +
                "\r\n███─███▀██─████─████▄─▄████▄▄▄▄─█─██▀─██─██─███─▀─███─▄─▄██─▄█▀███" +
                "\r\n▀▀▀▄▄▄▄▄▀▄▄▄▀▀▄▄▄▀▀▀▄▄▄▀▀▀▀▄▄▄▄▄▀───▄▄▀▀▄▄▄▄▀▀▄▄▀▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▀▀");
            Console.WriteLine();
            Console.WriteLine("|--------------------------------------------------------------------|");
            Console.WriteLine("| You are in the City Square, which serve as place for the community |");
            Console.WriteLine("| to gather for social interaction, festivals, and celebrations.     |");
            Console.WriteLine("| People come together to socialize, hear news, and participate      |");
            Console.WriteLine("| in communal events.                                                |");
            Console.WriteLine("|--------------------------------------------------------------------|");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("|====================================================================|");
            Console.WriteLine("|                    Choose Available Options                        |");
            Console.WriteLine("|====================================================================|");
            Console.WriteLine("| <- 1. City Hall  ->                                                |");
            Console.WriteLine("| <- 2. Market District  ->                                          |");
            Console.WriteLine("| <- 3. The Castle  ->                                               |");
            Console.WriteLine("| <- 4. Exit   ->                                                    |");
            Console.WriteLine("|====================================================================|");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Choose an option: ");
            command = Console.ReadLine();

            switch (command)
            {
                case "1":
                    CityHall(command);
                    break;
                case "2":
                    MarketDistrict(command);
                    break;
                case "3":
                    TheCastle(command);
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Wrong command! Try Again...");
                    Thread.Sleep(1500);
                    CitySquare(command);
                    break;
            }
        }

        private static void TheCastle(string command)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\n███████████████████████████████████████████████████████" +
                "\r\n█─▄─▄─█─█─█▄─▄▄─███─▄▄▄─██▀▄─██─▄▄▄▄█─▄─▄─█▄─▄███▄─▄▄─█" +
                "\r\n███─███─▄─██─▄█▀███─███▀██─▀─██▄▄▄▄─███─████─██▀██─▄█▀█" +
                "\r\n▀▀▄▄▄▀▀▄▀▄▀▄▄▄▄▄▀▀▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▀▄▄▄▀▀▄▄▄▄▄▀▄▄▄▄▄▀");
            Console.WriteLine();
            Console.WriteLine("|--------------------------------------------------------------------|");
            Console.WriteLine("| As you enter the castle grounds, your eyes catch a vision on       |");
            Console.WriteLine("| the high balcony — a beautiful princess, bathed in golden light.   |");
            Console.WriteLine("| Her gown flows softly in the breeze, and her gaze is both gentle   |");
            Console.WriteLine("| and captivating, a perfect match for the castle's quiet grandeur.  |");
            Console.WriteLine("|                                                                    |");
            Console.WriteLine("| An idea of stroming the castle and stealing the beautiful princess |");
            Console.WriteLine("| fly trough your mind.                                              |");
            Console.WriteLine("|--------------------------------------------------------------------|");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("|====================================================================|");
            Console.WriteLine("|                    Choose Available Options                        |");
            Console.WriteLine("|====================================================================|");
            Console.WriteLine("| <- 1. Storm The Castle  ->                                         |");
            Console.WriteLine("| <- 2. Go Back  ->                                                  |");
            Console.WriteLine("|====================================================================|");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Choose an option: ");

            command = Console.ReadLine();

            switch (command)
            {
                case "1":
                    StormTheCastle(command);
                    break;
                case "2":
                    CitySquare(command);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Wrong command! Try Again...");
                    Thread.Sleep(1500);
                    TheCastle(command);
                    break;
            }
        }

        private static void StormTheCastle(string command)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\n█▄█ █▀█ █░█   █▀█ █▀▀ ▄▀█ █░░ █░░ █▄█   ▀█▀ █▀█ █ █▀▀ █▀▄ " +
                "  ▀█▀ █▀█   █▀ ▀█▀ █▀█ █▀█ █▀▄▀█   ▀█▀ █░█ █▀▀" +
                "\r\n░█░ █▄█ █▄█   █▀▄ ██▄ █▀█ █▄▄ █▄▄ ░█░   ░█░ █▀▄ █ ██▄ █▄▀   ░█░ █▄█ " +
                "  ▄█ ░█░ █▄█ █▀▄ █░▀░█   ░█░ █▀█ ██▄\r\n\r\n█▀▀ ▄▀█ █▀ ▀█▀ █░░ █▀▀ ░ ░ ░" +
                "\r\n█▄▄ █▀█ ▄█ ░█░ █▄▄ ██▄ ▄ ▄ ▄");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("         █▄██▄█\r\n█▄█▄█▄█▄█▐█┼██▌█▄█▄█▄█▄█\r\n███┼█████▐████▌█████┼███\r\n█████████▐████▌█████████");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Environment.Exit(0);
        }

        private static void CityHall(string command)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\n███████████████████████████████████████████████████" +
                "\r\n███─▄▄▄─█▄─▄█─▄─▄─█▄─█─▄███─█─██▀▄─██▄─▄███▄─▄█████" +
                "\r\n███─███▀██─████─████▄─▄████─▄─██─▀─███─██▀██─██▀███" +
                "\r\n▀▀▀▄▄▄▄▄▀▄▄▄▀▀▄▄▄▀▀▀▄▄▄▀▀▀▀▄▀▄▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▀▀");
            Console.WriteLine();
            Console.WriteLine("|--------------------------------------------------------------------|");
            Console.WriteLine("| You step into the great city hall, where the air buzzes with       |");
            Console.WriteLine("| conversation. Groups of people are gathered everywhere, exchanging |");
            Console.WriteLine("| the latest news, whispers of gossip, and rumors of upcoming        |");
            Console.WriteLine("| events. The grand hall feels alive, echoing with laughter,         |");
            Console.WriteLine("| urgent whispers, and the energy of a city’s heartbeat.             |");
            Console.WriteLine("|                                                                    |");
            Console.WriteLine("| You see a group of women gossiping in the corner of the great      |");
            Console.WriteLine("| city hall. You are so curious that you can barely resist the       |");
            Console.WriteLine("| temptation.                                                        |");
            Console.WriteLine("|--------------------------------------------------------------------|");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("|====================================================================|");
            Console.WriteLine("|                    Choose Available Area                           |");
            Console.WriteLine("|====================================================================|");
            Console.WriteLine("| <- 1. Gossip  ->                                                   |");
            Console.WriteLine("| <- 2. Go Back  ->                                                  |");
            Console.WriteLine("|====================================================================|");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Choose an option: ");

            command = Console.ReadLine();

            switch (command)
            {
                case "1":
                    Gossip(command);
                    break;
                case "2":
                    CitySquare(command);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Wrong command! Try Again...");
                    Thread.Sleep(1500);
                    CityHall(command);
                    break;
            }
        }

        private static void Gossip(string command)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\r\n▄▄ █▀▄ █ █▀▄   █▄█ █▀█ █░█   █░█ █▀▀ ▄▀█ █▀█ " +
                "  ▀█▀ █░█ ▄▀█ ▀█▀   ▀█▀ █░█ █▀▀   █▀█ █▀█ █ █▄░█ █▀▀ █▀▀ █▀ █▀" +
                "\r\n░░ █▄▀ █ █▄▀   ░█░ █▄█ █▄█   █▀█ ██▄ █▀█ █▀▄   ░█░ █▀█ █▀█ ░█░  " +
                " ░█░ █▀█ ██▄   █▀▀ █▀▄ █ █░▀█ █▄▄ ██▄ ▄█ ▄█\r\n\r\n█ █▀   █░░ █▀█ █▀█ " +
                "█▄▀ █ █▄░█ █▀▀   █▀▀ █▀█ █▀█   ▄▀█   █▀█ █▀█ █ █▄░█ █▀▀ █▀▀ ▀█ ▄▄" +
                "\r\n█ ▄█   █▄▄ █▄█ █▄█ █░█ █ █░▀█ █▄█   █▀░ █▄█ █▀▄   █▀█   █▀▀ █▀▄ " +
                "█ █░▀█ █▄▄ ██▄ ░▄ ░░");
            Console.WriteLine();
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\r\n▄▄ █   █░█ █▀▀ ▄▀█ █▀█ █▀▄   ▀█▀ █░█ ▄▀█ ▀█▀  " +
                " █▀ █░█ █▀▀   ▄▀█ █░░ █▀█ █▀▀ ▄▀█ █▀▄ █▄█   █░░ █▀█ █░█ █▀▀ █▀" +
                "\r\n░░ █   █▀█ ██▄ █▀█ █▀▄ █▄▀   ░█░ █▀█ █▀█ ░█░   ▄█ █▀█ ██▄  " +
                " █▀█ █▄▄ █▀▄ ██▄ █▀█ █▄▀ ░█░   █▄▄ █▄█ ▀▄▀ ██▄ ▄█\r\n\r\n█▀ █▀█ █▀▄▀█ █▀▀ " +
                "█▀█ █▄░█ █▀▀ █ ▄▄\r\n▄█ █▄█ █░▀░█ ██▄ █▄█ █░▀█ ██▄ ▄ ░░");
            Console.WriteLine();
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\r\n▄▄ ▀█▀ █░█ █▀▀   █▀▄▀█ ▄▀█ █▄░█ ▀ █▀   █▄░█ ▄▀█ █▀▄▀█ █▀▀  " +
                " █ █▀ ░ ░ ░ █░█ █▀▀ █▄█   █░█░█ █░█ █▀█   ▄▀█ █▀█ █▀▀\r\n░░ ░█░ █▀█ ██▄  " +
                " █░▀░█ █▀█ █░▀█ ░ ▄█   █░▀█ █▀█ █░▀░█ ██▄   █ ▄█ ▄ ▄ ▄ █▀█ ██▄ ░█░   " +
                "▀▄▀▄▀ █▀█ █▄█   █▀█ █▀▄ ██▄\r\n\r\n█▄█ █▀█ █░█ ▀█ ▄▄\r\n░█░ █▄█ █▄█ ░▄ ░░");
            Console.WriteLine();
            Thread.Sleep(3000);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\r\n▄▄ █▀▄ █▀█ █▄░█ ▀ ▀█▀   █▀█ █░█ █▄░█ █ ▄▄\r\n░░" +
                " █▄▀ █▄█ █░▀█ ░ ░█░   █▀▄ █▄█ █░▀█ ▄ ░░");
            Thread.Sleep(5000);
            CitySquare(command);
        }

        private static void MarketDistrict(string command)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\n█████████████████████████████████████████████████████████████████████████████████████████" +
                "\r\n███▄─▀█▀─▄██▀▄─██▄─▄▄▀█▄─█─▄█▄─▄▄─█─▄─▄─███▄─▄▄▀█▄─▄█─▄▄▄▄█─▄─▄─█▄─▄▄▀█▄─▄█─▄▄▄─█─▄─▄─███" +
                "\r\n████─█▄█─███─▀─███─▄─▄██─▄▀███─▄█▀███─██████─██─██─██▄▄▄▄─███─████─▄─▄██─██─███▀███─█████" +
                "\r\n▀▀▀▄▄▄▀▄▄▄▀▄▄▀▄▄▀▄▄▀▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▀▄▄▄▀▀▀▀▄▄▄▄▀▀▄▄▄▀▄▄▄▄▄▀▀▄▄▄▀▀▄▄▀▄▄▀▄▄▄▀▄▄▄▄▄▀▀▄▄▄▀▀▀▀");
            Console.WriteLine();
            Console.WriteLine("|--------------------------------------------------------------------|");
            Console.WriteLine("| You step into the lively Market District, where vendors shout      |");
            Console.WriteLine("| their wares and the scent of fresh bread fills the air. Crowds     |");
            Console.WriteLine("| bustle through the cobblestone streets, trading goods while trying |");
            Console.WriteLine("| to get a bargain. It's the center of life and commerce, where      |");
            Console.WriteLine("| every deal shapes the city's future.                               |");
            Console.WriteLine("|--------------------------------------------------------------------|");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("|====================================================================|");
            Console.WriteLine("|                    Choose Available Area                           |");
            Console.WriteLine("|====================================================================|");
            Console.WriteLine("| <- 1. Armorer Shop  ->                                             |");
            Console.WriteLine("| <- 2. Weapons Shop ->                                              |");
            Console.WriteLine("| <- 3. Stables Shop ->                                              |");
            Console.WriteLine("| <- 4. Go Back (City Square) ->                                     |");
            Console.WriteLine("| <- 5. Exit ->                                                      |");
            Console.WriteLine("|====================================================================|");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Choose an option: ");

            command = Console.ReadLine();

            switch (command)
            {
                case "1":
                    Armorer(command);
                    break;
                case "2":
                    WeaponsShop(command);
                    break;
                case "3":
                    Stables(command);
                    break;
                case "4":
                    CitySquare(command);
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Wrong command! Try Again...");
                    Thread.Sleep(1500);
                    MarketDistrict(command);
                    break;
            }
        }

        private static void Armorer(string command)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\n████████████████████████████████████████████████" +
                "\r\n████▀▄─██▄─▄▄▀█▄─▀█▀─▄█─▄▄─█▄─▄▄▀█▄─▄▄─█▄─▄▄▀███" +
                "\r\n████─▀─███─▄─▄██─█▄█─██─██─██─▄─▄██─▄█▀██─▄─▄███" +
                "\r\n▀▀▀▄▄▀▄▄▀▄▄▀▄▄▀▄▄▄▀▄▄▄▀▄▄▄▄▀▄▄▀▄▄▀▄▄▄▄▄▀▄▄▀▄▄▀▀▀");
            Console.WriteLine();
            Console.WriteLine("|--------------------------------------------------------------------|");
            Console.WriteLine("| You step into the armorer’s shop, where the warmth of the forge    |");
            Console.WriteLine("| radiates through the air. Racks of gleaming plate mail, polished   |");
            Console.WriteLine("| helmets, and reinforced gauntlets line the walls, each crafted     |");
            Console.WriteLine("| for a perfect fit. Every piece tells a story of protection,        |");
            Console.WriteLine("| resilience, and craftsmanship, ready to shield its wearer from     |");
            Console.WriteLine("| the dangers beyond the city walls.                                 |");
            Console.WriteLine("|--------------------------------------------------------------------|");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("|====================================================================|");
            Console.WriteLine("|                    Choose Available Options                        |");
            Console.WriteLine("|====================================================================|");
            Console.WriteLine("| <- 1. Steal a Shield  ->                                           |");
            Console.WriteLine("| <- 2. Go Back  ->                                                  |");
            Console.WriteLine("|====================================================================|");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Choose an option: ");

            command = Console.ReadLine();

            switch (command)
            {
                case "1":
                    StealShield(command);
                    break;
                case "2":
                    MarketDistrict(command);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Wrong command! Try Again...");
                    Thread.Sleep(1500);
                    Armorer(command);
                    break;
            }
        }

        private static void StealShield(string command)
        {
            Console.Clear();
            Random random = new Random();
            int randomNumber = random.Next(1, 11);

            if (randomNumber <= 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\r\n█▄█ █▀█ █░█   █▀ █░█ █▀▀ █▀▀ █▀▀ █▀ █▀ █▀▀ █░█ █░░ █░░ █▄█   █▀ ▀█▀ █▀█ █░░ █▀▀   ▄▀█   █▀ █░█ █ █▀▀ █░░ █▀▄" +
                    "\r\n░█░ █▄█ █▄█   ▄█ █▄█ █▄▄ █▄▄ ██▄ ▄█ ▄█ █▀░ █▄█ █▄▄ █▄▄ ░█░   ▄█ ░█░ █▄█ █▄▄ ██▄   █▀█   ▄█ █▀█ █ ██▄ █▄▄ █▄▀" +
                    "\r\n\r\n▄▀█ █▄░█ █▀▄   █▀▀ █▀ █▀▀ ▄▀█ █▀█ █▀▀ █▀▄ █\r\n█▀█ █░▀█ █▄▀   ██▄ ▄█ █▄▄ █▀█ █▀▀ ██▄ █▄▀ ▄");
                Thread.Sleep(2500);
                MarketDistrict(command);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\r\n▀█▀ █░█ █▀▀   ▄▀█ █▀█ █▀▄▀█ █▀█ █▀█ █▀▀ █▀█   █▀▄▀█ ▄▀█ █▄░█   █▀ ▄▀█ █░█░█   █▄█ █▀█ █░█ █" +
                    "\r\n░█░ █▀█ ██▄   █▀█ █▀▄ █░▀░█ █▄█ █▀▄ ██▄ █▀▄   █░▀░█ █▀█ █░▀█   ▄█ █▀█ ▀▄▀▄▀   ░█░ █▄█ █▄█ ▄");
                Thread.Sleep(1100);
                Console.WriteLine();
                Console.WriteLine("\r\n█░█ █▀▀   █▄▄ █▀▀ ▄▀█ ▀█▀   █▄█ █▀█ █░█   █░█ █▀█   ▄▀█ █▄░█ █▀▄   ▀█▀ █░█ █▀█ █▀▀ █░█░█   █▄█ █▀█ █░█   █▀█ █░█ ▀█▀" +
                    "\r\n█▀█ ██▄   █▄█ ██▄ █▀█ ░█░   ░█░ █▄█ █▄█   █▄█ █▀▀   █▀█ █░▀█ █▄▀   ░█░ █▀█ █▀▄ ██▄ ▀▄▀▄▀   ░█░ █▄█ █▄█   █▄█ █▄█ ░█░" +
                    "\r\n\r\n█▀█ █▀▀   ▀█▀ █░█ █▀▀   █▀ █░█ █▀█ █▀█ ░\r\n█▄█ █▀░   ░█░ █▀█ ██▄   ▄█ █▀█ █▄█ █▀▀ ▄");
                Thread.Sleep(2500);
                MarketDistrict(command);
            }
        }

        private static void WeaponsShop(string command)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\n███████████████████████████████████████████████████████████████████████████" +
                "\r\n███▄─█▀▀▀█─▄█▄─▄▄─██▀▄─██▄─▄▄─█─▄▄─█▄─▀█▄─▄█─▄▄▄▄███─▄▄▄▄█─█─█─▄▄─█▄─▄▄─███" +
                "\r\n████─█─█─█─███─▄█▀██─▀─███─▄▄▄█─██─██─█▄▀─██▄▄▄▄─███▄▄▄▄─█─▄─█─██─██─▄▄▄███" +
                "\r\n▀▀▀▀▄▄▄▀▄▄▄▀▀▄▄▄▄▄▀▄▄▀▄▄▀▄▄▄▀▀▀▄▄▄▄▀▄▄▄▀▀▄▄▀▄▄▄▄▄▀▀▀▄▄▄▄▄▀▄▀▄▀▄▄▄▄▀▄▄▄▀▀▀▀▀");
            Console.WriteLine();
            Console.WriteLine("|--------------------------------------------------------------------|");
            Console.WriteLine("| You step into the weapons shop, where swords, axes, and spears     |");
            Console.WriteLine("| gleam on the walls. The smith hammers a blade to perfection, while |");
            Console.WriteLine("| customers inspect finely crafted weapons. The air is filled with   |");
            Console.WriteLine("| the heat of the forge and the promise of untold battles.           |");
            Console.WriteLine("|                                                                    |");
            Console.WriteLine("| A sword is standing next to leaning against the wall. You always   |");
            Console.WriteLine("| wanted one, right?                                                 |");
            Console.WriteLine("|--------------------------------------------------------------------|");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("|====================================================================|");
            Console.WriteLine("|                    Choose Available Options                        |");
            Console.WriteLine("|====================================================================|");
            Console.WriteLine("| <- 1. Steal a Sword  ->                                            |");
            Console.WriteLine("| <- 2. Go Back  ->                                                  |");
            Console.WriteLine("|====================================================================|");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Choose an option: ");

            command = Console.ReadLine();

            switch (command)
            {
                case "1":
                    StealSword(command);
                    break;
                case "2":
                    MarketDistrict(command);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Wrong command! Try Again...");
                    Thread.Sleep(1500);
                    WeaponsShop(command);
                    break;
            }
        }

        private static void StealSword(string command)
        {
            Console.Clear();
            Random random = new Random();
            int randomNumber = random.Next(1, 11);

            if (randomNumber <= 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\r\n█▄█ █▀█ █░█   █▀ █░█ █▀▀ █▀▀ █▀▀ █▀ █▀ █▀▀ █░█ █░░ █░░ █▄█   █▀ ▀█▀ █▀█ █░░ █▀▀   ▄▀█   █▀ █░█░█ █▀█ █▀█ █▀▄" +
                    "\r\n░█░ █▄█ █▄█   ▄█ █▄█ █▄▄ █▄▄ ██▄ ▄█ ▄█ █▀░ █▄█ █▄▄ █▄▄ ░█░   ▄█ ░█░ █▄█ █▄▄ ██▄   █▀█   ▄█ ▀▄▀▄▀ █▄█ █▀▄ █▄▀" +
                    "\r\n\r\n▄▀█ █▄░█ █▀▄   █▀█ ▄▀█ █▄░█   █▄▄ ▄▀█ █▀▀ █▄▀   ▀█▀ █▀█   ▀█▀ █░█ █▀▀   █▀ ▀█▀ █▀█ █▀▀ █▀▀ ▀█▀ █▀ █" +
                    "\r\n█▀█ █░▀█ █▄▀   █▀▄ █▀█ █░▀█   █▄█ █▀█ █▄▄ █░█   ░█░ █▄█   ░█░ █▀█ ██▄   ▄█ ░█░ █▀▄ ██▄ ██▄ ░█░ ▄█ ▄");
                Thread.Sleep(2500);
                MarketDistrict(command);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\r\n▀█▀ █░█ █▀▀   █▀ █▀▄▀█ █ ▀█▀ █░█   █▀ ▄▀█ █░█░█   █▄█ █▀█ █░█ █" +
                    "\r\n░█░ █▀█ ██▄   ▄█ █░▀░█ █ ░█░ █▀█   ▄█ █▀█ ▀▄▀▄▀   ░█░ █▄█ █▄█ ▄");
                Thread.Sleep(1100);
                Console.WriteLine();
                Console.WriteLine("\r\n█░█░█ █░█ ▄▀█ ▀█▀   ▄▀█ █▀█ █▀▀   █▄█ █▀█ █░█   █▀▀ █▀█ █ █▄░█ █▀▀   ▀█▀ █▀█   █▀▄ █▀█ ▀█" +
                    "\r\n▀▄▀▄▀ █▀█ █▀█ ░█░   █▀█ █▀▄ ██▄   ░█░ █▄█ █▄█   █▄█ █▄█ █ █░▀█ █▄█   ░█░ █▄█   █▄▀ █▄█ ░▄");
                Thread.Sleep(1100);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("|====================================================================|");
                Console.WriteLine("|                         Choose Action                              |");
                Console.WriteLine("|====================================================================|");
                Console.Write("| <- ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("1. Fight!");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ->                                                   |");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("\n| <- ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("2. Surrender!");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("  ->                                               |");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n|====================================================================|");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Choose an option: ");

                command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                        Fight(command);
                        break;
                    case "2":
                        Surrender(command);
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Wrong command! Try Again...");
                        Thread.Sleep(1500);
                        WeaponsShop(command);
                        break;
                }
            }
        }

        private static void Surrender(string command)
        {
            Console.Clear();
            Random random = new Random();
            int randomNumber = random.Next(1, 11);

            if (randomNumber <= 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\r\n▀█▀ █░█ █▀▀   █▀ █▀▄▀█ █ ▀█▀ █░█   █▀ █▀█ █▀▀ ▄▀█ █▀█ █▀▄   █▄█ █▀█ █░█ █" +
                    "\r\n░█░ █▀█ ██▄   ▄█ █░▀░█ █ ░█░ █▀█   ▄█ █▀▀ ██▄ █▀█ █▀▄ █▄▀   ░█░ █▄█ █▄█ ▄");
                Thread.Sleep(1200);
                Console.WriteLine("\r\n█░█ █▀▀   ▀█▀ █▀█ █▀█ █▄▀   █░█ █ █▀   █▀ █░█░█ █▀█ █▀█ █▀▄   ▄▀█ █▄░█ █▀▄   █▄▀ █ █▀▀ █▄▀ █▀▀ █▀▄   █▄█ █▀█ █░█" +
                    "\r\n█▀█ ██▄   ░█░ █▄█ █▄█ █░█   █▀█ █ ▄█   ▄█ ▀▄▀▄▀ █▄█ █▀▄ █▄▀   █▀█ █░▀█ █▄▀   █░█ █ █▄▄ █░█ ██▄ █▄▀   ░█░ █▄█ █▄█" +
                    "\r\n\r\n█▀█ █░█ ▀█▀   █▀█ █▀▀   ▀█▀ █░█ █▀▀   █▀ █░█ █▀█ █▀█ ░\r\n█▄█ █▄█ ░█░   █▄█ █▀░   ░█░ █▀█ ██▄   ▄█ █▀█ █▄█ █▀▀ ▄");
                Thread.Sleep(2500);
                MarketDistrict(command);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\r\n▀█▀ █░█ █▀▀   █▀ █▀▄▀█ █ ▀█▀ █░█   █▀ █░█ █▀█ █░█░█ █▀▀ █▀▄   █▄█ █▀█ █░█   █░█░█ █░█ ▄▀█ ▀█▀   █░█ █ █▀" +
                    "\r\n░█░ █▀█ ██▄   ▄█ █░▀░█ █ ░█░ █▀█   ▄█ █▀█ █▄█ ▀▄▀▄▀ ██▄ █▄▀   ░█░ █▄█ █▄█   ▀▄▀▄▀ █▀█ █▀█ ░█░   █▀█ █ ▄█" +
                    "\r\n\r\n█▀▀ █ █▀ ▀█▀ █▀   █▀▀ ▄▀█ █▄░█   █▀▄ █▀█   ▄▀█ █▄░█ █▀▄   ▀█▀ █░█ █▀█ █▀▀ █░█░█   █▄█ █▀█ █░█   █▀█ █░█ ▀█▀" +
                    "\r\n█▀░ █ ▄█ ░█░ ▄█   █▄▄ █▀█ █░▀█   █▄▀ █▄█   █▀█ █░▀█ █▄▀   ░█░ █▀█ █▀▄ ██▄ ▀▄▀▄▀   ░█░ █▄█ █▄█   █▄█ █▄█ ░█░" +
                    "\r\n\r\n▀█▀ █░█ █▀▀   █░█░█ █ █▄░█ █▀▄ █▀█ █░█░█ █\r\n░█░ █▀█ ██▄   ▀▄▀▄▀ █ █░▀█ █▄▀ █▄█ ▀▄▀▄▀ ▄");
                Thread.Sleep(3500);
                MarketDistrict(command);
            }
        }

        private static void Fight(string command)
        {
            Console.Clear();
            Random random = new Random();
            int randomNumber = random.Next(1, 11);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\r\n▄▄ █▀ █▀█ █░█ █▄░█ █▀▄   █▀█ █▀▀   █▀ █░█░█ █▀█ █▀█ █▀▄ █▀   █▀▀ █░░ ▄▀█ █▀ █░█ █ █▄░█ █▀▀ ▄▄" +
                "\r\n░░ ▄█ █▄█ █▄█ █░▀█ █▄▀   █▄█ █▀░   ▄█ ▀▄▀▄▀ █▄█ █▀▄ █▄▀ ▄█   █▄▄ █▄▄ █▀█ ▄█ █▀█ █ █░▀█ █▄█ ░░");
            Thread.Sleep(1200);
            Console.WriteLine();

            if (randomNumber <= 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\r\n█▄█ █▀█ █░█   ▀█▀ █▀█ █▀█ █▄▀   █░█ █ █▀▄▀█   █▀▄ █▀█ █░█░█ █▄░█   ▄▀█ █▄░█ █▀▄   █░░ █▀▀ █▀▀ ▀█▀   ▀█▀ █░█ █▀▀" +
                    "\r\n░█░ █▄█ █▄█   ░█░ █▄█ █▄█ █░█   █▀█ █ █░▀░█   █▄▀ █▄█ ▀▄▀▄▀ █░▀█   █▀█ █░▀█ █▄▀   █▄▄ ██▄ █▀░ ░█░   ░█░ █▀█ ██▄" +
                    "\r\n\r\n█▀ █░█ █▀█ █▀█   █▀▀ ▄▀█ █░░ █▀▄▀█ █░░ █▄█ ░\r\n▄█ █▀█ █▄█ █▀▀   █▄▄ █▀█ █▄▄ █░▀░█ █▄▄ ░█░ ▄");
                Thread.Sleep(2500);
                MarketDistrict(command);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\r\n▀█▀ █░█ █▀▀   █▀ █▀▄▀█ █ ▀█▀ █░█   █▄░█ █▀▀ ▄▀█ █▀█ █░░ █▄█   ▀█▀ █▀█ █▀█ █▄▀   █▄█ █▀█ █░█   █▀▄ █▀█ █░█░█ █▄░█ █" +
                    "\r\n░█░ █▀█ ██▄   ▄█ █░▀░█ █ ░█░ █▀█   █░▀█ ██▄ █▀█ █▀▄ █▄▄ ░█░   ░█░ █▄█ █▄█ █░█   ░█░ █▄█ █▄█   █▄▀ █▄█ ▀▄▀▄▀ █░▀█ ▄");
                Console.WriteLine("\r\n█▄█ █▀█ █░█   █▀▀ █▀ █▀▀ ▄▀█ █▀█ █▀▀ █▀▄   █░█░█ █ ▀█▀ █░█   █▀▄▀█ ▄▀█ █▄░█ █▄█   █░█░█ █▀█ █░█ █▄░█ █▀▄ █▀ ░" +
                    "\r\n░█░ █▄█ █▄█   ██▄ ▄█ █▄▄ █▀█ █▀▀ ██▄ █▄▀   ▀▄▀▄▀ █ ░█░ █▀█   █░▀░█ █▀█ █░▀█ ░█░   ▀▄▀▄▀ █▄█ █▄█ █░▀█ █▄▀ ▄█ ▄");
                Thread.Sleep(5000);
                MarketDistrict(command);
            }
        }

        private static void Stables(string command)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\r\n███████████████████████████████████████████████" +
                "\r\n███─▄▄▄▄█─▄─▄─██▀▄─██▄─▄─▀█▄─▄███▄─▄▄─█─▄▄▄▄███" +
                "\r\n███▄▄▄▄─███─████─▀─███─▄─▀██─██▀██─▄█▀█▄▄▄▄─███" +
                "\r\n▀▀▀▄▄▄▄▄▀▀▄▄▄▀▀▄▄▀▄▄▀▄▄▄▄▀▀▄▄▄▄▄▀▄▄▄▄▄▀▄▄▄▄▄▀▀▀");
            Console.WriteLine();
            Console.WriteLine("|--------------------------------------------------------------------|");
            Console.WriteLine("| You step into the bustling stables, where the scent of hay and     |");
            Console.WriteLine("| leather fills the air. Sleek horses paw at the ground, their coats |");
            Console.WriteLine("| gleaming in the sunlight. Stable hands move quickly, tending to    |");
            Console.WriteLine("| the animals and preparing saddles. The air hums with energy,       |");
            Console.WriteLine("| carrying the promise of swift journeys and daring adventures.      |");
            Console.WriteLine("|--------------------------------------------------------------------|");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("|====================================================================|");
            Console.WriteLine("|                    Choose Available Options                        |");
            Console.WriteLine("|====================================================================|");
            Console.WriteLine("| <- 1. Steal a Horse  ->                                            |");
            Console.WriteLine("| <- 2. Feed a Horse  ->                                             |");
            Console.WriteLine("| <- 3. Go Back  ->                                                  |");
            Console.WriteLine("|====================================================================|");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Choose an option: ");

            command = Console.ReadLine();

            switch (command)
            {
                case "1":
                    StealHorse(command);
                    break;
                case "2":
                    FeedHorse(command);
                    break;
                case "3":
                    MarketDistrict(command);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Wrong command! Try Again...");
                    Thread.Sleep(1500);
                    Stables(command);
                    break;
            }
        }

        private static void StealHorse(string command)
        {
            Console.Clear();
            Random random = new Random();
            int randomNumber = random.Next(1, 11);

            if (randomNumber <= 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\r\n█▄█ █▀█ █░█   █▀█ ▄▀█ █▄░█   ▄▀█ █░█░█ ▄▀█ █▄█   █░█░█ █ ▀█▀ █░█   ▄▀█   █░█ █▀█ █▀█ █▀ █▀▀" +
                    "\r\n░█░ █▄█ █▄█   █▀▄ █▀█ █░▀█   █▀█ ▀▄▀▄▀ █▀█ ░█░   ▀▄▀▄▀ █ ░█░ █▀█   █▀█   █▀█ █▄█ █▀▄ ▄█ ██▄" +
                    "\r\n\r\n█▀ █░█ █▀▀ █▀▀ █▀▀ █▀ █▀ █▀▀ █░█ █░░ █░░ █▄█ █\r\n▄█ █▄█ █▄▄ █▄▄ ██▄ ▄█ ▄█ █▀░ █▄█ █▄▄ █▄▄ ░█░ ▄");
                Console.WriteLine();
                Console.WriteLine("\r\n ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣤⣿⣿⣻⣿⣿⣦⣦⣤⣾⣿⣿⡏⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠹⣿⣶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⣄⠀⠀⠀⠀⠀" +
                    "\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠒⠒⠒⠶⢶⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣧⣄⠀⠀⠀\r\n ⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣀⣐⣾⣿⣟⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣄⠀" +
                    "\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢈⣐⣻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠛⠉⠻⠿⠿⣿⣿⣿⠁\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣤⣶⣶⣶⣶⣶⣦⣤⣤⣤⣀⣀⣀⣡⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠁⠀⠀⠀⠀⠀⠈⠙⠁⠀" +
                    "\r\n⠀⠀⠀⠀⠀⠀⠀⠀⣤⣤⣤⣤⣤⣀⡀⠀⠀⠀⠀⣀⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⣀⣤⢄⡀⠀⠀⠠⣤⣶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀" +
                    "\r\n⢭⢽⣿⣿⣷⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠻⣿⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⢿⣿⣿⣿⣿⡿⠏⠈⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀" +
                    "\r\n⠀⠈⠛⠿⣿⣿⣿⡿⠛⠝⠋⠀⠚⠙⠀⠀⠈⠀⠀⠀⠈⠻⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢈⣿⣿⣿⣿⣿⡿⠋⠙⠛⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀" +
                    "\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣴⣿⣿⣿⣿⡿⠉⠀⠀⠀⠀⠀⠀⠀⠈⠉⠉⠉⠉⠉⢻⣿⣿⣿⠿⣿⣿⣿⣷⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⠿⣿⣿⣿⣿⣟⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⡿⠀⠀⠉⠙⢻⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀" +
                    "\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⢿⣿⣿⣿⣿⣶⣦⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⠃⠀⠀⣀⣴⣾⠟⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⠻⣿⣿⣿⣿⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣷⣿⡿⠛⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀" +
                    "\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⢿⣿⣿⡀⠀⠀⣠⣴⣦⡀⠀⠀⢀⣴⣿⡿⠋⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⣿⣿⠀⠀⠈⠻⠿⣿⣿⣿⠿⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀" +
                    "\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠿⠀⠀⠀⠀⠀⠀⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                Thread.Sleep(2500);
                MarketDistrict(command);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\r\n▀█▀ █░█ █▀▀   █░█ █▀█ █▀█ █▀ █▀▀   ▀█▀ █░█ █▀█ █▀▀ █░█░█   █▄█ █▀█ █░█   █▀█ █▄░█   ▀█▀ █░█ █▀▀" +
                    "\r\n░█░ █▀█ ██▄   █▀█ █▄█ █▀▄ ▄█ ██▄   ░█░ █▀█ █▀▄ ██▄ ▀▄▀▄▀   ░█░ █▄█ █▄█   █▄█ █░▀█   ░█░ █▀█ ██▄" +
                    "\r\n\r\n█▀▀ █▀█ █▀█ █░█ █▄░█ █▀▄ ░ ░ ░\r\n█▄█ █▀▄ █▄█ █▄█ █░▀█ █▄▀ ▄ ▄ ▄");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀" +
                    "\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀" +
                    "\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡄⠀⠀⠀⠀⠀⠀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣧⠀⠀⠀⠀⠀⣰⣷⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀" +
                    "\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⡇⠀⠀⢠⠞⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡘⢹⡿⢿⣿⡿⠛⠻⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀" +
                    "\r\n⠀⠀⠀⠀⠀⠀⠀⠀⣀⣀⠤⣴⣧⠈⠱⠀⠈⠛⢦⣰⣦⣹⣆⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⢀⣴⣿⠋⠀⢠⡟⠀⠀⢁⠆⠀⠀⣠⠙⠻⣿⣿⣟⢄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀" +
                    "\r\n⠀⠀⢀⣠⣶⣿⣿⡏⠀⠀⣼⠃⠐⠀⡅⢠⡄⠀⡇⠀⠀⠈⠛⢿⡄⠱⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⢀⣴⣿⣿⣛⢻⢸⡇⠀⠀⢹⢓⠀⠀⠀⠙⠿⠀⠀⠀⠀⠀⠄⠀⠁⠎⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀" +
                    "\r\n⢿⣏⣽⣿⣿⣿⣿⠇⠀⠀⣾⠛⢷⣄⠀⠑⢄⠀⠀⠀⠀⢀⣴⣿⡿⠿⣶⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠹⣿⣿⣿⣿⠟⠀⠀⢰⡇⠀⠈⠙⢿⣦⣌⠑⠄⢀⣴⡿⠋⠀⠈⢆⠘⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀" +
                    "\r\n⠀⠀⠟⠛⠋⠀⠀⠀⠀⠈⢣⠀⠀⠀⠀⠉⠛⢿⡶⠛⡏⠀⠀⠀⠀⠀⠑⠘⢄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⡄⠀⠀⠀⠀⠀⢨⣿⡶⠃⠀⠀⠀⡀⠀⠀⠄⠈⠢⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀" +
                    "\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡄⣿⣄⠀⠀⠀⠀⢸⣿⠀⠀⠀⠀⠀⡁⣾⣯⠀⠀⠀⢸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢹⣿⣿⠟⠒⠂⠀⠚⠿⠦⠤⢄⡀⠀⠁⠟⠙⠁⠀⠀⡸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀" +
                    "\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢨⣿⡏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢡⠑⠀⠀⠀⢀⠔⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠑⠒⠋⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀" +
                    "\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣾⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
                Thread.Sleep(2500);
                Stables(command);
            }
        }

        private static void FeedHorse(string command)
        {
            Console.Clear();
            Random random = new Random();
            int randomNumber = random.Next(1, 11);

            if (randomNumber <= 5)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\r\n▀█▀ █░█ █▀▀   █░█ █▀█ █▀█ █▀ █▀▀   █▀█ █▀▀ ▄▀█ █░░ █░░ █▄█   █░░ █ █▄▀ █▀▀ █▀▄   ▀█▀ █░█ █▀▀   █▀▀ █▀█ █▀█ █▀▄" +
                    "\r\n░█░ █▀█ ██▄   █▀█ █▄█ █▀▄ ▄█ ██▄   █▀▄ ██▄ █▀█ █▄▄ █▄▄ ░█░   █▄▄ █ █░█ ██▄ █▄▀   ░█░ █▀█ ██▄   █▀░ █▄█ █▄█ █▄▀" +
                    "\r\n\r\n█▄█ █▀█ █░█   █▀▀ ▄▀█ █░█ █▀▀   █░█ █ █▀▄▀█ ░\r\n░█░ █▄█ █▄█   █▄█ █▀█ ▀▄▀ ██▄   █▀█ █ █░▀░█ ▄  🥕");
                Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⠀⠀⠀⠀⡀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⡏⣷⣄⢀⠼⡇⠀\r\n⠀⠀⠀⠀⠀⠀⠀⣀⣤⣶⠞⡩⠂⡽⢗⡥⣃⡱⣖⠁⠀\r\n⠀⠀⠀⠀⠀⣠⡾⢫⠟⣡⠊⢀⠴⠛⠉⠊⡽⠃⠈⢕⠄\r\n⠀⠀⠀⠀⢰⣟⢀⡏⢰⠃⠀⡆⠀⠀⣬⣢⠁⠀⠀⢠⠇" +
                    "\r\n⠀⠀⠀⠀⡿⡎⢸⠀⡏⠀⠀⠀⢠⠀⠀⠀⠀⡀⢠⢸⠀\r\n⠀⠀⢠⠁⡇⡇⠀⠁⡇⠀⠀⠀⣸⡀⠀⠀⠀⠰⠀⡆⠀\r\n⠠⢔⡏⠀⢻⣡⠀⠀⣿⠀⠀⢀⡇⠱⢤⡆⠀⠀⠀⠰⠀\r\n⠐⠉⣧⠀⠈⢷⡄⠀⠸⣧⡀⢸⢧⠀⠀⠐⡀⣲⠀⠀⡱\r\n⠀⠀⠸⡀⠀⠀⠻⣦⡀⠹⣷⣼⡀⢡⠀⠀⢡⠙⠃⢐⠃" +
                    "\r\n⠀⠀⠀⠃⠀⠀⠀⠈⠳⣄⠈⡟⠿⣦⡇⠀⠈⠙⠊⠁⠀\r\n⠀⠀⠀⡄⠀⠀⠀⠀⠀⠙⣷⠁⠀⠈⠷⡀⠀⠀⠀⠀⠀\r\n⠀⠀⠈⠀⠀⠀⠀⠀⠠⠞⠙⡆⠀⠘⠀⠰⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠁⠀⠀⠀⠀⠃⠀⠀⠀⠀");
                Thread.Sleep(2500);
                Stables(command);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\r\n▀█▀ █░█ █▀▀   █░█ █▀█ █▀█ █▀ █▀▀   █▀▄ █▀█ █▀▀ █▀   █▄░█ █▀█ ▀█▀   █░░ █ █▄▀ █▀▀ █▀▄   ▀█▀ █░█ █▀▀   █▀▀ █▀█ █▀█ █▀▄" +
                    "\r\n░█░ █▀█ ██▄   █▀█ █▄█ █▀▄ ▄█ ██▄   █▄▀ █▄█ ██▄ ▄█   █░▀█ █▄█ ░█░   █▄▄ █ █░█ ██▄ █▄▀   ░█░ █▀█ ██▄   █▀░ █▄█ █▄█ █▄▀" +
                    "\r\n\r\n█▄█ █▀█ █░█   █▀▀ ▄▀█ █░█ █▀▀   █░█ █ █▀▄▀█ ░\r\n░█░ █▄█ █▄█   █▄█ █▀█ ▀▄▀ ██▄   █▀█ █ █░▀░█ ▄");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("───────▄██████▄───────\r\n──────▐▀▀▀▀▀▀▀▀▌──────\r\n──────▌▌▀▀▌▐▀▀▐▐──────\r\n──────▐──▄▄▄▄──▌──────\r\n───────▌▐▌──▐▌▐───────\r\n");
                Thread.Sleep(2500);
                Stables(command);
            }
        }
    }
}
