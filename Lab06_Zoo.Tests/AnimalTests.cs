using System;
using Xunit;

namespace Lab06_Zoo.Tests
{
    public class Lab06_Zoo
    {
        [Fact]
        public void Can_birds_fly()
        {
            // Arrange
            Bird peacock = new Peacock();

            // Act
            string result = peacock.Fly();

            // Assert
            Assert.Equal("All of our birds know how to fly, but we will have penguins soon", result);
        }
    }
}
