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
            if(board.CurrentMarks().Contains(Tuple.Create(2, "X")))
            {
                return
$@"      |  X   |      
 _ _ _+ _ _ _+ _ _ _
      |      |      
 _ _ _+ _ _ _+ _ _ _
      |      |      ";
            }
            else if(board.CurrentMarks().Contains(Tuple.Create(3, "X")))
            {
                return
$@"      |      |  X   
 _ _ _+ _ _ _+ _ _ _
      |      |      
 _ _ _+ _ _ _+ _ _ _
      |      |      ";

            }
            else
            {

            
            return
$@"      |      |      
 _ _ _+ _ _ _+ _ _ _
      |      |      
 _ _ _+ _ _ _+ _ _ _
      |      |      ";

            }
        }
       


    }
}
