using Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Extensions;

namespace Tests
{
    public class NumberCheckerTest
    {
        [Theory]
        [InlineData(9, true)]
        [InlineData(10, false)]
        [InlineData(11, false)]
        [InlineData(13, true)]
        [Trait("Category", "InLineData")]
        public void TestLessThanMethod(int numberToCompare, bool expectedResult)
        {
            var checker = new NumberChecker();

            var result = checker.LessThanTen(numberToCompare);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [MemberData("TestData", MemberType = typeof(PropertyTestDataSource))]
        [Trait("Category", "PropertyData")]
        public void TestLessThanMethodWithPropertyData(int numberToCompare, bool expectedResult)
        {
            var checker = new NumberChecker();

            var result = checker.LessThanTen(numberToCompare);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [RangeData(1,10)]
        [Trait("Category", "PropertyData")]
        public void TestLessThanMethodWithCustomRangeData(int number)
        {
            Assert.True(true);
        }
    }
}
