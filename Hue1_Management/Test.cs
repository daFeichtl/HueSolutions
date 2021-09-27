using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Hue1_Management
{
    public class Test
    {
        public static void Testing()
        {
            string[] lines = File.ReadAllLines("../../../waren.csv");
            ShelfWare ware = LoadShelf(6, 5, lines);
            ware.Show();
        }
        
        public static ShelfWare LoadShelf(int rows, int cols, string[] lines)
        {
            ShelfWare ware = new ShelfWare(rows, cols);
            
            for (int i = 0; i < lines.GetLength(0)-1; i++)
            {
                string[] line = lines[i].Split(";");
                if (line[0].Contains("Werkzeug"))
                {
                    ware.Store(Convert.ToInt32(line[1]),
                        Convert.ToInt32(line[2]),
                        new Tool(Convert.ToInt32(line[3]), Convert.ToDouble(line[4])));
                }
                else
                {
                    ware.Store(Convert.ToInt32(line[1]),
                        Convert.ToInt32(line[2]),
                        new Books(Convert.ToInt32(line[3]), Convert.ToInt32(line[4]), Convert.ToInt32(line[5]), Convert.ToInt32(line[6])));
                }
            }

            return ware;
        }
    }
}