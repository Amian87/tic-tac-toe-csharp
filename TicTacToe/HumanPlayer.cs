using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class HumanPlayer : IPlayer
    {
        private BoardPrinter boardPrinter;

        public HumanPlayer(BoardPrinter boardPrinter)
        {
            this.boardPrinter = boardPrinter;
        }
   
        public int Move()
        {
            Console.WriteLine("Enter a number between 1 and 9");
            Console.WriteLine(boardPrinter.display());
            return Int32.Parse(Console.ReadLine());
        }
    }
}
