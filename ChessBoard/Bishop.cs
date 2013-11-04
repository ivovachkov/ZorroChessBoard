using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class Bishop : ChessPiece, IDrawable
    {
        public Bishop()
        {
            this.Image = new string[]
            {
                "             ",
                "     <>_     ",
                "   (\\)  )    ",
                "    \\__/     ",
                "   (____)    ",
                "    |  |     ",    
                "             "
            };
        }
    }
}



