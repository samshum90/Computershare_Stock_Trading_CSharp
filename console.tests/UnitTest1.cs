using System;
using System.Collections.Generic;
using Xunit;

namespace console.tests
{
    public class UnitTest1
    {
        private readonly Prices _prices;
        private readonly string[] _arrayOfStockPrices;

        public UnitTest1()
        {
            // Arrange
            _prices = new Prices();
            _arrayOfStockPrices = new string[] {"18.93","20.25","17.05","16.59","21.09","16.22","21.43","27.13","18.62","21.31","23.96","25.52","19.64","23.49","15.28","22.77","23.1","26.58","27.03","23.75","27.39","15.93","17.83","18.82" };
        }

        [Fact]
        public void buyPriceNullArgumentReturnNullException()
        {
            //Arrange
            var message = "Value cannot be null. (Parameter 'Stock cannot be empty')";
            // Act & Assert
            var exception = Assert.Throws<ArgumentNullException>(() => _prices.buyPrice(null));
            Assert.Equal(message, exception.Message);
        }

        [Fact]
        public void buyPriceEmptyArgumentReturnNullException()
        {
            //Arrange
            var message = "Value cannot be null. (Parameter 'Stock cannot be empty')";
            string[] emptyArray = new String[0];

            // Act & Assert
            var exception = Assert.Throws<ArgumentNullException>(() => _prices.buyPrice(emptyArray));
            Assert.Equal(message, exception.Message);
        }

        [Fact]
        public void buyPriceReturnPrice()
        {

            // Act 
            var buyPriceResult = _prices.buyPrice(_arrayOfStockPrices);
            // Assert
            Assert.Equal(15.28, buyPriceResult);

        }

        [Fact]
        public void buyDayNullArgumentReturnNullException()
        {
            //Arrange
            var message = "Value cannot be null. (Parameter 'Stock cannot be empty')";
            // Act & Assert
            var exception = Assert.Throws<ArgumentNullException>(() => _prices.buyDay(null));
            Assert.Equal(message, exception.Message);
        }

        [Fact]
        public void buyDayEmptyArgumentReturnNullException()
        {
            //Arrange
            var message = "Value cannot be null. (Parameter 'Stock cannot be empty')";
            string[] emptyArray = new String[0];

            // Act & Assert
            var exception = Assert.Throws<ArgumentNullException>(() => _prices.buyDay(emptyArray));
            Assert.Equal(message, exception.Message);
        }

        [Fact]
        public void buyDayReturnDay()
        {

            // Act 
            var buyDayResult = _prices.buyDay(_arrayOfStockPrices);
            // Assert
            Assert.Equal(15, buyDayResult);

        }


        [Fact]
        public void sellPriceNullArgumentReturnNullException()
        {
            //Arrange
            var message = "Value cannot be null. (Parameter 'Stock cannot be empty')";
            // Act & Assert
            var exception = Assert.Throws<ArgumentNullException>(() => _prices.sellPrice(null));
            Assert.Equal(message, exception.Message);
        }

        [Fact]
        public void sellPriceEmptyArgumentReturnNullException()
        {
            //Arrange
            var message = "Value cannot be null. (Parameter 'Stock cannot be empty')";
            string[] emptyArray = new String[0];

            // Act & Assert
            var exception = Assert.Throws<ArgumentNullException>(() => _prices.sellPrice(emptyArray));
            Assert.Equal(message, exception.Message);
        }

        [Fact]
        public void sellPriceReturnPrice()
        {

            // Act 
            var sellPriceResult = _prices.sellPrice(_arrayOfStockPrices);
            // Assert
            Assert.Equal(27.39, sellPriceResult);

        }

        [Fact]
        public void sellDayNullArgumentReturnNullException()
        {
            //Arrange
            var message = "Value cannot be null. (Parameter 'Stock cannot be empty')";
            // Act & Assert
            var exception = Assert.Throws<ArgumentNullException>(() => _prices.sellDay(null));
            Assert.Equal(message, exception.Message);
        }

        [Fact]
        public void sellDayEmptyArgumentReturnNullException()
        {
            //Arrange
            var message = "Value cannot be null. (Parameter 'Stock cannot be empty')";
            string[] emptyArray = new String[0];

            // Act & Assert
            var exception = Assert.Throws<ArgumentNullException>(() => _prices.sellDay(emptyArray));
            Assert.Equal(message, exception.Message);
        }

        [Fact]
        public void sellDayReturnDay()
        {

            // Act 
            var sellDayResult = _prices.sellDay(_arrayOfStockPrices);
            // Assert
            Assert.Equal(21, sellDayResult);

        }
    }
}
