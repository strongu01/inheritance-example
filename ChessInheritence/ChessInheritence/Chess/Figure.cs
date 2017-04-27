using ChessInheritence.Chess.ChessBoard;

namespace ChessInheritance.Chess
{
    abstract class Figure
    {
        #region Properties

        public string Color { get; set; }
        public string Name { get; set; }
        public Position Position { get; set; }

        #endregion

        #region Constructors and Destructors

        public Figure(string name, string color, Position pos = null)
        {
            if(pos == null)
            {
                pos = new Position('A', 0);
            }

            Position = pos;
            Name = name;
            Color = color;
        }

        #endregion

        #region Protected Methods

        protected abstract bool CanBeMoved(string position);

        #endregion

        #region Public Methods

        public string ShortName()
        {
            return Color[0].ToString() + Name[0].ToString();
        }

        public override string ToString()
        {
            return $"Base class: {Color} {Name}";
        }

        #endregion
    }
}
