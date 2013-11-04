using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class MoveEntry : IDrawable
    {
        public int StartRow { get; private set; }
        public int StartCol { get; private set; }
        public int EndRow { get; private set; }
        public int EndCol { get; private set; }
        private Frame frame;

        public MoveEntry()
        {
            frame = new Frame()
            {
                Width = 21,
                Height = 3,
                ForegroundColor = ConsoleColor.Yellow,
                BackgroundColor = ConsoleColor.Black,
                FrameSymbols = new FrameSymbol()
                {
                    TopLeftCorner = '╔',
                    TopRightCorner = '╗',
                    BottomLeftCorner = '╚',
                    BottomRightCorner = '╝',
                    TopHorBorder = '═',
                    BotHorBorder = '═',
                    VertBorder = '║'
                }
            };
        }

        public void ConvertInputToMoves(string input)
        {
            input = input.ToUpper();

            this.StartRow = '8' - input[1];
            this.StartCol = input[0] - 'A';
            this.EndRow = '8' - input[4];
            this.EndCol = input[3] - 'A';
        }

        public void Draw(int x, int y)
        {
            Console.BackgroundColor = this.frame.BackgroundColor;
            Console.ForegroundColor = this.frame.ForegroundColor;
            frame.Draw(x, y);
            Console.SetCursorPosition(x + 1, y + 1);
            Console.Write(" ENTER MOVE:       ");
            Console.CursorLeft = x + 14;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
