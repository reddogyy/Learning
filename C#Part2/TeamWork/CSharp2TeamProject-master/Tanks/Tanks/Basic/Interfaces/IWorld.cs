using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks.Basic.Interfaces
{
    public interface IWorld
    {
        int Height { get; set; }
        int Width  { get; set; }
    }
}
