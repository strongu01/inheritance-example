using ChessInheritance.Chess;
using ChessInheritence.Chess.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChessInheritence.Chess.ChessBoard
{
    class ChessBoard
    {
        #region Map

        Dictionary<char, int> map = new Dictionary<char, int>();
        
        #endregion

        #region Static Fields

        public static readonly int boardSize = 8;
        public string[,] board = new string[boardSize, boardSize];

        #endregion

        public ChessBoard()
        {
            map['a'] = 0;
            map['b'] = 1;
            map['c'] = 2;
            map['d'] = 3;
            map['e'] = 4;
            map['f'] = 5;
            map['g'] = 6;
            map['h'] = 7;

            board.Fill("[X]", "[ ]", boardSize);
        }

        #region Properties

        public string this[Dictionary<string, int> x]
        {
            get
            {
                int iValue = x.Values.First();
                bool iValueInBounds = (iValue >= 0 && iValue - 1 <= boardSize);

                string sValue = x.Keys.First();
                bool sValueInBounds = Regex.Match(sValue, "[a-hA-H]").Success;


                if(iValueInBounds && sValueInBounds)
                {
                    int mappedValue = map[sValue.ToLower()[0]];
                    return board[mappedValue, iValue];
                }
                else
                {
                    throw new Exception("Bounds incorrect");
                }
            }
            set
            {
                int iValue = x.Values.First() - 1;
                bool iValueInBounds = (iValue >= 0 && iValue - 1 <= boardSize);

                string sValue = x.Keys.First();
                bool sValueInBounds = Regex.Match(sValue, "[a-hA-H]").Success;

                try
                {
                    if (iValueInBounds && sValueInBounds)
                    {
                        int mappedValue = map[sValue.ToLower()[0]];
                        board[iValue, mappedValue] = value;
                    }
                    else
                    {
                        throw new Exception($"The letter HAS to be in A-H bounderies\nThe number HAS to be in bounderies of 0-{boardSize}");

                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                }
            }
        }

        #endregion

        #region Methods

        public void PrintBoard()
        {
            string temp = string.Empty;
            List<char> letters = map.Keys.ToList();

            for(int i = 0; i < boardSize; i++)
            {
                temp += $"{boardSize - i}\t";

                for(int j = 0; j < boardSize; j++)
                {
                    temp += $" {board[i, j]}\t";
                }

                temp += '\n';
            }

            temp += "\t";
            for(int w = 0; w < letters.Count; w++)
            {
                temp += $" {letters.ElementAt(w).ToString().ToUpper()}\t";
            }

            Console.WriteLine(temp);
        }

        #endregion
    }
}
