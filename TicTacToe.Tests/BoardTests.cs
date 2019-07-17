﻿using NUnit.Framework;
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

        [Test]
        public void ReturnMarkForGivenPosition()
        {
            Board board = new Board();
            board.Move(1, "X");
            Assert.AreEqual("X", board.GetMark(1));
        }

        [Test]
        public void ReturnDifferentMarkForGivenPosition()
        {
            Board board = new Board();
            board.Move(1, "O");
            Assert.AreEqual("O", board.GetMark(1));
        }

        [Test]
        public void ReturnEmptyStringWhenGivenOnlyAPosition()
        {
            Board board = new Board();
            board.Move(1, "O");
            board.Move(3, "X");
            Assert.AreEqual(" ", board.GetMark(4));
        }

        [Test]
        public void ReturnMarkForPosition4()
        {
            Board board = new Board();
            board.Move(4, "X");
            Assert.AreEqual("X", board.GetMark(4));
                
        }


        [Test]
        public void ReturnMarkForPosition5()
        {
            Board board = new Board();
            board.Move(5, "X");
            Assert.AreEqual("X", board.GetMark(5));

        }




    }
}
