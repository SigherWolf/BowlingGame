using System.Collections;

namespace BowlingGame
{
    // SpareFrame extends the abstract class Frame
    public class SpareFrame : Frame
    {
        public SpareFrame(ArrayList throws, int startingThrow, int firstThrow, int secondThrow) : base(throws)
        {
            throws.Add(firstThrow);
            throws.Add(secondThrow);
        }

        private int NextBall()
        {
            return (int) throws[startingThrow + 2];
        }

        override public int Score()
        {
            return 10 + NextBall();
        }
    }
}
