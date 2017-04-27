using ChessInheritence.Chess.ChessBoard;

namespace ChessInheritance.Chess.Figures
{
    class Bishop : Figure
    {
        private const string NAME = "Bishop";

        public Bishop(string color, Position pos = null)
            : base(NAME, color)
        {
        }

        protected override bool CanBeMoved(string position)
        {
            //some code here
            return true;
        }
    }
}
