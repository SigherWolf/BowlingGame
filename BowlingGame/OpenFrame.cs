using System.Collections;

namespace BowlingGame
{

    // OpenFrame extends the abstract class Frame
    public class OpenFrame : Frame
    {
        public OpenFrame(ArrayList throws, int startingThrow, int firstThrow, int secondThrow) : base(throws)
        {
            throws.Add(firstThrow);
            throws.Add(secondThrow);
        }

        override public int Score()
        {
            return (int) throws[startingThrow] + (int) throws[startingThrow + 1];
        }
    }
}