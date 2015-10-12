using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks.Basic
{
    public class Tank : WorldObject
    {

        public Tank (int height, int width, Position position, TankTypes type) : base (height, width, position)
        {
            this.Height = height;
            this.Width = width;
            this.Position = position;
            this.Type = type;
            MakeSuit();
        }

        public TankTypes Type
        {
            get { return this.Type; }
            set { this.Type = value; }
        }

        private void MakeSuit()
        {
            this.Suit = new Suit(this.Type);
        }
    }
}
