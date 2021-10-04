using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Hue2_ConsoleChess
{
    public class ChessBoard
    {

        private ChessPiece[,] board;

        private void SetNewBoard()
        {
            board = new ChessPiece[8, 8];
            board[1,0] = new Pawn(true);
            board[1,1] = new Pawn(true);
            board[1,2] = new Pawn(true);
            board[1,3] = new Pawn(true);
            board[1,4] = new Pawn(true);
            board[1,5] = new Pawn(true);
            board[1,6] = new Pawn(true);
            board[1,7] = new Pawn(true);

            board[0,0] = new Rook(true);
            board[0,7] = new Rook(true);

            board[0,1] = new Knight(true);
            board[0,6] = new Knight(true);

            board[0,2] = new Bishop(true);
            board[0,5] = new Bishop(true);

            board[0,3] = new King(true);
            board[0,4] = new Queen(true);
            
            
            board = new ChessPiece[8, 8];
            board[1,0] = new Pawn(false);
            board[1,1] = new Pawn(false);
            board[1,2] = new Pawn(false);
            board[1,3] = new Pawn(false);
            board[1,4] = new Pawn(false);
            board[1,5] = new Pawn(false);
            board[1,6] = new Pawn(false);
            board[1,7] = new Pawn(false);

            board[0,0] = new Rook(false);
            board[0,7] = new Rook(false);

            board[0,1] = new Knight(false);
            board[0,6] = new Knight(false);

            board[0,2] = new Bishop(false);
            board[0,5] = new Bishop(false);

            board[0,3] = new King(false);
            board[0,4] = new Queen(false);
            
        }

        public static void Main(string[] args)
        {
            new ChessBoard().Run();
        }

        private void Run()
        {
            SetNewBoard();
            Console.OutputEncoding = Encoding.UTF8;
            PrintBoard();
            Console.ReadKey();
        }
        
        private void UpdateFigures()
        {
            
        }
        
        private void PrintBoard()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            
            StringBuilder chessField = new StringBuilder();
            chessField.Append("+");
            for (int i = 0; i < 8; i++)
            {
                chessField.Append("---+---+---+---+---+---+---+---+\n");
                for (int j = 0; j < 8; j++)
                {
                    chessField.Append(board[i, j] != null ? $"| {board[i, j].GetSymbol()} |" : "|   |");
                }

                chessField.Append("\n");
            }

            Console.WriteLine(chessField.ToString());
        }
    }
}