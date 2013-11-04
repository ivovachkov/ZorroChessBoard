using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class Frame : Shape
    {
        public FrameSymbol FrameSymbols { get; set; }

        public Frame()
            : this(2, 2, ConsoleColor.White, ConsoleColor.Black,
            new FrameSymbol('.', '.', '.', '.', '.', '.', '.'))
        {
        }

        public Frame(int width, int height,
            ConsoleColor foregroundColor, ConsoleColor backgroundColor, FrameSymbol frameSymbols)
            : base(width, height, foregroundColor, backgroundColor)
        {
            this.FrameSymbols = frameSymbols;
        }

        public override void Draw(int x, int y)
        {
            Console.SetCursorPosition(x, y);

            // Drawing the top line
            DrawHorizontalLine(
                this.FrameSymbols.TopLeftCorner, 
                this.FrameSymbols.TopHorBorder, 
                this.FrameSymbols.TopRightCorner);

            // Drawing left and right vertical lines
            DrawVerticleLines(x);

            // Drawing the bottom line
            Console.CursorLeft = x;
            DrawHorizontalLine(
                this.FrameSymbols.BottomLeftCorner, 
                this.FrameSymbols.BotHorBorder, 
                this.FrameSymbols.BottomRightCorner);
        }

        private void DrawHorizontalLine(char left, char middle, char right)
        {
            string middleLine = new string(middle, this.Width - 2);
            Console.WriteLine(left + middleLine + right);
        }

        private void DrawVerticleLines(int leftPosition)
        {
            for (int i = 0; i < this.Height - 2; i++)
            {
                Console.CursorLeft = leftPosition;
                Console.Write(this.FrameSymbols.VertBorder);
                Console.CursorLeft = leftPosition + this.Width - 1;
                Console.WriteLine(this.FrameSymbols.VertBorder);
            }
        }
    }
}
