using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks.Basic
{
    public class StaticObject : WorldObject
    {
        public StaticObject (int height, int width, Position position)
            : base(height, width, position)
        {
            this.Height = height;
            this.Width = width;
            this.Position = position;
        }


    }
}
