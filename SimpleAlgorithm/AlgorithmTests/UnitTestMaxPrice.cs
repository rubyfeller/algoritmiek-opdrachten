using SimpleAlgorithm;
using Xunit;

namespace AlgorithmTests
{
    public class UnitTestMaxPrice
    {
        [Fact]
        public void Test1()
        {
            TestMaximumPrice(48.95);
        }
        [Theory]
        [InlineData(48.95)]
        public void TestMaximumPrice(double expected)
        {
            // Arrange
            Order order = new Order();
            // Act
            double result = order.GiveMaximumPrice();
            // Assert
            Assert.Equal(expected, result);
        }
    }
}