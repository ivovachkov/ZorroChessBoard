using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoard
{
    class Board : IDrawable
    {
        private const int Top = 0;
        private const int Left = 3;
        private const int SquareWidth = 13;
        private const int SquareHeight = 7;

        private SquareData[,] squareMatrix = new SquareData[8, 8];
        public int Width { get; set; }
        public int Height { get; set; }
        private BoardColors chessboardColors;

        public Board(int width, int height)
        {
            this.Width = width;
            this.Height = height;
            this.chessboardColors.BoardFrameColor = ConsoleColor.DarkRed;
            this.chessboardColors.WhitePiecesColor = ConsoleColor.White;
            this.chessboardColors.BlackPiecesColor = ConsoleColor.Black;
            this.chessboardColors.WhiteSquaresColor = ConsoleColor.Gray;
            this.chessboardColors.BlackSquaresColor = ConsoleColor.DarkGray;
            this.InitializeBoard();
        }

        private void InitializeBoard()
        {
            SetSquareColors();

            //Pawns
            for (int col = 0; col < this.squareMatrix.GetLength(1); col++)
            {
                InitializeSquare(1, col, PieceType.Pawn, PieceColor.Black);
                InitializeSquare(6, col, PieceType.Pawn, PieceColor.White);
            }

            //Rooks
            InitializeSquare(0, 0, PieceType.Rook, PieceColor.Black);
            InitializeSquare(0, 7, PieceType.Rook, PieceColor.Black);
            InitializeSquare(7, 0, PieceType.Rook, PieceColor.White);
            InitializeSquare(7, 7, PieceType.Rook, PieceColor.White);

            //Knights
            InitializeSquare(0, 1, PieceType.Knight, PieceColor.Black);
            InitializeSquare(0, 6, PieceType.Knight, PieceColor.Black);
            InitializeSquare(7, 1, PieceType.Knight, PieceColor.White);
            InitializeSquare(7, 6, PieceType.Knight, PieceColor.White);

            //Bishops
            InitializeSquare(0, 2, PieceType.Bishop, PieceColor.Black);
            InitializeSquare(0, 5, PieceType.Bishop, PieceColor.Black);
            InitializeSquare(7, 2, PieceType.Bishop, PieceColor.White);
            InitializeSquare(7, 5, PieceType.Bishop, PieceColor.White);

            //Queens
            InitializeSquare(0, 3, PieceType.Queen, PieceColor.Black);
            InitializeSquare(7, 3, PieceType.Queen, PieceColor.White);

            //Kings
            InitializeSquare(0, 4, PieceType.King, PieceColor.Black);
            InitializeSquare(7, 4, PieceType.King, PieceColor.White);

            //Empty Squares
            for (int row = 2; row < this.squareMatrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < this.squareMatrix.GetLength(1); col++)
                {
                    InitializeSquare(row, col, PieceType.None, PieceColor.None);
                }
            }

            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    int x = Left + 1 + col * SquareWidth;
                    int y = Top + 1 + row * SquareHeight;

                    this.squareMatrix[row, col].X = x;
                    this.squareMatrix[row, col].Y = y;
                }
            }
        }

        private void InitializeSquare(int row, int col, PieceType pType, PieceColor pColor)
        {
            this.squareMatrix[row, col].PType = pType;
            this.squareMatrix[row, col].PColor = pColor;
        }

        // Filling the color matrix
        public void SetSquareColors()
        {
            for (int row = 0; row < 8; row += 2)
            {
                for (int col = 0; col < 8; col++)
                {
                    if (col % 2 == 0)
                    {
                        squareMatrix[row, col].SquareColor = this.chessboardColors.WhiteSquaresColor;
                        squareMatrix[row + 1, col].SquareColor = chessboardColors.BlackSquaresColor;
                    }
                    else
                    {
                        squareMatrix[row, col].SquareColor = chessboardColors.BlackSquaresColor;
                        squareMatrix[row + 1, col].SquareColor = chessboardColors.WhiteSquaresColor;
                    }
                }
            }
        }

        public void Draw(int x = Left, int y = Top)
        {
            this.DrawFrame(Left, Top);

            // Drawing 1 2 3 4 5 6 7 8
            this.DrawBoardNumbers(Left,Top);

            // Drawing A B C D E F G H
            this.DrawBoardLetters(Left, Top);

            this.DrawAllPieces();

            this.DrawClocks();

            this.DrawMoveEntry();
        }

        private void DrawMoveEntry()
        {
            //throw new NotImplementedException();
        }

        private void DrawClocks()
        {
            //throw new NotImplementedException();
        }

        private void DrawAllPieces()
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Console.BackgroundColor = this.squareMatrix[row, col].SquareColor;
                    if (this.squareMatrix[row, col].PColor == PieceColor.White)
                    {
                        Console.ForegroundColor = chessboardColors.WhitePiecesColor;
                    }
                    else
                    {
                        Console.ForegroundColor = chessboardColors.BlackPiecesColor;
                    }
                    DrawPiece(this.squareMatrix[row, col].PType,
                        this.squareMatrix[row, col].X,
                        this.squareMatrix[row, col].Y);
                }
            }
        }

        private void DrawPiece(PieceType pType, int x, int y)
        {
            switch (pType)
            {
                case PieceType.Pawn:
                    Pawn pawn = new Pawn();
                    pawn.Draw(x, y);
                    break;

                case PieceType.Rook:
                    Rook rook = new Rook();
                    rook.Draw(x, y);
                    break;

                case PieceType.Knight:
                    Knight knight = new Knight();
                    knight.Draw(x, y);
                    break;

                case PieceType.Bishop:
                    Bishop bishop = new Bishop();
                    bishop.Draw(x, y);
                    break;

                case PieceType.King:
                    King king = new King();
                    king.Draw(x, y);
                    break;

                case PieceType.Queen:
                    Queen queen = new Queen();
                    queen.Draw(x, y);
                    break;
                    
                default:                    
                    Square square = new Square() 
                    {
                        Width = SquareWidth,
                        Height = SquareHeight
                    };
                    square.Draw(x, y);
                    break;
            }
        }

        private void DrawFrame(int x, int y)
        {
            Frame boardFrame = new Frame()
            {
                Width = this.Width,
                Height = this.Height,
                ForegroundColor = this.chessboardColors.BoardFrameColor,
                BackgroundColor = ConsoleColor.Black,
                FrameSymbols = new FrameSymbol()
                {
                    TopLeftCorner = '▄',
                    TopRightCorner = '▄',
                    BottomLeftCorner = '▀',
                    BottomRightCorner = '▀',
                    TopHorBorder = '▄',
                    BotHorBorder = '▀',
                    VertBorder = '█'
                },
            };

            Console.BackgroundColor = boardFrame.BackgroundColor;
            Console.ForegroundColor = boardFrame.ForegroundColor;
            boardFrame.Draw(x, y);
        }
                

        private void DrawBoardNumbers(int x, int y)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            for (int row = 8, number = 0; row > 0; row--, number++)
            {
                int left = x - 2;
                int top = y + 4 + (number * 7);

                Console.SetCursorPosition(left, top);
                Console.WriteLine(row);
            }
        }

        private void DrawBoardLetters(int x, int y)
        {
            Console.CursorTop = y + this.Height;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            for (int col = 0; col < 8; col++)
            {
                int left = x + 7 + (col * 13);
                Console.CursorLeft = left;
                Console.Write((char)('A' + col));
            }
        }

        public void MovePiece(int startRow, int startCol, int endRow, int endCol)
        {
            this.squareMatrix[endRow, endCol].PType = this.squareMatrix[startRow, startCol].PType;
            this.squareMatrix[endRow, endCol].PColor = this.squareMatrix[startRow, startCol].PColor;
            this.squareMatrix[startRow, startCol].PType = PieceType.None;
            this.squareMatrix[startRow, startCol].PColor = PieceColor.None;
            
            Console.BackgroundColor = this.squareMatrix[startRow,startCol].SquareColor;
            DrawPiece(PieceType.None, this.squareMatrix[startRow, startCol].X, this.squareMatrix[startRow, startCol].Y);


            Console.BackgroundColor = this.squareMatrix[endRow, endCol].SquareColor;
            if (this.squareMatrix[endRow, endCol].PColor == PieceColor.White)
            {
                Console.ForegroundColor = chessboardColors.WhitePiecesColor;
            }
            else
            {
                Console.ForegroundColor = chessboardColors.BlackPiecesColor;
            }

            DrawPiece(this.squareMatrix[endRow,endCol].PType, 
                this.squareMatrix[endRow, endCol].X, 
                this.squareMatrix[endRow, endCol].Y);
        }
    }
}