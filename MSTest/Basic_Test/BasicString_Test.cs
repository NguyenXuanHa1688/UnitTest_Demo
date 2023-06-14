using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest_Demo.VeryBasic;

namespace MSTest.Basic_Test
{
    [TestClass]
    public class BasicString_Test
    {
        private BasicString? _basicString;
        [TestInitialize]
        public void TestInitialize()
        {
            _basicString = new BasicString();
        }

        [TestMethod]
        public void MyName_InputName_ReturnCorrectResult()
        {
            //Arange
            //BasicString basicString = new BasicString();
            //Act
            string result = _basicString.MyName("Ha", "Nguyen");
            //Assert
            result.Should().Be("Hello my name is Ha Nguyen");
            result.Should().Contain("Ha");
            result.Should().StartWith("Hello");
            result.Should().EndWith("Nguyen");
        }

        [TestMethod]
        public void MyName_InputInValid_ReturnNull()
        {
            //Arange
            //BasicString basicString = new BasicString();
            //Act 
            string result = _basicString.Message;
            //Assert
            result.Should().BeNull();
        }

        [TestMethod]
        public void MyName_InputValid_CheckTheNumberOfHello_ReturnCorrectResult()
        {
            //Arange
            int result = _basicString.NumberOfHello;
            //Act
            _basicString.MyName("Ha", "Nguyen");
            //Assert
            result.Should().BeInRange(0, 2);
        }

        [TestMethod]
        public void MyName_InvalidInput_CheckThrowException()
        {
            var result = _basicString.Invoking(x => x.MyName(null, "Nguyen"))
                                                        .Should().Throw<ArgumentException>()
                                                        .WithMessage("Invalid Input");
            var result_2 = _basicString.Invoking(x => x.MyName("Ha", null))
                                                        .Should().Throw<ArgumentException>()
                                                        .WithMessage("Invalid Input");
            var result_3 = _basicString.Invoking(x => x.MyName(null, null))
                                                        .Should().Throw<ArgumentException>()
                                                        .WithMessage("Invalid Input");
        }

        [TestMethod]
        public void GetString_CheckHeritage()
        {
            _basicString.NumberOfHello = 0;
            var result = _basicString.GetString()
                                        .Should()
                                        .BeOfType<childAString>();
        }
    }
}
