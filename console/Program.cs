using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
            PriceService priceService = new PriceService();

            System.Console.WriteLine("----------------------------------");
            System.Console.WriteLine("Computershare Stock Prices");
            System.Console.WriteLine("----------------------------------");
            System.Console.WriteLine("");
            while (true)
            {
                System.Console.WriteLine("Please select a Month you would like the opening stock prices of");
                string LastMonth = DateTime.Now.AddMonths(-1).ToString("MMMM");
                Console.WriteLine("1. " + LastMonth);
                string SecondMonth = DateTime.Now.AddMonths(-2).ToString("MMMM");
                Console.WriteLine("2. " + SecondMonth);
                Console.WriteLine("quit to exit");

                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    Console.WriteLine("Program exited!");
                    break;
                }

                // open the text file to get the numbers
                string text = null;
                if (input == "1")
                {
                    text = System.IO.File.ReadAllText("./Data/ChallengeSampleDataSet1.txt");

                }
                if (input == "2")
                {
                    text = System.IO.File.ReadAllText("./Data/ChallengeSampleDataSet2.txt");

                }
                // convert to an array
                var array = text.Split(',');
                System.Console.WriteLine("Buy day(Price), Sell day(Price)");
                System.Console.WriteLine( string.Join(", ", priceService.buyDay(array)) + "(" + priceService.buyPrice(array) + "), " + string.Join(", ",priceService.sellDay(array)) + "(" + priceService.sellPrice(array) + ")");
                continue;
            }
        }
    }
}
