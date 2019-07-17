using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Tests
{
    class GameRulesTests
    {
        private Board board;
        private GameRules rules;

        [SetUp]
        public void setup()
        {
            board = new Board();
            rules = new GameRules(board);
        }

        public void gameMoves(int position, string symbol)
        {
            board.Move(position, symbol);
        }

        [Test]
        public void emptyBoardHasAGameInProgress()
        {
            Assert.IsTrue(rules.InProgress());
        }

        [Test]
        public void checkIfPlayerHasMadeFirstMove()
        {
            board.Move(1, "X");
            Assert.IsTrue(rules.InProgress());
        }

        [Test]
        public void checkIfThereAreThreeMovesInTheHorizontolSpace()
        {
            board.Move(1, "X");
            board.Move(2, "X");
            board.Move(3, "X");
            Assert.IsFalse(rules.InProgress());
        }

        [Test]
        public void gameIsInProgressIfThereAreTwoMarks()
        {
            board.Move(1, "X");
            board.Move(2, "O");
            Assert.IsTrue(rules.InProgress());
        }

        [Test]
        public void gameIsInProgressIfThereAreFourMarks()
        {
            board.Move(1, "X");
            board.Move(2, "0");
            board.Move(3, "X");
            board.Move(6, "0");
            Assert.IsTrue(rules.InProgress());
        }

        [Test]
        public void checkIfThereAreThreeSymbolsInTheHorizontolSpace()
        {
            board.Move(1, "O");
            board.Move(2, "O");
            board.Move(3, "O");
            Assert.IsFalse(rules.InProgress());
        }

        [Test]
        public void checkIfThereAreThreeSymbolsInTheMiddleHorizontolSpace()
        {
            board.Move(4, "O");
            board.Move(5, "O");
            board.Move(6, "O");
            Assert.IsFalse(rules.InProgress());
        }

        [Test]
        public void checkIfThereAreThreeDifferentSymbolsInTheMiddleHorizontolSpace()
        {
            board.Move(4, "X");
            board.Move(5, "X");
            board.Move(6, "X");
            Assert.IsFalse(rules.InProgress());
        }

        [Test]
        public void checkIfThereAreThreeDifferentSymbolsInTheBottomHorizontolSpace()
        {
            board.Move(7, "X");
            board.Move(8, "X");
            board.Move(9, "X");
            Assert.IsFalse(rules.InProgress());
        }

        [Test]
        public void checkIfTheGameIsTied()
        {
            board.Move(1, "X");
            board.Move(2, "O");
            board.Move(3, "X");
            board.Move(4, "O");
            board.Move(5, "O");
            board.Move(6, "X");
            board.Move(7, "X");
            board.Move(8, "X");
            board.Move(9, "O");
            Assert.IsFalse(rules.InProgress());
        }

    }
}
