using NUnit.Framework;
using System;

namespace TicTacToe.Tests
{
    [TestFixture]
    class GameTests
    {
        [Test]
        public void PlayerOneCanMakeAMoveInANewGameOfTTT()
        {
            Game game = new Game();
            game.Move(3);
            Tuple<int, string>[] currentMarks = { Tuple.Create(3, "X") };
            Assert.AreEqual(game.CurrentMarks(), currentMarks);
        }

        [Test]
        public void PlayersOneAndTwoCanMakeMovesInAGameOfTTT()
        {
            Game game = new Game();
            game.Move(3);
            game.Move(1);
            Tuple<int, string>[] currentMarks = { Tuple.Create(3, "X"), Tuple.Create(1, "O") };
            Assert.AreEqual(game.CurrentMarks(), currentMarks);
        }

        [Test]
        public void ThreeMovesInARow()
        {
            Game game = new Game();
            game.Move(3);
            game.Move(1);
            game.Move(5);
            Tuple<int, string>[] currentMarks = { Tuple.Create(3, "X"), Tuple.Create(1, "O"), Tuple.Create(5, "X") };
            Assert.AreEqual(game.CurrentMarks(), currentMarks);
        }

        [Test]
        public void TheGameIsInProgress()
        {
            Game game = new Game();
            for(int i = 1; i < 4; i++)
            {
                game.Move(i);
            }
            Assert.True(game.InProgress());
        }

        [Test]
        public void YouCanMakeNineMovesBeforeTheGameIsOver()
        {
            Game game = new Game();
            for (int i = 1; i < 10; i++)
            {
                game.Move(i);
            }
            Assert.False(game.InProgress());
        }

        [Test]
        public void TheGameIsOverAfterGreaterThanNineMoves()
        {
            Game game = new Game();
            for (int i = 1; i < 100; i++)
            {
                game.Move(i);
            }
            Assert.False(game.InProgress());
        }

    }
}
