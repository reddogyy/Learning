using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tanks.Basic
{
    public interface IWorldObject
    {
        int Height { get; set; }
        int Width { get; set; }
        Position Position { get; set; }
        Suit Suit { get; }
    }
}
