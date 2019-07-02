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
            bool inProgress = true;
            foreach (string symbol in Symbols())
                foreach (int[] row in RowsToCheck())
                {
                    {
                        if (threeInARow(row, symbol))
                        {
                            inProgress = false;
                        }
                    }
                }
            return inProgress;
        }

        private string[] Symbols()
        {
            return new string[]{ "X", "O"};
        }

        private int[][] RowsToCheck()
        {
            return new int[][] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
        }

        private bool threeInARow(int[] positions, string symbol)
        {
            int numberInARow = 0;
            foreach (Tuple<int, string> mark in board.CurrentMarks())
            {
                if (mark.Item1 == positions[0] && mark.Item2 == symbol)
                {
                    numberInARow += 1;
                }
                else if (mark.Item1 == positions[1] && mark.Item2 == symbol)
                {
                    numberInARow += 1;
                }
                else if (mark.Item1 == positions[2] && mark.Item2 == symbol)
                {
                    numberInARow += 1;
                }

            }
            return numberInARow == 3;
        }
    }
}
