using System;
using System.IO;

namespace Hue1_Management
{
    public abstract class Ware
    {
        private int id;

        protected int ID
        {
            get => id;
            set => id = value;
        }

        protected Ware(int id)
        {
            this.id = id;
        }

        public abstract String Desc();
        public abstract String Shortcut(); 
    }
}