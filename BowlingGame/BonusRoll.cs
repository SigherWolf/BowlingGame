using System.Collections;

namespace BowlingGame
{
    public class BonusRoll : Frame
    {
        public BonusRoll(ArrayList throws, int firstThrow) : base(throws) 
        {
            throws.Add(firstThrow);
        }

        public override int Score()
        {
            return 0;
        }

        protected override int FrameSize()
        {
            return 0;
        }
    }
}