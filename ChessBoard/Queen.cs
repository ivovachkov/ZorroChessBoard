using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class Queen : ChessPiece, IDrawable
    {
        public Queen()
        {
            this.Image = new string[]
            {
                "             ", 
                "     ()      ",
		        "   <~--~>    ",
		        "    \\__/     ",     
		        "   (____)    ",            
		        "    |  |     ", 
		        "             "
            };
        }
    }
}

