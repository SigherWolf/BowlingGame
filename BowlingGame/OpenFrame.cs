﻿using System.Collections;

namespace BowlingGame
{

    // OpenFrame implements the interface IFrame
    public class OpenFrame : IFrame
    {
        ArrayList throws;
        int startingThrow;
        int score;

        public OpenFrame(ArrayList throws, int startingThrow, int firstThrow, int secondThrow)
        {
            this.throws = throws;
            this.startingThrow = startingThrow;
            throws.Add(firstThrow);
            throws.Add(secondThrow);
            score = firstThrow + secondThrow;
        }

        public int Score()
        {
            return score;
        }
    }
}