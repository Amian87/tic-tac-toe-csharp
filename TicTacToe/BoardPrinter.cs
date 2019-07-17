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
            return
$@"      |  {board.GetMark(2)}   |  {board.GetMark(3)}   
 {horizontalRule()}
      |      |      
 {horizontalRule()}
      |      |      ";


        }

        private string horizontalRule()
        {
            return "_ _ _+ _ _ _+ _ _ _";
        }
       


    }
}
