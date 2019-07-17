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
            return  $"{RowOfSymbols(1, 2, 3)}{horizontalRule()}{RowOfSymbols(4, 5, 6)}{horizontalRule()}{RowOfSymbols(7, 8, 9)}";
        }

        private string horizontalRule()
        {
            return "\r\n _ _ _+ _ _ _+ _ _ _\r\n";
        }

        private string VerticalRule()
        {
            return "|";
        }

        private string MarkWithPadding(int position)
        {
            return $"  {board.GetMark(position)}   ";
        }

        private string RowOfSymbols(int position1, int position2, int position3)
        {   
            return $"{MarkWithPadding(position1)}{VerticalRule()}{MarkWithPadding(position2)}{VerticalRule()}{MarkWithPadding(position3)}";
        }
    }
}
