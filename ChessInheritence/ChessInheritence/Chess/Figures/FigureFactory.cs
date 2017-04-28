using ChessInheritance.Chess;
using ChessInheritance.Chess.Figures;
using ChessInheritence.Chess.ChessBoard;
using ChessInheritence.Chess.Figures.Enums;
using ChessInheritence.Chess.Utilities.Extensions;
using System;

namespace ChessInheritence.Chess.Figures
{
    static class FigureFactory
    {
        public static Figure CreateFigure(FigureType figure, Colors color, Position pos = null)
        {
            Figure retFigure = null;

            switch (figure)
            {
                case FigureType.Bishop:
                    {
                        retFigure = new Bishop(color.Name(), pos);
                        break;
                    }
                case FigureType.King:
                    {
                        retFigure = new King(color.Name(), pos);
                        break;
                    }
                case FigureType.Pawn:
                    {
                        retFigure = new Pawn(color.Name(), pos);
                        break;
                    }
                case FigureType.Queen:
                    {
                        retFigure = new Queen(color.Name(), pos);
                        break;
                    }
                default:
                    {
                        throw new ArgumentOutOfRangeException("figure", "Unknown figure type");
                    }
            }

            return retFigure;
        }
    }
}
