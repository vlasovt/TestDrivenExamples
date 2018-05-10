using System;

namespace BowlingKata
{
    public class Game
    {
        
        private int[] rolls = new int[21];
        private int currentRoll;

        public int ScoreGame { 
            get 
            {
                var score = 0;
                var frameIndex = 0;

                for (var frame = 0; frame < 10; frame++)
                {
                    if (IsSpare(frameIndex)) //spare
                    {
                        score += 10 + rolls[frameIndex + 2];
                    }
                    else 
                    {
                        score += rolls[frameIndex] + rolls[frameIndex + 1];
                    }
                    
                    frameIndex += 2;
                }

                return score; 
            } 
        }

        public void Roll(int pins)
        {
            rolls[currentRoll] = pins;
            currentRoll++;
        }

        public bool IsSpare(int frameIndex)
        {
            return rolls[frameIndex] + rolls[frameIndex + 1] == 10;
        }
    }
}
