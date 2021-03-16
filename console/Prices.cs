using System;
using System.Linq;

namespace console
{
    public class Prices
    {
        private float? price = null;
        private int index = -1;

        public string buyPrice(string[] stockArray)
        {
            price = float.Parse(stockArray.Max());
            index = Array.IndexOf(stockArray, price);
            // for (int i = 0; i < stockArray.Length; i++)
            // {
            //     if (!price.HasValue || float.Parse(stockArray[i]) > price.Value)
            //     {
            //         price = float.Parse(stockArray[i]);
            //         index = i + 1;
            //     }
            // }
            return index.ToString() + "(" + price.ToString() + ")";
        }
        public string sellPrice(string[] stockArray)
        {
            for (int i = 0; i < stockArray.Length; i++)
            {
                if (!price.HasValue || float.Parse(stockArray[i]) < price.Value)
                {
                    price = float.Parse(stockArray[i]);
                    index = i + 1;
                }
            }
            return index.ToString() + "(" + price.ToString() + ")";
        }
    }
}