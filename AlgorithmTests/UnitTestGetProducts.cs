using SimpleAlgorithm;
using Xunit;

namespace AlgorithmTests
{
    public class UnitTestGetProducts
    {
        [Fact]
        public void Test1()
        {
            TestGetProducts(3);
        }
        [Theory]
        [InlineData(3)]
        public void TestGetProducts(double expected)
        {
            // Arrange
            Order order = new Order();
            // Act
            double result = order.GetAllProducts().Count;
            // Assert
            Assert.Equal(expected, result);
        }
    }
}