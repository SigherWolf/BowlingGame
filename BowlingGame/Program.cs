using System.Collections;

namespace BowlingGame
{
    public class Game
    {
        ArrayList frames;

        public static void Main(string[] args)
        {

        }

        public Game()
        {
            frames = new ArrayList();
        }

        public void OpenFrame(int firstThrow, int secondThrow)
        {
            frames.Add(new OpenFrame(firstThrow, secondThrow));
        }

        public int Score()
        {
            int total = 0;
            foreach (OpenFrame frame in frames)
            {
                total += frame.Score();
            }

            return total;
        }
    }
}