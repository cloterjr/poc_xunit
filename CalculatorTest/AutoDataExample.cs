using Application;
using AutoFixture.Xunit2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{

    public class AutoDataExample
    {
        [Theory]
        [AutoData()]
        public void SingleAutoData(int number1, int number2)
        {
            var result = Calculator.Add(number1, number2);

            Assert.Equal(number1 + number2, result);
        }

        [Theory]
        [AutoData()]
        public void AutoDataTypes(string a, Person person)
        {
            Assert.True(true);
        }

        [Theory]
        [InlineAutoData(42, 33)]
        [InlineAutoData(42)]
        [InlineAutoData()]
        public void InlineAutoData(int number1, int number2)
        {
            var result = Calculator.Add(number1, number2);

            Assert.Equal(number1 + number2, result);
        }
    }
}
