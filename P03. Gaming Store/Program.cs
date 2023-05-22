namespace P3._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceOutFall4 = 39.99;
            double priceCsOg = 15.99;
            double priceZplinterZell = 19.99;
            double priceHonored2 = 59.99;
            double priceRoverWatch = 29.99;
            double priceRoverWatchOriginsEdition = 39.99;

            double balanceCurrent = double.Parse(Console.ReadLine());
            string nameOfGame = string.Empty;
            double balanceSpent = 0;
            while ((nameOfGame =Console.ReadLine()) != "Game Time" )
            {
                if (balanceCurrent >= 0)
                {


                    if (balanceCurrent == 0)
                    {
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    switch (nameOfGame)
                    {


                        case "OutFall 4":
                            if (priceOutFall4 > balanceCurrent)
                            {
                                Console.WriteLine("Too Expensive");
                                break;
                            }
                            balanceSpent += priceOutFall4;
                            balanceCurrent -= priceOutFall4;
                            Console.WriteLine($"Bought {nameOfGame}");
                            break;
                        case "CS: OG":
                            if (priceCsOg > balanceCurrent)
                            {
                                Console.WriteLine("Too Expensive");
                                break;
                            }
                            balanceSpent += priceCsOg;
                            balanceCurrent -= priceCsOg;
                            Console.WriteLine($"Bought {nameOfGame}");
                            break;
                        case "Zplinter Zell":
                            if (priceZplinterZell > balanceCurrent)
                            {
                                Console.WriteLine("Too Expensive");
                                break;
                            }
                            balanceSpent += priceZplinterZell;
                            balanceCurrent -= priceZplinterZell;
                            Console.WriteLine($"Bought {nameOfGame}");
                            break;
                        case "Honored 2":
                            if (priceHonored2 > balanceCurrent)
                            {
                                Console.WriteLine("Too Expensive");
                                break;
                            }
                            balanceSpent += priceHonored2;
                            balanceCurrent -= priceHonored2;
                            Console.WriteLine($"Bought {nameOfGame}");
                            break;
                        case "RoverWatch":
                            if (priceRoverWatch > balanceCurrent)
                            {
                                Console.WriteLine("Too Expensive");
                                break;
                            }
                            balanceSpent += priceRoverWatch;
                            balanceCurrent -= priceRoverWatch;
                            Console.WriteLine($"Bought {nameOfGame}");
                            break;
                        case "RoverWatch Origins Edition":
                            if (priceRoverWatchOriginsEdition > balanceCurrent)
                            {
                                Console.WriteLine("Too Expensive");
                                break;
                            }
                            balanceSpent += priceRoverWatchOriginsEdition;
                            balanceCurrent -= priceRoverWatchOriginsEdition;
                            Console.WriteLine($"Bought {nameOfGame}");
                            break;
                        default:
                            Console.WriteLine("Not Found");
                            break;
                    }
                }
            }
                Console.WriteLine($"Total spent: ${balanceSpent:F2}. Remaining: ${balanceCurrent:F2}");
        }
    }
}