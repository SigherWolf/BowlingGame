using System.Collections;

namespace BowlingGame
{
    // SpareFrame implements the interface IFrame
    public class SpareFrame : IFrame
    {
        ArrayList throws;
        int startingThrow;

        public SpareFrame(ArrayList throws, int startingThrow, int firstThrow, int secondThrow)
        {
            this.throws = throws;
            this.startingThrow = startingThrow;
            throws.Add(firstThrow);
            throws.Add(secondThrow);
        }

        private int NextBall()
        {
            return (int) throws[startingThrow + 2];
        }

        public int Score()
        {
            return 10 + NextBall();
        }
    }
}
