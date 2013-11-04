using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    abstract class ChessPiece : IDrawable
    {
        public string[] Image;

        public virtual void Draw(int x, int y)
        {
            Console.SetCursorPosition(x, y);

            for (int row = 0; row < this.Image.Length; row++)
            {
                Console.CursorLeft = x;
                Console.WriteLine(this.Image[row]);
            }
        }
        
    }
}