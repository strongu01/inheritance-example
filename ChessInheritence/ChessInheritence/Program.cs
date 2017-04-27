using ChessInheritance.Chess;
using ChessInheritance.Chess.Figures;
using ChessInheritence.Chess.ChessBoard;
using ChessInheritence.Chess.Utilities;
using System.Collections.Generic;
using System;
using ChessInheritence.Chess.Figures.Colors;

namespace ChessInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Example1

            Console.WriteLine("Chess board example");

            //Filling in the chess board
            ChessBoard board = new ChessBoard();

            //Example1
            Pawn p = new Pawn(Colors.Black.Name(), new Position('B', 2));
            board[p] = p.ShortName();

            Queen q = new Queen(Colors.White.Name(), new Position('C', 7));
            board[q] = q.ShortName();
            
            board.PrintBoard();

            #endregion

            #region Example2

            Console.WriteLine("Inheritnace with a 'new' keyword example");

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
