using SimpleWebApp.Services;

namespace UnitTesting
{
    public class UnitTest1
    {
        private readonly CalculatorService _calculator;

        public UnitTest1()
        {
            _calculator = new CalculatorService();
        }

        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            int a = 5;
            int b = 3;

            // Act
            int result = _calculator.Add(a, b);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            int a = 10;
            int b = 4;
            int result = _calculator.Subtract(a, b);
            Assert.Equal(6, result);
        }

        [Fact]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            int a = 7;
            int b = 6;
            int result = _calculator.Multiply(a, b);
            Assert.Equal(42, result);
        }

        [Fact]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            int a = 20;
            int b = 4;
            double result = _calculator.Divide(a, b);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_ShouldThrowDivideByZeroException()
        {
            int a = 10;
            int b = 0;
            Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
        }
    }
}