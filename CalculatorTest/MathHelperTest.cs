using CalculatorApp;

namespace CalculatorTest
{
    public class MathHelperTest
    {
        
        [Fact]
        public void IsEven()
        {
            var calculator = new MathFormulas();
            int x = 2;
            int y = 3;

            var xResult = calculator.IsEven(x);
            var yResult = calculator.IsEven(y);

            Assert.True(xResult);
            Assert.False(yResult);
            
            //Assert.True(calculator.IsEven(x));
        }
        [Theory]
        [InlineData(1, 2, -1)]
        public void SubtractTest(int x, int y, int expected)
        {
            var result = MathFormulas.Subtract(x, y);
            Assert.Equal(expected, result);
        }
        
    }
}