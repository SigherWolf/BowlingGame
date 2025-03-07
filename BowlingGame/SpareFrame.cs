﻿using System.Collections;

namespace BowlingGame
{
    // SpareFrame extends the abstract class Frame
    public class SpareFrame : Frame
    {
        public SpareFrame(ArrayList throws, int firstThrow, int secondThrow) : base(throws)
        {
            throws.Add(firstThrow);
            throws.Add(secondThrow);
        }

        override public int Score()
        {
            return 10 + (int) throws[startingThrow + FrameSize()];
        }

        override protected int FrameSize()
        {
            return 2;
        }
    }
}
