using AK_BasicApp_Github;
using Xunit;

namespace AK_BasicApp_GitHub.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestNameProperty()
        {
            // Arrange
            Class1 tp = new Class1();
            // Act
            var result = tp.Name;
            // Assert
            Assert.Equal("[Adam Kostura] - AutoCoder", result);
        }
    }
}