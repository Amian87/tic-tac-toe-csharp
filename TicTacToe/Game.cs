using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Game
    {

        private List<Tuple<int, string>> Marks = new List<Tuple<int, string>>();
        private string CurrentSymbol = "X";

        public void Move(int position)
        {
            Marks.Add(Tuple.Create(position, CurrentSymbol));
            GoToNextTurn();
        }

        public List<Tuple<int, string>> CurrentMarks()
        {
            return Marks;
        }

        private void GoToNextTurn()
        {
            if(CurrentSymbol == "X")
            {
                CurrentSymbol = "O";
            } else
            {
                CurrentSymbol = "X";
            }
        }

    }
}
