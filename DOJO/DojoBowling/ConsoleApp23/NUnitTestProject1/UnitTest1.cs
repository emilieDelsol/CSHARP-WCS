using NUnit.Framework;
using System.Collections.Generic;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GutterBalls()
        {
            BowlingGame Game = new BowlingGame();
            Game.RollMany(20,0);
            Assert.AreEqual(0, Game.Score());   
        }

        [Test]
        public void TestAllOne()
        {
            BowlingGame Game = new BowlingGame();
            Game.RollMany(20, 1);
            Assert.AreEqual(20, Game.Score());
        }

        [Test]
        public void TestOneSpare()
        {
            BowlingGame Game = new BowlingGame();
            Game.Roll(5);
            Game.Roll(5);//spare
            Game.Roll(3);
            Game.RollMany(0,17);
            Assert.AreEqual(16, Game.Score());
        }
        [Test]
        public void TestOneStrike()
        {
            BowlingGame Game = new BowlingGame();
            Game.Roll(10);//strike
            Game.Roll(3);
            Game.Roll(4);
            Game.RollMany(0, 16);
            Assert.AreEqual(24, Game.Score());
        }
    }
}