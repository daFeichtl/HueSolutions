namespace Hue2_ConsoleChess
{
    public class Knight : ChessPiece
    {
        public Knight(bool isWhite) : base(isWhite)
        {
        }

        public override string GetSymbol()
        {
            return isWhite ? "\u2658" : "\u265E";
        }
    }
}