using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks.Basic
{
    public class WorldObject : IWorldObject
    {
        public WorldObject (int height, int width, Position position)
        {
            this.Height = height;
            this.Width = width;
            this.Position = position;
        }

        public int Height
        {
            get { return this.Height; }
            set { this.Height = value; }
        }

        public int Width
        {
            get { return this.Width; }
            set { this.Width = value; }
        }

        public Position Position
        {
            get { return this.Position; }
            set { this.Position = value; }
        }

        public Suit Suit
        {
            get { return this.Suit; }
            set { this.Suit = value; }
        }
    }
}
