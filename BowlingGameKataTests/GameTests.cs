using System;
using BowlingGameKata;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingGameKataTests
{
    [TestClass]
    public class GameTests
    {
        private Game game = new Game();

        [TestMethod]
        public void CanBowlGutterGame()
        {
            RollMany(20, 0);

            var score = game.Score();

            Assert.AreEqual(0, score);
        }

        private void RollMany(Int32 rolls, Int32 pins)
        {
            for (var roll=0; roll<rolls; roll++)
                game.Roll(pins);
        }
    }
}
