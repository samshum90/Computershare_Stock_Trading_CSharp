using System;
using System.Linq;

namespace console
{
    public class Prices
    {
        private double? price = null;
        private int day = -1;

        public double buyPrice(string[] stockArray)
        {
            if (stockArray == null || stockArray.Length == 0 )
                throw new ArgumentNullException("Stock cannot be empty");

            // Using Linq
            // var doubleArray = Array.ConvertAll(stockArray, double.Parse);
            // price = doubleArray.Min();

            // Using a loop
            for (int i = 0; i < stockArray.Length; i++)
            {
                if (!price.HasValue || double.Parse(stockArray[i]) < price.Value)
                {
                    price = double.Parse(stockArray[i]);
                }
            }
            return price.Value;
        }
        public int buyDay(string[] stockArray)
        {
            if (stockArray == null || stockArray.Length == 0 )
                throw new ArgumentNullException("Stock cannot be empty");

            // Using Linq
            var doubleArray = Array.ConvertAll(stockArray, double.Parse);
            price = doubleArray.Min();
            day = Array.IndexOf(doubleArray, price) + 1;

            // Using a loop
            // for (int i = 0; i < stockArray.Length; i++)
            // {
            //     if (!price.HasValue || double.Parse(stockArray[i]) < price.Value)
            //     {
            //         index = i + 1;
            //     }
            // }
            return day;
        }
        public double sellPrice(string[] stockArray)
        {
            if (stockArray == null || stockArray.Length == 0 )
                throw new ArgumentNullException("Stock cannot be empty");

                 // Using Linq
                // var doubleArray = Array.ConvertAll(stockArray, double.Parse);
                // price = doubleArray.Max();

                // Using a loop
            for (int i = 0; i < stockArray.Length; i++)
            {
                if (!price.HasValue || double.Parse(stockArray[i]) > price.Value)
                {
                    price = double.Parse(stockArray[i]);
                }
            }
            return  price.Value;
        }

        public int sellDay(string[] stockArray)
        {
            if (stockArray == null || stockArray.Length == 0 )
                throw new ArgumentNullException("Stock cannot be empty");

            for (int i = 0; i < stockArray.Length; i++)
            {
                 // Using Linq
                var doubleArray = Array.ConvertAll(stockArray, double.Parse);
                price = doubleArray.Max();
                day = Array.IndexOf(doubleArray, price) + 1;

                // Using a loop
                // if (!price.HasValue || double.Parse(stockArray[i]) > price.Value)
                // {
                //     price = double.Parse(stockArray[i]);
                //     index = i + 1;
                // }
            }
            return day;
        }
    }
}