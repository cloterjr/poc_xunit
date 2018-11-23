using Application;
using System.Reflection;
using Xunit;

namespace Tests
{
    public class CalculatorTest : Calculator
    {
        [Fact]
        public void SumTest()
        {
            Assert.Equal(4, Calculator.Add(1, 3));
        }

        [Fact]
        public void SubTest()
        {
            Assert.Equal(2, Calculator.Sub(4, 2));
        }

        [Fact]
        public void ValidatePrivateMethod()
        {
            var v1 = 10;
            var v2 = 2;

            var result = v1 + v2;

            Calculator objUnderTest = new Calculator();
            MethodInfo methodInfo = typeof(Calculator).GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);
            object[] parameters = { v1, v2 };
            Assert.Equal(result, (double)methodInfo.Invoke(objUnderTest, parameters));
        }
    }
}
