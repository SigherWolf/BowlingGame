namespace BowlingGame
{
    public class Rolling
    {
        public static List<int> RollAll()
        {
            List<int> score = new List<int>();
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                int pinsHit = r.Next(0, 11);
                score.Add(pinsHit);

                if (pinsHit == 10)
                {
                    score.Add(0);
                } 
                else
                {
                    score.Add(SecondRoll(pinsHit));
                }
            }

            return score;
        }

        public static int SecondRoll(int pinsHit)
        {
            Random r = new Random();
            int remainingPins = 11 - pinsHit;
            int secondRoll = r.Next(0, remainingPins);
            return secondRoll;
        }

        public static List<int> BonusScoresAdded(List<int> nonBonusScores)
        {
            List<int> scores = nonBonusScores;
            Random r = new Random();

            if (scores[18] == 10)
            {
                int bonusPlaceholder = r.Next(0, 11);
                scores.Add(bonusPlaceholder);

                if (bonusPlaceholder == 10)
                {
                    scores.Add(r.Next(0, 11));
                }
                else
                {
                    scores.Add(SecondRoll(bonusPlaceholder));
                }
            }
            else if (scores[18] + scores[19] == 10)
            {
                scores.Add(r.Next(0, 11));
            }
            return scores;
        }
    }
}
