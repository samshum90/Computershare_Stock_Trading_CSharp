using System;
using System.IO;

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
                System.Console.WriteLine("Please select a file you would like to open");
                string[] files = Directory.GetFiles("./Data", "*.txt", SearchOption.AllDirectories);
                 for (int i = 0; i < files.Length ; i++)
                {
                    System.Console.WriteLine($"{i + 1}. {files[i].Remove(0,7)}");
                }
                Console.WriteLine("quit to exit");

                string input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    Console.WriteLine("Program exited!");
                    break;
                }

                // open the text file to get the numbers
                string text = null;
                if (int.Parse(input) > 0 && int.Parse(input) < files.Length + 1)
                {
                    text = System.IO.File.ReadAllText($"{files[int.Parse(input) - 1]}");

                }

                // convert to an array
                var array = text.Split(',');
                System.Console.WriteLine("Buy day(Price), Sell day(Price)");
                System.Console.WriteLine( priceService.buyDay(array) + "(" + priceService.buyPrice(array) + "), " + priceService.sellDay(array) + "(" + priceService.sellPrice(array) + ")");
                continue;
            }
        }
    }
}
