using ChessInheritance.Chess.Figures;
using System;

namespace ChessInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example
            Bishop b = new Bishop();
            b.Name = "Bishop";
            b.Color = "Black";

            Console.WriteLine(b.ToString());
            Console.ReadKey();
        }
    }
}
