namespace BowlingTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
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
            Game game = new Game();
            for (int frameNumber = 0; frameNumber < 10; frameNumber++)
            {
                game.OpenFrame(0, 0);
            }

            Assert.That(game.Score(), Is.EqualTo(0));
        }

        [Test]
        public void Threes()
        {
            Game game = new Game();
            for (int frameNumber = 0; frameNumber < 10; frameNumber++)
            {
                game.OpenFrame(3, 3);
            }

            Assert.That(game.Score(), Is.EqualTo(60));
        }
    }
}