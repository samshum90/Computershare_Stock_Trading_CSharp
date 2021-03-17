using System;
using System.Collections.Generic;
using Xunit;

namespace console.tests
{
    public class UnitTest1
    {
        private readonly PriceService _priceService;
        private readonly string[] _arrayOfStockPrices;

        public UnitTest1()
        {
            // Arrange
            _priceService = new PriceService();
            _arrayOfStockPrices = new string[] {"15.28","27.39","17.05","16.59","21.09","16.22","21.43","27.13","18.62","21.31","23.96","25.52","19.64","23.49","15.28","22.77","23.1","26.58","27.03","23.75","27.39","15.93","17.83","18.82" };
        }

        [Fact]
        public void buyPriceNullArgumentReturnNullException()
        {
            //Arrange
            var message = "Value cannot be null. (Parameter 'Stock cannot be empty')";
            // Act & Assert
            var exception = Assert.Throws<ArgumentNullException>(() => _priceService.buyPrice(null));
            Assert.Equal(message, exception.Message);
        }

        [Fact]
        public void buyPriceEmptyArgumentReturnNullException()
        {
            //Arrange
            var message = "Value cannot be null. (Parameter 'Stock cannot be empty')";
            string[] emptyArray = new String[0];

            // Act & Assert
            var exception = Assert.Throws<ArgumentNullException>(() => _priceService.buyPrice(emptyArray));
            Assert.Equal(message, exception.Message);
        }

        [Fact]
        public void buyPriceReturnPrice()
        {

            // Act 
            var buyPriceResult = _priceService.buyPrice(_arrayOfStockPrices);
            // Assert
            Assert.Equal(15.28, buyPriceResult);

        }

        [Fact]
        public void buyDayNullArgumentReturnNullException()
        {
            //Arrange
            var message = "Value cannot be null. (Parameter 'Stock cannot be empty')";
            // Act & Assert
            var exception = Assert.Throws<ArgumentNullException>(() => _priceService.buyDay(null));
            Assert.Equal(message, exception.Message);
        }

        [Fact]
        public void buyDayEmptyArgumentReturnNullException()
        {
            //Arrange
            var message = "Value cannot be null. (Parameter 'Stock cannot be empty')";
            string[] emptyArray = new String[0];

            // Act & Assert
            var exception = Assert.Throws<ArgumentNullException>(() => _priceService.buyDay(emptyArray));
            Assert.Equal(message, exception.Message);
        }

        [Fact]
        public void buyDayReturnDay()
        {

            // Act 
            var buyDayResult = _priceService.buyDay(_arrayOfStockPrices);

            // Assert
            Assert.Equal(new List<int> { 1, 15 }, buyDayResult);

        }


        [Fact]
        public void sellPriceNullArgumentReturnNullException()
        {
            //Arrange
            var message = "Value cannot be null. (Parameter 'Stock cannot be empty')";
            // Act & Assert
            var exception = Assert.Throws<ArgumentNullException>(() => _priceService.sellPrice(null));
            Assert.Equal(message, exception.Message);
        }

        [Fact]
        public void sellPriceEmptyArgumentReturnNullException()
        {
            //Arrange
            var message = "Value cannot be null. (Parameter 'Stock cannot be empty')";
            string[] emptyArray = new String[0];

            // Act & Assert
            var exception = Assert.Throws<ArgumentNullException>(() => _priceService.sellPrice(emptyArray));
            Assert.Equal(message, exception.Message);
        }

        [Fact]
        public void sellPriceReturnPrice()
        {

            // Act 
            var sellPriceResult = _priceService.sellPrice(_arrayOfStockPrices);
            // Assert
            Assert.Equal(27.39, sellPriceResult);

        }

        [Fact]
        public void sellDayNullArgumentReturnNullException()
        {
            //Arrange
            var message = "Value cannot be null. (Parameter 'Stock cannot be empty')";
            // Act & Assert
            var exception = Assert.Throws<ArgumentNullException>(() => _priceService.sellDay(null));
            Assert.Equal(message, exception.Message);
        }

        [Fact]
        public void sellDayEmptyArgumentReturnNullException()
        {
            //Arrange
            var message = "Value cannot be null. (Parameter 'Stock cannot be empty')";
            string[] emptyArray = new String[0];

            // Act & Assert
            var exception = Assert.Throws<ArgumentNullException>(() => _priceService.sellDay(emptyArray));
            Assert.Equal(message, exception.Message);
        }

        [Fact]
        public void sellDayReturnDay()
        {

            // Act 
            var sellDayResult = _priceService.sellDay(_arrayOfStockPrices);
            // Assert
            Assert.Equal(new List<int> { 2, 21}, sellDayResult);

        }
    }
}
