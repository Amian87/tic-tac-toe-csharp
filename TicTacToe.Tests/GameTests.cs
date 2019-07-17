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

    }
}
