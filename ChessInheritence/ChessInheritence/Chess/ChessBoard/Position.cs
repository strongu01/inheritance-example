using ChessInheritence.Chess.Utilities;
using System;

namespace ChessInheritence.Chess.ChessBoard
{
    public class Position
    {
        #region Properties

        public char X { get; }
        /// <summary>
        /// Integer representation of X value
        /// </summary>
        public int iX { get; }
        public int Y { get; }

        #endregion

        #region Constructors and Destructors

        public Position(char X, int Y)
        {
            if(CheckBounds(Consts.BOARD_SIZE, charToChessInt(X), Y))
            {
                this.X = X;
                this.Y = Y;
                iX = charToChessInt(X);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        #endregion

        #region Private Methods

        private bool CheckBounds(int boardSize, params int[] values)
        {
            bool result = true;

            foreach (int value in values)
            {
                if (!(value >= 0 && value - 1 <= boardSize))
                {
                    result = false;
                }
            }

            return result;
        }

        private int charToChessInt(char c)
        {
            return c - 65;
        }

        #endregion
    }
}
