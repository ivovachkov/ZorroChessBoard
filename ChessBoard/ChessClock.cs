using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ChessBoard
{
    class ChessClock : IDrawable
    {
        public Frame Frame { get; set; }


        public ChessClock()
        {
            this.Frame = new Frame()
            {
                Width = 12,
                Height = 3,
                ForegroundColor = ConsoleColor.White,
                BackgroundColor = ConsoleColor.DarkGray,
                FrameSymbols = new FrameSymbol()
                {
                    TopLeftCorner = '┌',
                    TopRightCorner = '┐',
                    BottomLeftCorner = '└',
                    BottomRightCorner = '┘',
                    TopHorBorder = '─',
                    BotHorBorder = '─',
                    VertBorder = '│'
                }
            };
        }

        public void Draw(int x, int y)
        {
            Console.BackgroundColor = this.Frame.BackgroundColor;
            Console.ForegroundColor = this.Frame.ForegroundColor;
            Frame.Draw(x, y);
            Console.SetCursorPosition(x + 1, y + 1);
            //Console.Write(" 00:00:00 ");
            Console.CursorLeft = x + 13;
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void DisplayCountDown(int x, int y)
        {
            Thread.Sleep(1000);
            for (int min = 1; min >= 0; --min)
            {
                for (int sec = 59; sec >= 0; --sec)
                {
                    if (min == 1) { Console.Clear(); }
                    Console.SetCursorPosition(x + 1, y + 1);
                    Console.Write("Time: {0} : {1}", min, sec);
                    Console.CursorLeft = x + 13;
                    Thread.Sleep(1000);
                }
            }
            Console.WriteLine("Your time is up !");
        }
    }
}
