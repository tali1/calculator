using Calculator;
using Xunit;

namespace Tests
{
    public class CalculatorUnitTests
    {
        private readonly CalculatorApp calculator = new CalculatorApp();

        [Fact]
        public void Calculator_Sum()
        {
            var result = calculator.Sum(5, 7);
            Assert.Equal(12, result);
        }

        [Fact]
        public void Calculator_Substract()
        {
            var result = calculator.Substract(5, 7);
            Assert.Equal(-2, result);

        }

        [Fact]
        public void Calculator_Multiply()
        {
            var result = calculator.Multiply(5, 7);
            Assert.Equal(35, result);
        }

        [Fact]
        public void Calculator_Divide()
        {
            var result = calculator.Divide(4, 0);
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(9, false)]
        [InlineData(12, false)]
        [InlineData(11, true)]
        [InlineData(7, true)]
        [InlineData(5, true)]
        [InlineData(1, true)]
        [InlineData(2, true)]
        public void Calculator_IsPrime(int number, bool expectedResult)
        {
            var result = calculator.IsPrime(number);
            Assert.Equal(expectedResult, result);
        }
    }
}