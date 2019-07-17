using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Game
    {
        private string CurrentSymbol = "X";
        private Board board = new Board();
        private GameRules rules;
        private BoardPrinter boardPrinter;
        private IPlayer PlayerOne;
        private IPlayer PlayerTwo;


        public Game()
        {
            boardPrinter = new BoardPrinter(board);
            PlayerOne = new HumanPlayer(boardPrinter);
            PlayerTwo = new HumanPlayer(boardPrinter);
            rules = new GameRules(board);
        }

        private void Move(int position)
        {
            board.Move(position, CurrentSymbol);
            GoToNextTurn();
        }

        private void GoToNextTurn()
        {
            CurrentSymbol = (CurrentSymbol == "X" ? "O" : "X");
        }
        
        public void play()
        {
            // This is not tested
            // This CAN be tested, but we will return to it later after
            // some more experience with TDD
            Console.WriteLine("Let's play Tic Tac Toe!");
            while (rules.InProgress())
            {
                Move(PlayerOne.Move());
                Move(PlayerTwo.Move());
            }
        }

    }
}
