﻿using System;
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

        public bool InProgress()
        {
            return board.CurrentMarks().Count < 9;

        }

        public void play()
        {
            // This is not tested
            // This CAN be tested, but we will return to it later after
            // some more experience with TDD
            Console.WriteLine("Let's play Tic Tac Toe!");
            while (InProgress())
            {
                Console.WriteLine("Enter a number between 1 and 9");
                int playerMove = Int32.Parse(Console.ReadLine());
                Move(playerMove);
                CurrentMarks().ForEach(Console.WriteLine);
            }
        }

    }
}
