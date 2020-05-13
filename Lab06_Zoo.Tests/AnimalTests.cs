using System;
using Xunit;

namespace Lab06_Zoo.Tests
{
    public class Lab06_Zoo
    {

        [Fact]
        public void Third_level_concrete_to_animal_inheritance()
        {
            // Arrange
            Animal tiger = new Tiger();

            // Act
            string result = tiger.Sound();

            // Assert
            Assert.Equal("Rawr!", result);
        }

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
        /// <summary>
        /// Interface polymorphism displayed between these two tests
        /// </summary>
        [Fact]
        public void Interface_subclass_override()
        {
            // Arrange
            Bird owl = new Owl();

            // Act
            string result = owl.Fly();

            // Assert
            Assert.Equal("The owl swoops at unsuspecting prey.", result);
        }
        
        [Fact]
        public void Testing_interface_on_second_class()
        {
            // Arrange
            PolarBear polarBear = new PolarBear();

            // Act
            string result = polarBear.Fly();

            // Assert
            Assert.Equal("Polar bears with wings!", result);
        }
    }
}
