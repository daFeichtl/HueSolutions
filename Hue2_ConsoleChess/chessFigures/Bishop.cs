namespace Hue2_ConsoleChess
{
    public class Bishop : ChessPiece
    {
        public Bishop(bool isWhite) : base(isWhite)
        {
        }

        public override string GetSymbol()
        {
            return isWhite ? "\u2657" : "\u265D";
        }
    }
}