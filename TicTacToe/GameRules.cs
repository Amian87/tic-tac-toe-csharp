using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class GameRules
    {
        private Board board;

        public GameRules(Board gameBoard)
        {
            board = gameBoard;
        }

        public bool InProgress()
        {
            return !(threeInARow(1,2,3,"X") || threeInARow(4,5,6,"O") || threeInARow(1,2,3,"O" ));
        }

        private bool threeInARow(int pos1, int pos2, int pos3, string symbol)
        {
            int numberInARow = 0;
            foreach (Tuple<int, string> mark in board.CurrentMarks())
            {
                if (mark.Item1 == pos1 && mark.Item2 == symbol)
                {
                    numberInARow += 1;
                }
                else if (mark.Item1 == pos2 && mark.Item2 == symbol)
                {
                    numberInARow += 1;
                }
                else if (mark.Item1 == pos3 && mark.Item2 == symbol)
                {
                    numberInARow += 1;
                }

            }
            return numberInARow == 3;
        }
    }
}
