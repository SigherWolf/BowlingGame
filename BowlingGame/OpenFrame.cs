namespace BowlingGame
{
    public class OpenFrame
    {
        int score;

        public OpenFrame(int firstThrow, int secondThrow)
        {
            score = firstThrow + secondThrow;
        }

        public int Score()
        {
            return score;
        }
    }
}