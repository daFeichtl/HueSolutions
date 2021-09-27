using System.Runtime.InteropServices;

namespace Hue1_Management
{
    public class Books : Ware
    {
        private int Width { get; set; }
        private int Height { get; set; }
        private int Length { get; set; }


        public Books(int id, int width, int height, int length) : base(id)
        {
            Width = width;
            Height = height;
            Length = length;
        }

        public override string Desc()
        {
            return $"#{base.ID}: Book {Width}x{Height}x{Length}";
        }

        public override string Shortcut()
        {
            return "B";
        }
    }
}