using ChessInheritence.Chess.Figures.Enums;
using System;

namespace ChessInheritence.Chess.Utilities.Extensions
{
    public static class EnumExtensions
    {
        public static string Name(this Colors color)
        {
            return Enum.GetName(typeof(Colors), color);
        }
    }
}
