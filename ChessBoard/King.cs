using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class King : ChessPiece, IDrawable
    {
        public King()
        {
            this.Image = new string[]
            {
                "    .::.     ",
			    "    _::_     ",
			    "  _/____\\_   ",   
			    "  \\      /   ", 
			    "   \\____/    ",                
			    "   (____)    ", 
			    "             "
            };
        }
    }
}

