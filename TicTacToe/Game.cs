using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Game
    {
        private string CurrentSymbol = "X";
        private Board board = new Board();

        public void Move(int position)
        {
            board.Move(position, CurrentSymbol);
            GoToNextTurn();
        }

        public List<Tuple<int, string>> CurrentMarks()
        {
            return board.CurrentMarks();
        }

        private void GoToNextTurn()
        {
            CurrentSymbol = (CurrentSymbol == "X" ? "O" : "X");
        }

    }
}
