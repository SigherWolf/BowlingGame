namespace BowlingTest
{
    public class Tests
    {
        // Arrange
        Game game;

        [SetUp]
        public void Setup()
        {
            // Arrange
            game = new Game();
        }

        [Test]
        public void Hookup()
        {
            Assert.Pass();
        }

        [Test]
        public void GutterBall_is_zero()
        {
            // Act
            ManyOpenFrames(10, 0, 0);

            // Assert
            Assert.That(game.Score(), Is.EqualTo(0));
        }

        [Test]
        public void Threes()
        {
            // Act
            ManyOpenFrames(10, 3, 3);
            
            // Assert
            Assert.That(game.Score(), Is.EqualTo(60));
        }

        [Test]
        public void Spare()
        {
            // Act
            game.Spare(4, 6);
            game.OpenFrame(3, 5);
            ManyOpenFrames(8, 0, 0);

            // Assert
            Assert.That(game.Score(), Is.EqualTo(21));
        }

        [Test]
        public void Spare2()
        {
            // Act 
            game.Spare(4, 6);
            game.OpenFrame(5, 3);
            ManyOpenFrames(8, 0, 0);

            // Assert
            Assert.That(game.Score(), Is.EqualTo(23));
        }

        [Test]
        public void Strike()
        {
            // Act
            game.Strike();
            game.OpenFrame(5, 3);
            ManyOpenFrames(8, 0, 0);

            // Assert
            Assert.That(game.Score(), Is.EqualTo(26));
        }

        [Test]
        public void SpareFinalFrame()
        {
            // Act
            ManyOpenFrames(9, 0, 0);
            game.Spare(4, 6);
            game.BonusRoll(5);

            // Assert
            Assert.That(game.Score(), Is.EqualTo(15));
        }

        [Test]
        public void StrikeFinalFrame()
        {
            // Act
            ManyOpenFrames(9, 0, 0);
            game.Strike();
            game.BonusRoll(5);
            game.BonusRoll(3);

            // Assert
            Assert.That(game.Score(), Is.EqualTo(18));
        }

        [Test]
        public void PerfectGame()
        {
            // Act
            for (int i = 0; i < 10; i++)
            {
                game.Strike();
            }

            game.BonusRoll(10);
            game.BonusRoll(10);

            // Assert
            Assert.That(game.Score(), Is.EqualTo(300));  
        }

        [Test]
        public void StrikeSpareGame()
        {
            // Act
            for (int i = 0; i < 5; i++)
            {
                game.Strike();
                game.Spare(4, 6);
            }

            game.BonusRoll(10);

            // Assert
            Assert.That(game.Score(), Is.EqualTo(200));
        }

        private void ManyOpenFrames(int count, int firstThrow, int secondThrow)
        {
            for (int frameNumber = 0; frameNumber < count; frameNumber++)
            {
                game.OpenFrame(firstThrow, secondThrow);
            }
        }
    }
}