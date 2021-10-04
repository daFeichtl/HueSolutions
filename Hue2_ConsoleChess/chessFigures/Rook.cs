namespace Hue2_ConsoleChess
{
    public class Rook : ChessPiece
    {
        public Rook(bool isWhite) : base(isWhite)
        {
        }

        public override string GetSymbol()
        {
            return isWhite ? "\u2656" : "\u265C";
        }
    }
}