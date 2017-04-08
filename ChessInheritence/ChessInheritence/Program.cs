using ChessInheritance.Chess;
using ChessInheritance.Chess.Figures;
using ChessInheritence.Chess.ChessBoard;
using ChessInheritence.Chess.Utilities;
using System.Collections.Generic;
using System;

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
            Pawn p = new Pawn()
            {
                Name = "Pawn",
                Color = "Black",
                Position = new Dictionary<string, int>()
            };
            p.Position.Add("B", 2);

            board[p.Position] = p.Color[0].ToString() + p.Name[0].ToString();


            Console.WriteLine("CHESS BOARD: " + board[p.Position]);

            Queen q = new Queen
            {
                Name = "Queen",
                Color = "White",
                Position = new Dictionary<string, int>()
            };
            q.Position.Add("C", 7);
            board[q.Position] = q.Color[0].ToString() + q.Name[0].ToString();
            
            board.PrintBoard();

            #endregion

            #region Example2
            Console.WriteLine("Inheritnace with a 'new' keyword example");

            //Example2
            King k = new King()
            {
                Name = "King",
                Color = "White"
            };

            Console.WriteLine(k.ToString());

            Figure f = k;
            Console.WriteLine(f.ToString());

            #endregion

            Console.ReadKey();
        }
    }
}
