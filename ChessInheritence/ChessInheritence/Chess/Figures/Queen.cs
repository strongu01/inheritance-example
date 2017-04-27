using ChessInheritence.Chess.ChessBoard;

namespace ChessInheritance.Chess.Figures
{
    class Queen : Figure
    {
        private const string NAME = "Queen";

        public Queen(string color, Position pos = null)
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
