using FluentAssertions;
using UnitTest_Demo.VeryBasic;

namespace MSTest.Basic_Test
{
    [TestClass]
    public class BasicTest
    {
        private Caculator _caculator;
        [TestInitialize]
        public void TestInitialize()
        {
            _caculator = new Caculator();
        }

        [TestMethod]
        public void AddNumbers_InputTwoInt_GetCorrectResult()
        {
            //Arrange
            Caculator caculator = new Caculator();
            //Act
            int result = caculator.AddNumber(10, 12);
            //Assert
            result.Should().Be(22);
        }

        [TestMethod]
        public void AddNumbers_InputTwoInt_GetWrongResult()
        {
            //Arrange
            Caculator caculator = new Caculator();
            //Act
            int result = caculator.AddNumber(10, 12);
            //Assert
            result.Should().NotBe(100);
        }

        [TestMethod]

        public void IsOddNUmber_InputNumber_GiveCorrectResult()
        {
            //Arange
            Caculator caculator = new Caculator();
            //Act
            bool result = caculator.IsOddNumber(10);
            //Assert
            result.Should().BeFalse();
        }

        [TestMethod]
        public void GetOddRange_InputAListOfNumber_ReturnAListOfOddNumber()
        {
            //Arange
            List<int> expectedResult = new List<int>() { 3, 5, 7, 9 };
            //Act
            List<int> result = _caculator.GetOddRange(3, 10);
            //Assert
            result.Should().Equal(expectedResult);
            result.Should().Contain(3);
            result.Count.Should().Be(4);
            result.Should().BeInAscendingOrder();
        }
    }
}