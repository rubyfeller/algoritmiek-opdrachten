using SimpleAlgorithm;
using Xunit;

namespace AlgorithmTests
{
    public class UnitTestAvgPrice
    {
        [Fact]
        public void Test1()
        {
            TestAvgPrice(34.46666666666667);
        }
        [Theory]
        [InlineData(34.46666666666667)]
        public void TestAvgPrice(double expected)
        {
            // Arrange
            Order order = new Order();
            // Act
            double result = order.GiveAveragePrice();
            // Assert
            Assert.Equal(expected, result);
        }
    }
}