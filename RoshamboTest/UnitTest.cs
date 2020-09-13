using Roshambo;
using System;
using Xunit;

namespace RoshamboTest
{
    public class UnitTest
    {
        [Fact]
        public void RockBeatsScissorsTests()
        {
            //Arrange            
            var app = new RoshamboService();

            //Act
            var result = app.Play("Rock", "Scissors");

            //Assert
            Assert.Equal("Rock beats Scissors", result);
        }

        [Fact]
        public void PaperBeatsRockTests()
        {
            //Arrange            
            var app = new RoshamboService();

            //Act
            var result = app.Play("Rock", "Paper");

            //Assert
            Assert.Equal("Paper beats Rock", result);
        }
    }
}
