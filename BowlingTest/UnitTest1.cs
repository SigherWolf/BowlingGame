namespace BowlingTest
{
    public class Tests
    {
        // Arrange
        Game game;

        [SetUp]
        public void Setup()
        {
            game = new Game();
        }

        [Test]
        public void Hookup()
        {
            Assert.Pass();
        }

        [Test]
        // Ensures balls that end up in the gutter result in a score of 0 (since no pins were hit)
        public void GutterBalls()
        {
            ManyOpenFrames(10, 0, 0);
            Assert.That(game.Score(), Is.EqualTo(0));
        }

        [Test]
        public void Threes()
        {
            ManyOpenFrames(10, 3, 3);
            Assert.That(game.Score(), Is.EqualTo(60));
        }

        private void ManyOpenFrames(int count, int firstThrow, int secondThrow)
        {
            for (int frameNumber = 0; frameNumber < count; frameNumber++)
            {
                game.OpenFrame(firstThrow, secondThrow);
            }
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
    }
}