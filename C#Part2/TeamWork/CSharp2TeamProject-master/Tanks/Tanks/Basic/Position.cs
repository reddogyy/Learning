using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks.Basic
{
    public class Position
    {
        public Position (int x, int y) 
        {
            this.X = x;
            this.Y = y;
        }

        public int X
        {
            get { return this.X; }
            set { this.X = value; }
        }

        public int Y
        {
            get { return this.Y; }
            set { this.Y = value; }
        }        
    }
}
