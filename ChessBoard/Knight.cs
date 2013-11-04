using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class Knight : ChessPiece, IDrawable
    {
        public Knight()
        {
            this.Image = new string[]
            {
                "             ",
                "   __/\"\"\"\\   ",
                "  ]___ 0  }  ",
                "      /   }  ",
                "    /~    }  ",
                "    \\____/   ",
                "             "
            };
        }
    }
}


