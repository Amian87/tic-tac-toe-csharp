using NUnit.Framework;
using System;

namespace TicTacToe.Tests
{
    [TestFixture]
    class BoardTests
    {
        [Test]
        public void ItCreatesAnEmptyBoard()
        {
            Board board = new Board();
            Tuple<int, string>[] expectedBoard = { };
            Assert.AreEqual(board.CurrentMarks(), expectedBoard);
        }

        [Test]
        public void MakeOneMove()
        {
            Board board = new Board();
            board.Move(2, "X");
            Tuple<int, string>[] expectedBoard = { Tuple.Create(2, "X") };
            Assert.AreEqual(board.CurrentMarks(), expectedBoard);
        }

        [Test]
        public void MakeTwoMoves()
        {
            Board board = new Board();
            board.Move(3, "P");
            board.Move(7, "W");
            Tuple<int, string>[] expectedBoard = { Tuple.Create(3, "P"), Tuple.Create(7, "W") };
            Assert.AreEqual(board.CurrentMarks(), expectedBoard);
        }
    }
}
