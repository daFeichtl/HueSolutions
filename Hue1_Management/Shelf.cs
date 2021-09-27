using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Hue1_Management
{
    public class ShelfWare
    {
        private Ware[,] Shelf;
        private int count = 0;
        public ShelfWare(int rows, int cols)
        {
            Shelf = new Ware[rows, cols];
            
        }

        public void Show()
        {
            int length = Shelf.GetLength(0);
            string row = CreateRow(length-1);
            Console.WriteLine(row);

            for (int i = 0; i < length; i++)
            {
                Console.Write("|");
                for (int j = 0; j < Shelf.GetLength(1); j++)
                {
                    if (Shelf[i,j] == null)
                    {
                        Console.Write("   |");
                    }
                    else
                    {
                        Console.Write($" {Shelf[i,j].Shortcut()} |");
                        count++;
                    }
                }
                Console.Write("\n");
                Console.WriteLine(row);
            }
            Console.WriteLine($"Load: {GetLoad():P}");
        }

        private string CreateRow(int cols)
        {
            List<string> lines = new List<string>();
            StringBuilder sb = new StringBuilder();
            sb.Append("-");
            for (int i = 0; i < cols; i++)
            {
                sb.Append("----");
            }

            return sb.ToString();
        }

        
            

        public double GetLoad()
        {
            return Convert.ToDouble(count) / 
                (Convert.ToDouble(Shelf.GetLength(0)) *
                 Convert.ToDouble(Shelf.GetLength(1)));
        }

        public Ware Supply(int row, int col)
        {
            Ware ware = Shelf[row,col];
            Shelf[row, col] = null;
            return ware;
        }

        public void Store(Ware ware)
        {
            for (int i = 0; i < Shelf.GetLength(0); i++)
            {
                for (int j = 0; j < Shelf.GetLength(1); j++)
                {
                    if (Shelf[i, j] != null) continue;
                    Shelf[i, j] = ware;
                    return;
                }
            }
        }

        public bool Store(int row, int col, Ware ware)
        {
            if (Shelf[row,col] == null)
            {
                Shelf[row, col] = ware;
                return true;
            }
            Console.WriteLine($"Position {row}/{col} occupied: {Shelf[row,col].Desc()}");
            return false;
        }

        
    }
}