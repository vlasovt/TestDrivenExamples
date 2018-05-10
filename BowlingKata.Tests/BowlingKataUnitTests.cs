using System;
using Xunit;

namespace BowlingKata.Tests
{
    public class BowlingKataUnitTests
    {
        private Game g;

        public BowlingKataUnitTests()
        {
            g = new Game();
        }

        public void RollMany(int rolls, int pins)
        {
            for (int i = 0; i < rolls; i++)
            {
                g.Roll(pins);
            }
        }

        [Fact]
        public void DoesGameExist()
        {
            //Arrange

            //Act

            //Assert
            Assert.NotNull(g);
        }

        [Fact]
        public void GutterGameReturns0()
        {
            //Arrange
            var rolls = 20;
            var pins = 0;

            //Act
            RollMany(rolls, pins);

            //Assert
            Assert.Equal(0, g.ScoreGame);
        }

        [Fact]
        public void SinglePinGameReturns20()
        {
            //Arrange
            var rolls = 20;
            var pins = 1;

            //Act
            RollMany(rolls, pins);

            //Assert
            Assert.Equal(20, g.ScoreGame);
        }

        [Fact]
        public void OneSpareReturnsAppropriateValue()
        {
            //Arrange
            g.Roll(5);
            g.Roll(5); //spare
            g.Roll(3);

            var rolls = 17;
            var pins = 0;

            //Act
            RollMany(rolls, pins);

            //Assert
            Assert.Equal(16, g.ScoreGame);
        }


    }
}
