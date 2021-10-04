namespace Hue2_ConsoleChess
{
    public class Pawn : ChessPiece
    {
        public Pawn(bool isWhite) : base(isWhite)
        {
            
        }

        public override string GetSymbol()
        {
            return isWhite ? "\u2659" : "\u265F";
        }
    }
}