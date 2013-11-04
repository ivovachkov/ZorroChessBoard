using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class Square : Shape
    {
        private const char BackgroundSymbol = ' ';

        public Square()
            : this(2, 2, ConsoleColor.White, ConsoleColor.Black)
        {
        }

        public Square(int width, int height,
            ConsoleColor foregroundColor, ConsoleColor backgroundColor)
            : base(width, height, foregroundColor, backgroundColor)
        {
        }

        public override void Draw(int x, int y)
        {
            Console.SetCursorPosition(x, y);

            for (int col = 0; col < this.Height; col++)
            {
                Console.CursorLeft = x;
                Console.WriteLine(new string(BackgroundSymbol, Width));
            }
        }
    }
}
