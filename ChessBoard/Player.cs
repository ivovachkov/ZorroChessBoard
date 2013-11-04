using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChessBoard
{
    public class Player : IDrawable
    {
        public string Name { get; private set; }
        public PieceColor PColor { get; private set; }
        private List<PieceType> pieceList;

        public Player(string name, PieceColor pColor)
        {
            this.Name = name;
            this.PColor = pColor;
            this.pieceList = new List<PieceType>();
        }

        public void Draw(int x, int y)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(x + 1, y + 1);
            Console.WriteLine(this.Name);
            Console.CursorLeft = x + 13;
        }
    }
}