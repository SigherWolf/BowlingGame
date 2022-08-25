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
        public void GutterBalls()
        {
            Game game = new Game();
            for (int frameNumber = 0; frameNumber < 10; frameNumber++)
            {
                game.OpenFrame(0, 0);
                Assert.That(game.Score(), Is.EqualTo(0));
            }
        }
    }
}