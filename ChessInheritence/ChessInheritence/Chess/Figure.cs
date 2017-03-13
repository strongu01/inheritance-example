namespace ChessInheritance.Chess
{
    abstract class Figure
    {
        #region Properties

        public string Name { get; set; }
        public string Position { get; set; }
        public string Color { get; set; }

        #endregion
         
        #region Protected Methods

        protected abstract bool CanBeMoved(string position);

        #endregion

        #region Public Methods

        public override string ToString()
        {
            return $"{Color} {Name}";
        }

        #endregion
    }
}
