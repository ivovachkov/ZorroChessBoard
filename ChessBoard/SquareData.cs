using System;

namespace ChessBoard
{
    struct SquareData
    {
        public ConsoleColor SquareColor { get; set; }
        public PieceColor PColor { get; set; }
        public PieceType PType { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

    }
}
