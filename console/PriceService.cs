using System;
using System.Collections.Generic;
using System.Linq;
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

            var doubleArray = Array.ConvertAll(stockArray, double.Parse);
            _price = doubleArray.Min();

            return doubleArray
                     .Select((v,i)=>new {Index = i, Value = v})
                     .Where(x=>x.Value == _price)
                     .Select(x=>x.Index + 1)
                     .ToList();
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

            var doubleArray = Array.ConvertAll(stockArray, double.Parse);
            _price = doubleArray.Max();

            return doubleArray
                     .Select((v,i)=>new {Index = i, Value = v})
                     .Where(x=>x.Value == _price)
                     .Select(x=>x.Index + 1)
                     .ToList();
        }
    }
}