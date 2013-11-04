using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class Rook : ChessPiece, IDrawable
    {
        public Rook()
        {
            this.Image = new string[]
            {
                "             ",
                "   WWWWWW    ",
                "    |  |     ",
                "    |__|     ",
                "   /____\\    ",
                "  (______)   ",
                "             "
            };
        }
    }
}



 