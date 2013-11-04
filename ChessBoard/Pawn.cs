﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class Pawn : ChessPiece, IDrawable
    {
        public Pawn()
        {
            this.Image = new string[]
            {
                "             ",
                "     __      ",
                "    (  )     ",
                "     ||      ",
                "    /__\\     ",
                "   (____)    ",
                "             "
            };
        }
    }
}
