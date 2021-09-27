using System;

namespace Hue1_Management
{
    public class MainClass
    {
        private static void Main(string[] args)
        {
            run();
            Test.Testing();
        }

        private static void run()
        {
            ShelfWare ware = new ShelfWare(6, 5);
            
            ware.Store(5, 3, new Books(1,20,15,3));
            ware.Store(3, 4, new Books(2,20,16,6));
            ware.Store(4, 2, new Books(3,22,13,3));
            ware.Store(2, 4, new Books(4,25,17,10));
            ware.Store(1, 1, new Books(5,11,9,4));
            ware.Store(5, 2, new Tool(6,6.2));
            ware.Store(3, 3, new Tool(7,3.5));
            ware.Store(2, 2, new Tool(8,8.1));
            ware.Store(4, 1, new Tool(9,4.6));
            
            ware.Show();
        }
    }
}