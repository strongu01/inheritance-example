using System.Collections.Generic;

namespace ChessInheritance.Chess
{
    abstract class Figure
    {
        #region Properties

        public string Color { get; set; }
        public string Name { get; set; }
        public Dictionary<string, int> Position { get; set; }

        #endregion
         
        #region Protected Methods

        protected abstract bool CanBeMoved(string position);

        #endregion

        #region Public Methods

        public override string ToString()
        {
            return $"Base class: {Color} {Name}";
        }

        #endregion
    }
}
