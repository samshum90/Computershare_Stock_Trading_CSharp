using System;
using System.Collections.Generic;
using console.Interfaces;

namespace console
{
    public class PriceService : IPriceService
    {
        
        private double? _price;

        public PriceService()
        {
            _price = null;
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
        public List<int> buyDay(string[] stockArray)
        {
            if (stockArray == null || stockArray.Length == 0 )
                throw new ArgumentNullException("Stock cannot be empty");

            var days = new List<int>();

            for (int i = 0; i < stockArray.Length; i++)
            {
                if (!_price.HasValue || double.Parse(stockArray[i]) < _price.Value)
                {
                    _price = double.Parse(stockArray[i]);
                }
            }
            for (int i = 0; i < stockArray.Length; i++)
            {
                if (double.Parse(stockArray[i]) == _price)
                {
                    days.Add( i + 1);
                }
            }
            return days;
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

        public List<int> sellDay(string[] stockArray)
        {
            if (stockArray == null || stockArray.Length == 0 )
                throw new ArgumentNullException("Stock cannot be empty");
            var days = new List<int>();

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
                }
            }
            for (int i = 0; i < stockArray.Length; i++)
            {
                if (double.Parse(stockArray[i]) == _price)
                {
                    days.Add( i + 1);
                }
            }
            return days;
        }
    }
}