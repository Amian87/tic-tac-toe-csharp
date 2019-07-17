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

    }
}
