using System;

namespace console
{
    class Program
    {
        static void Main(string[] args)
        {
        // open the text file to get the numbers
            string text = System.IO.File.ReadAllText("./Data/ChallengeSampleDataSet1.txt");
            
        // convert to an array
            var array = text.Split(',');

            float? sellPrice = null;
            int sellIndex = -1;

            float? buyPrice = null;
            int buyIndex = -1;

            for (int i = 0; i < array.Length; i++)
        {
                Console.WriteLine(float.Parse(array[i]));
                if (!sellPrice.HasValue || float.Parse(array[i]) > sellPrice.Value)
            {
                sellPrice = float.Parse(array[i]);
                sellIndex = i + 1;
            }

            if (!buyPrice.HasValue || float.Parse(array[i]) < buyPrice.Value)
            {
                buyPrice = float.Parse(array[i]);
                buyIndex = i + 1;
            }
        }
            Console.WriteLine( buyIndex + "(" + buyPrice + "), " + sellIndex +"(" + sellPrice + ")");
        }
    }
}
