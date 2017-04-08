namespace ChessInheritance.Chess.Figures
{
    class King : Figure
    {
        protected override bool CanBeMoved(string position)
        {
            //some code here
            return true;
        }

        public new string ToString()
        {
            return $"King class: {Color} {Name}";
        }
    }
}
