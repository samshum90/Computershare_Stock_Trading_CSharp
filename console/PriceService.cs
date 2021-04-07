using System;
using console.Interfaces;

namespace console
{
    public class PriceService : IPriceService
    {
        
        private double? _price;
        private int _day;

        public PriceService()
        {
            _price = null;
            _day = -1;
        }

        public double buyPrice(string[] stockArray)
        {
            if (stockArray == null || stockArray.Length == 0 )
                throw new ArgumentNullException("Stock cannot be empty");

            // Using Linq
            // var doubleArray = Array.ConvertAll(stockArray, double.Parse);
            // _price = doubleArray.Min();

            // Using a loop
            for (int i = 0; i < stockArray.Length; i++)
            {
                if (!_price.HasValue || double.Parse(stockArray[i]) < _price.Value)
                {
                    _price = double.Parse(stockArray[i]);
                }
            }
            return _price.Value;
        }
        public int buyDay(string[] stockArray)
        {
            if (stockArray == null || stockArray.Length == 0 )
                throw new ArgumentNullException("Stock cannot be empty");

            // Using Linq
            // var doubleArray = Array.ConvertAll(stockArray, double.Parse);
            // _price = doubleArray.Min();
            // _day = Array.IndexOf(doubleArray, _price) + 1;

            // Using a loop
            for (int i = 0; i < stockArray.Length; i++)
            {
                if (!_price.HasValue || double.Parse(stockArray[i]) < _price.Value)
                {
                    _price = double.Parse(stockArray[i]);
                    _day = i + 1;
                }
            }
            return _day;
        }
        public double sellPrice(string[] stockArray)
        {
            if (stockArray == null || stockArray.Length == 0 )
                throw new ArgumentNullException("Stock cannot be empty");

                 // Using Linq
                // var doubleArray = Array.ConvertAll(stockArray, double.Parse);
                // _price = doubleArray.Max();

                // Using a loop
            for (int i = 0; i < stockArray.Length; i++)
            {
                if (!_price.HasValue || double.Parse(stockArray[i]) > _price.Value)
                {
                    _price = double.Parse(stockArray[i]);
                }
            }
            return  _price.Value;
        }

        public int sellDay(string[] stockArray)
        {
            if (stockArray == null || stockArray.Length == 0 )
                throw new ArgumentNullException("Stock cannot be empty");

            for (int i = 0; i < stockArray.Length; i++)
            {
                 // Using Linq
                // var doubleArray = Array.ConvertAll(stockArray, double.Parse);
                // _price = doubleArray.Max();
                // _day = Array.IndexOf(doubleArray, _price) + 1;

                // Using a loop
                if (!_price.HasValue || double.Parse(stockArray[i]) > _price.Value)
                {
                    _price = double.Parse(stockArray[i]);
                    _day = i + 1;
                }
            }
            return _day;
        }
    }
}