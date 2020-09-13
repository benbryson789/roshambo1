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

        [Fact]
        public void ScissorsBeatsPaperTests()
        {
            //Arrange            
            var app = new RoshamboService();

            //Act
            var result = app.Play("Scissors", "Paper");

            //Assert
            Assert.Equal("Scissors beats Paper", result);
        }

        [Fact]
        public void RockTieTests()
        {
            //Arrange            
            var app = new RoshamboService();

            //Act
            var result = app.Play("Rock", "Rock");

            //Assert
            Assert.Equal("Tie", result);
        }

        [Fact]
        public void PaperTieTests()
        {
            //Arrange            
            var app = new RoshamboService();

            //Act
            var result = app.Play("Paper", "Paper");

            //Assert
            Assert.Equal("Tie", result);
        }

        [Fact]
        public void ScissorsTieTests()
        {
            //Arrange            
            var app = new RoshamboService();

            //Act
            var result = app.Play("Scissors", "Scissors");

            //Assert
            Assert.Equal("Tie", result);
        }
    }
}
