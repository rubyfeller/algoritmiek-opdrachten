using CircusTrein.Logic.Models;
using Xunit;

namespace CircusTrein.UnitTests
{
    public class TrainTests
    {
        [Fact]
        public void TrainCanBeCreatedAndIsEmptyTest()
        {
            // Arrange
            Train train = new Train();

            // Assert
            Assert.Empty(train.Wagons);
        }
    }
}
