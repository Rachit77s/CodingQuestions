using BowlingWithFrame.Helpers;
using NUnit.Framework;
using System;

namespace BowlingWithFrame
{
    [TestFixture]
    class BowlingTest 
    {
        BowlingGame game;

        public BowlingTest()
        {
        }

        [SetUp]
        public void SetUp()
        {
            game = new BowlingGame();
        }

        [Test]
        public void Hookup()
        {
            Assert.IsTrue(true);
        }

        //All Gutter Balls
        [Test]
        public void GutterBalls()
        {
            ManyOpenFrames(10, 0, 0);
            Assert.AreEqual(0, game.Score());
        }

        [Test]
        public void Threes()
        {
            ManyOpenFrames(10, 3, 3);
            // 3+3 = 6, And 6*10 = 60
            Assert.AreEqual(60, game.Score());
        }

        [Test]
        public void Spare()
        {
            game.Spare(4, 6);
            //6+4=10 + 1st next throw i.e. 3
            //13
            game.OpenFrame(3, 5);
            //13+8 = 21
            ManyOpenFrames(8, 0, 0);           
            Assert.AreEqual(21, game.Score());
        }

        [Test]
        public void Spare2()
        {
            game.Spare(4, 6);
            game.OpenFrame(5, 3);
            //15+8 = 23
            ManyOpenFrames(8, 0, 0);
            Assert.AreEqual(23, game.Score());
        }

        [Test]
        public void Strike()
        {
            //10 points
            game.Strike();
            game.OpenFrame(5, 3);
            //18+8 = 26
            ManyOpenFrames(8, 0, 0);
            Assert.AreEqual(26, game.Score());
        }

        [Test]
        public void StrikeFinalFrame()
        {
            ManyOpenFrames(9, 0, 0);
            game.Strike();
            game.BonusRoll(5);
            game.BonusRoll(3);
            Assert.AreEqual(18, game.Score()); // note that this is different from test Strike()
        }

        [Test]
        public void SpareFinalFrame()
        {
            ManyOpenFrames(9, 0, 0);
            game.Spare(4, 6);
            game.BonusRoll(5);
            Assert.AreEqual(15, game.Score());
        }

        [Test]
        public void Perfect()
        {
            for (int i = 0; i < 10; i++)
                game.Strike();

            //1ball 10, then next two balls also 10 each, hence total 30, max points can be 300.
        //10+1stball+2ndball = 30 * 10 = 300  
            game.BonusRoll(10);
            game.BonusRoll(10);
            Assert.AreEqual(300, game.Score());
        }

        private void ManyOpenFrames(int count, int firstThrow, int secondThrow)
        {
            for (int frameNumber = 0; frameNumber < count; frameNumber++)
                game.OpenFrame(firstThrow, secondThrow);
        }
    }
}
