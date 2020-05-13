using System;
using Xunit;

namespace Lab06_Zoo.Tests
{
    public class Lab06_Zoo
    {

        /// <summary>
        /// Interface testing below
        /// </summary>
        
        [Fact]
        public void Interface_ineritance_test_bird_to_peacock()
        {
            // Arrange
            Bird peacock = new Peacock();

            // Act
            string result = peacock.Fly();

            // Assert
            Assert.Equal("All of our birds know how to fly, but we will have penguins soon!", result);
        }
    }
}
