using ChessInheritance.Chess;
using ChessInheritance.Chess.Figures;
using ChessInheritence.Chess.ChessBoard;
using System;
using ChessInheritence.Chess.Utilities.Extensions;
using ChessInheritence.Chess.Figures;
using ChessInheritence.Chess.Figures.Enums;

namespace ChessInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example1

            Console.WriteLine("Chess board example");

            //Filling in the chess board
            ChessBoard board = ChessBoard.Instance;

            //Example1 - creating and changing the position
            Figure p = FigureFactory.CreateFigure(FigureType.Pawn, Colors.Black, new Position('B', 2));
            board[p, new Position('B', 2)] = p.ShortName(); //Each position change will raise the event

            Figure q = FigureFactory.CreateFigure(FigureType.Queen, Colors.White);
            board[q, new Position('C', 7)] = q.ShortName();

            board.PrintBoard();

            //Using implemented IEnumerable inteface to print all figures present on the board
            Console.WriteLine("Figures currently on the board:");
            foreach (string s in board)
            {
                Console.WriteLine(s);
            }

            int figuresOnBoard = board.FigureCount(); // <- using an extension method
            Console.WriteLine("Number of figures on board: " + figuresOnBoard);

            #endregion

            #region Example2

            Console.WriteLine("\nInheritnace with a 'new' keyword example");

            //Example2
            King k = new King(Colors.White.Name());
            Console.WriteLine(k.ToString());

            Figure f = k;
            Console.WriteLine(f.ToString());

            #endregion

            Console.ReadKey();
        }
    }
}
