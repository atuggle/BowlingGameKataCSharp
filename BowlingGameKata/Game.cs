using System;
using System.Linq;

namespace BowlingGameKata
{
    public class Game
    {
        private Int32[] rolls = new Int32[21];
        private Int32 currentRoll = 0;

        public void Roll(Int32 pins)
        {
            rolls[currentRoll++] = pins;
        }

        public Int32 Score()
        {
            var score = 0;
            var rollIndex = 0;

            for (var frame=0; frame < 10; frame++)
            {
                if (FrameIsStrike(rollIndex))
                {
                    score += 10 + ScoreStrikeBonus(rollIndex);
                    rollIndex++;
                }
                else if (FrameIsSpare(rollIndex))
                {
                    score += 10 + ScoreSpareBonus(rollIndex);
                    rollIndex += 2;
                }
                else
                {
                    score += ScoreRegularFrame(rollIndex);
                    rollIndex += 2;
                }
            }

            return score;
        }

        private Boolean FrameIsStrike(Int32 rollIndex)
        {
            return rolls[rollIndex] == 10;
        }

        private bool FrameIsSpare(int rollIndex)
        {
            return rolls[rollIndex] + rolls[rollIndex + 1] == 10;
        }

        private Int32 ScoreStrikeBonus(Int32 rollIndex)
        {
            return rolls[rollIndex + 1] + rolls[rollIndex + 2];
        }

        private Int32 ScoreSpareBonus(Int32 rollIndex)
        {
            return rolls[rollIndex + 2];
        }

        private Int32 ScoreRegularFrame(Int32 rollIndex)
        {
            return rolls[rollIndex] + rolls[rollIndex + 1];
        }
    }
}
