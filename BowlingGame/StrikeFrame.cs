using System.Collections;

namespace BowlingGame
{
    public class StrikeFrame : Frame
    {
        public StrikeFrame(ArrayList throws) : base(throws)
        {
            throws.Add(10);
        }

        override public int Score()
        {
            return 10 + (int) throws[startingThrow + FrameSize()] + (int) throws[startingThrow + FrameSize() + 1];
        }

        override protected int FrameSize()
        {
            return 1;
        }
    }
}