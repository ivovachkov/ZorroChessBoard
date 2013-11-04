using System;

namespace ChessBoard
{
    class Program
    {
        static void Main()
        {
            Console.SetWindowSize(110, 70);
            Console.SetBufferSize(110, 70);
            Console.SetWindowPosition(0, 0);

            Board chessBoard = new Board(106, 58);
            chessBoard.Draw();

            MoveEntry moveEntry = new MoveEntry();

            ChessClock firstChessClock = new ChessClock();
            firstChessClock.Draw(41, 60);
            

            ChessClock secondChessClock = new ChessClock();
            secondChessClock.Frame.ForegroundColor = ConsoleColor.Black;
            secondChessClock.Frame.BackgroundColor = ConsoleColor.Gray;
            secondChessClock.Draw(59, 60);

            Player firstPlayer = new Player(" PLAYER 1 ", PieceColor.White);
            Player secondPlayer = new Player(" PLAYER 2 ", PieceColor.Black);
            firstPlayer.Draw(41, 63);
            secondPlayer.Draw(59, 63);

            try
            {
                while (true)
                {
                    moveEntry.Draw(3, 65);
                    string input = Console.ReadLine();
                    moveEntry.ConvertInputToMoves(input);
                    System.Threading.Thread.Sleep(1000);
                    chessBoard.MovePiece(moveEntry.StartRow, moveEntry.StartCol,
                        moveEntry.EndRow, moveEntry.EndCol);

                    firstChessClock.DisplayCountDown(41,60);
                }
            }
            catch (Exception)
            {
                throw new InvaildMoveException("Invaild Move!");
            }


        }
    }
}