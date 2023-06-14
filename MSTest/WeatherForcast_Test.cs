using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest_Demo.Controllers;

namespace MSTest
{
    [TestClass]
    public class WeatherForcast_Test
    {
        private WeatherForecastController _controller;
        [TestInitialize]
        public void TestInit()
        {
            var _logger = new Mock<ILogger<WeatherForecastController>>();
            _controller = new WeatherForecastController(_logger.Object);
        }
        [TestMethod]
        public void Get_ReturnsFiveWeatherForecasts()
        {
            // Arrange
            //var logger = new Mock<ILogger<WeatherForecastController>>();
            //var controller = new WeatherForecastController(logger.Object);

            // Act
            var result = _controller.Get();

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(5, result.Count());
        }
    }
}
