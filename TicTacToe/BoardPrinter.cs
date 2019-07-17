using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class BoardPrinter
    {
       private Board board;

       public BoardPrinter(Board board)
        {
            this.board = board;
        }

        public string display()
        {
            return "   |";
        }
       


    }
}
