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
            return rolls.ToList().Sum();
        }
    }
}
