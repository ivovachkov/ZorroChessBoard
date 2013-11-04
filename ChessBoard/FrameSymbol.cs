using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    struct FrameSymbol
    {
        public FrameSymbol(char topHorBorder, char botHorBorder, char vertBorder, char topLeftCorner, 
            char topRightCorner, char bottomRightCorner, char bottomLeftCorner) 
            : this()
        {
            this.TopHorBorder = topHorBorder;
            this.BotHorBorder = botHorBorder;
            this.VertBorder = vertBorder;
            this.TopLeftCorner = topLeftCorner;
            this.TopRightCorner = topRightCorner;
            this.BottomRightCorner = bottomRightCorner;
            this.BottomLeftCorner = bottomLeftCorner;
        }

        public char TopHorBorder { get; set; }
        public char BotHorBorder { get; set; }
        public char VertBorder { get; set; }
        public char TopLeftCorner { get; set; }
        public char TopRightCorner { get; set; }
        public char BottomRightCorner { get; set; }
        public char BottomLeftCorner { get; set; }
    }
}
