using System.Text;

namespace Hue2_ConsoleChess
{
    public abstract class ChessPiece
    {
        public bool isWhite { get; set; }

        protected ChessPiece(bool isWhite)
        {
            this.isWhite = isWhite;
        }

        public abstract string GetSymbol();
    }
}