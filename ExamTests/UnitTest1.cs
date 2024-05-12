using Ansver;
namespace ExamTests
{
    public class UnitTest1
    {

        [Fact]
        public void Constructor_InitializesPropertiesCorrectly()
        {
            // Arrange
            int storonaValue = 5; // Example value for storona
            var expectedPloshad = 10;
            var expectedPerimeter = 20;

            // Act
            var class1Instance = new Class1(storonaValue);

            // Assert
            Assert.Equal(storonaValue, class1Instance.storona);
            Assert.Equal(expectedPloshad, class1Instance.ploshad);
            Assert.Equal(expectedPerimeter, class1Instance.perimeter);
        }
    }
}