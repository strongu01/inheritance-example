using ChessInheritance.Chess;
using ChessInheritence.Chess.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChessInheritence.Chess.ChessBoard
{
    class ChessBoard
    {
        #region Fields

        public string[,] board;

        private const int boardSize = Consts.BOARD_SIZE;

        #endregion

        public ChessBoard()
        {
            board = new string[boardSize, boardSize];
            board.Fill("[X]", "[ ]", boardSize);
        }

        #region Properties

        public string this[Figure f]
        {
            get
            {
                Position figurePos = f.Position;
                return board[figurePos.iX, figurePos.Y];
            }
            set
            {
                Position figurePos = f.Position;
                board[figurePos.iX, f.Position.Y] = value;
            }
        }

        #endregion

        #region Methods

        public void PrintBoard()
        {
            string temp = string.Empty;
            List<char> letters = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };

            for(int i = 0; i < boardSize; i++)
            {
                temp += (boardSize - i) + "\t";

                for(int j = 0; j < boardSize; j++)
                {
                    temp += board[i, j] + "\t";
                }

                temp += '\n';
            }

            temp += "\t";
            for(int w = 0; w < letters.Count; w++)
            {
                temp += $" {letters.ElementAt(w).ToString().ToUpper()}\t";
            }

            Console.WriteLine(temp);
        }
        
        #endregion
    }
}
