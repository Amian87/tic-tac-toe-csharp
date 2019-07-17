using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Tests
{
    class BoardPrinterTests
    {
        
        [Test]
        public void DisplayEmptyBoardIfThereAreNoMarks()
        {
            Board board = new Board();
           
            BoardPrinter boardPrinter = new BoardPrinter(board);

            Assert.AreEqual(
$@"      |      |      
 _ _ _+ _ _ _+ _ _ _
      |      |      
 _ _ _+ _ _ _+ _ _ _
      |      |      ", boardPrinter.display());
            
        }

        [Test]
        public void DisplayABoardWithASingleMark()
        {
            Board board = new Board();
            board.Move(2, "X");

            BoardPrinter boardPrinter = new BoardPrinter(board);

            Assert.AreEqual(
$@"      |  X   |      
 _ _ _+ _ _ _+ _ _ _
      |      |      
 _ _ _+ _ _ _+ _ _ _
      |      |      ", boardPrinter.display());

        }

        [Test]
        public void DisplayABoardWithASingleMarkInADifferentLocation()
        {
            Board board = new Board();
            board.Move(3, "X");

            BoardPrinter boardPrinter = new BoardPrinter(board);

            Assert.AreEqual(
$@"      |      |  X   
 _ _ _+ _ _ _+ _ _ _
      |      |      
 _ _ _+ _ _ _+ _ _ _
      |      |      ", boardPrinter.display());

        }

        [Test]
        public void DisplayABoardWithASingleMarkInPosition4()
        {
            Board board = new Board();
            board.Move(4, "X");

            BoardPrinter boardPrinter = new BoardPrinter(board);

            Assert.AreEqual(
$@"      |      |      
 _ _ _+ _ _ _+ _ _ _
  X   |      |      
 _ _ _+ _ _ _+ _ _ _
      |      |      ", boardPrinter.display());

        }

        [Test]
        public void DisplayABoardWithASingleMarkInPosition1()
        {
            Board board = new Board();
            board.Move(1, "P");

            BoardPrinter boardPrinter = new BoardPrinter(board);

            Assert.AreEqual(
$@"  P   |      |      
 _ _ _+ _ _ _+ _ _ _
      |      |      
 _ _ _+ _ _ _+ _ _ _
      |      |      ", boardPrinter.display());

        }

        [Test]
        public void DisplayABoardWithASingleMarkInPosition5()
        {
            Board board = new Board();
            board.Move(5, "P");

            BoardPrinter boardPrinter = new BoardPrinter(board);

            Assert.AreEqual(
$@"      |      |      
 _ _ _+ _ _ _+ _ _ _
      |  P   |      
 _ _ _+ _ _ _+ _ _ _
      |      |      ", boardPrinter.display());

        }

        [Test]
        public void DisplayABoardWithASingleMarkInPosition6()
        {
            Board board = new Board();
            board.Move(6, "P");

            BoardPrinter boardPrinter = new BoardPrinter(board);

            Assert.AreEqual(
$@"      |      |      
 _ _ _+ _ _ _+ _ _ _
      |      |  P   
 _ _ _+ _ _ _+ _ _ _
      |      |      ", boardPrinter.display());

        }

        [Test]
        public void DisplayABoardWithASingleMarkInPosition7()
        {
            Board board = new Board();
            board.Move(7, "R");

            BoardPrinter boardPrinter = new BoardPrinter(board);

            Assert.AreEqual(
$@"      |      |      
 _ _ _+ _ _ _+ _ _ _
      |      |      
 _ _ _+ _ _ _+ _ _ _
  R   |      |      ", boardPrinter.display());

        }

        [Test]
        public void DisplayABoardWithASingleMarkInPosition8()
        {
            Board board = new Board();
            board.Move(8, "R");

            BoardPrinter boardPrinter = new BoardPrinter(board);

            Assert.AreEqual(
$@"      |      |      
 _ _ _+ _ _ _+ _ _ _
      |      |      
 _ _ _+ _ _ _+ _ _ _
      |  R   |      ", boardPrinter.display());

        }

        [Test]
        public void DisplayABoardWithASingleMarkInPosition9()
        {
            Board board = new Board();
            board.Move(9, "R");

            BoardPrinter boardPrinter = new BoardPrinter(board);

            Assert.AreEqual(
$@"      |      |      
 _ _ _+ _ _ _+ _ _ _
      |      |      
 _ _ _+ _ _ _+ _ _ _
      |      |  R   ", boardPrinter.display());

        }

    }
}
