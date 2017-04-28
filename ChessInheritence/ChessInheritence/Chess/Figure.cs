using ChessInheritence.Chess.ChessBoard;
using System;

namespace ChessInheritance.Chess
{
    abstract class Figure
    {
        #region Delegates and Events

        public delegate void PositionChangeHandler();
        public event PositionChangeHandler OnPositionChange;

        #endregion

        #region Properties

        public string Color { get; set; }
        public string Name { get; set; }
        private Position position;
        public Position Position
        {
            get
            {
                return position;
            }
            set
            {
                if(null != OnPositionChange) OnPositionChange(); //Firing up the event
                position = value;
            }
        }

        #endregion

        #region Constructors and Destructors

        public Figure(string name, string color, Position pos)
        {
            Name = name;
            Color = color;
            Position = pos;
            OnPositionChange += PositionChanged;
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

        public void PositionChanged()
        {
            Console.WriteLine($"{Name} changed position!");
        }

        #endregion
    }
}
