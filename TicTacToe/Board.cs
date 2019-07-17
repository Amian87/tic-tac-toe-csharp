using System;
using System.Collections.Generic;

namespace TicTacToe
{
    public class Board
    {
        private List<Tuple<int, string>> Marks = new List<Tuple<int, string>> ();

        public List<Tuple<int, string>> CurrentMarks()
        {
            return Marks;
        }

        public void Move(int position, string symbol)
        {
            Marks.Add(Tuple.Create(position, symbol));
        }

        public string GetMark(int position)
        {
            foreach(Tuple<int, string> Mark in Marks)
            {
                if(Mark.Item1 == position)
                {
                    return Mark.Item2;
                }
            }
            return " ";
        }

    }
}
