using System;
using System.Linq;

namespace console
{
    public class Prices
    {
        private float? price = null;
        private int day = -1;

        public string buyPrice(string[] stockArray)
        {
            // Using Linq
            var floatArray = Array.ConvertAll(stockArray, float.Parse);
            price = floatArray.Max();
            day = Array.IndexOf(floatArray, price) + 1;

            // Using a loop
            // for (int i = 0; i < stockArray.Length; i++)
            // {
            //     if (!price.HasValue || float.Parse(stockArray[i]) > price.Value)
            //     {
            //         price = float.Parse(stockArray[i]);
            //         index = i + 1;
            //     }
            // }
            return day.ToString() + "(" + price.ToString() + ")";
        }
        public string sellPrice(string[] stockArray)
        {
            for (int i = 0; i < stockArray.Length; i++)
            {
                 // Using Linq
                var floatArray = Array.ConvertAll(stockArray, float.Parse);
                price = floatArray.Min();
                day = Array.IndexOf(floatArray, price) + 1;

                // Using a loop
                // if (!price.HasValue || float.Parse(stockArray[i]) < price.Value)
                // {
                //     price = float.Parse(stockArray[i]);
                //     index = i + 1;
                // }
            }
            return day.ToString() + "(" + price.ToString() + ")";
        }
    }
}