namespace Hue2_ConsoleChess
{
    public class Queen : ChessPiece
    {
        public Queen(bool isWhite) : base(isWhite)
        {
        }

        public override string GetSymbol()
        {
            return isWhite ? "\u2655" : "\u265B";
        }
    }
}