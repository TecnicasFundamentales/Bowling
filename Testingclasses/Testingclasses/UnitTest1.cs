using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingScore;

namespace Testingclasses
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ScoreDetectionok()
        {
            ScoreDetection sd = new ScoreDetection();
            Player p1 = new Player();
            Player p2 = new Player();
            sd.Player1 = p1;
            sd.Player2 = p2;

            Assert.IsNotNull(p1);
            Assert.IsNotNull(p2);
        }
    }
}
