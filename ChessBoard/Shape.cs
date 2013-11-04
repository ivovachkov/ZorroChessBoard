using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    public abstract class Shape : IDrawable
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public ConsoleColor ForegroundColor { get; set; }
        public ConsoleColor BackgroundColor { get; set; }

        protected Shape(int width, int height,
            ConsoleColor foregroundColor, ConsoleColor backgroundColor)
        {
            this.Width = width;
            this.Height = height;
            this.ForegroundColor = foregroundColor;
            this.BackgroundColor = backgroundColor;
        }

        public abstract void Draw(int x, int y);
    }
}
