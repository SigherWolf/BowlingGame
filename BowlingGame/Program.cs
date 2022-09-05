﻿using System.Collections;

namespace BowlingGame
{
    public class Game
    {
        ArrayList frames;
        ArrayList throws;

        public static void Main(string[] args)
        {

        }

        public Game()
        {
            frames = new ArrayList();
            throws = new ArrayList();
        }

        public void OpenFrame(int firstThrow, int secondThrow)
        {
            throws.Add(firstThrow);
            throws.Add(secondThrow);
            frames.Add(new OpenFrame(throws, firstThrow, secondThrow));
        }

        public void Spare(int firstThrow, int secondThrow)
        {
            throws.Add(firstThrow);
            throws.Add(secondThrow);
            frames.Add(new SpareFrame(throws, firstThrow, secondThrow));
        }

        public void Strike()
        {
            frames.Add(new StrikeFrame(throws));
        }

        public void BonusRoll(int roll)
        {
            frames.Add(new BonusRoll(throws, roll));
        }

        public int Score()
        {
            int total = 0;
            foreach (Frame frame in frames)
            {
                total += frame.Score();
            }

            return total;
        }
    }
}