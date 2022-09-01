using System.Collections;

namespace BowlingGame
{
    public abstract class Frame
    {
        protected ArrayList throws;
        protected int startingThrow;

        public Frame(ArrayList throws)
        {
            this.throws = throws;
            this.startingThrow = throws.Count;
        }

        public abstract int Score();
    }
}
