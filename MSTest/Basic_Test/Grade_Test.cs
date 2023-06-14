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
    public class Grade_Test
    {
        private GradingPoint _gradingPoint;
        [TestInitialize]
        public void TestInitialize()
        {
            _gradingPoint = new GradingPoint();
        }

        [TestMethod]
        public void GetGrade_InputAScore_GetAResult()
        {
            _gradingPoint.Score = 96;
            _gradingPoint.BehaviorScore = 88;
            var result = _gradingPoint.GetGrade()
                                        .Should()
                                        .Be("A");
        }

        [TestMethod]
        public void GetGrade_InputBScore_GetBResult()
        {
            _gradingPoint.Score = 82;
            _gradingPoint.BehaviorScore = 66;
            var result = _gradingPoint.GetGrade()
                                        .Should()
                                        .Be("B");
        }

        [TestMethod]
        public void GetGrade_InputCScore_GetCResult()
        {
            _gradingPoint.Score = 62;
            _gradingPoint.BehaviorScore = 41;
            var result = _gradingPoint.GetGrade()
                                        .Should()
                                        .Be("C");
        }
        [TestMethod]
        public void GetGrade_InputFScore_GetFResult()
        {
            _gradingPoint.Score = 100;
            _gradingPoint.BehaviorScore = 0;
            var result = _gradingPoint.GetGrade()
                                        .Should()
                                        .Be("F");
        }
    }
}
