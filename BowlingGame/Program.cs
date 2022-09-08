using System.Collections;
using System.Security.Cryptography;

namespace BowlingGame
{
    public class Game
    {
        ArrayList frames;
        ArrayList throws;
        Random r = new Random();
        Random r2 = new Random();

        public static void Main(string[] args)
        {
            Console.WriteLine("Press x to bowl");
            string? startGame = Console.ReadLine();

            if (startGame == "x")
            {
                Rolling rolling = new Rolling();
                int firstThrow = r.Next(0, 11);
                int secondThrow = r2.Next(0, 11);
            }
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