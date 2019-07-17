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

            Assert.AreEqual("   |   |   \n", boardPrinter.display());
            
        }

    }
}
