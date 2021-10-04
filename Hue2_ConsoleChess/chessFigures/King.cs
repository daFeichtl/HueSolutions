namespace Hue2_ConsoleChess
{
    public class King : ChessPiece
    {
        public King(bool isWhite) : base(isWhite)
        {
        }

        public override string GetSymbol()
        {
            return isWhite ? "\u2654" : "\u265A";
        }
    }
}