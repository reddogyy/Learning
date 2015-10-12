using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tanks.Basic.Interfaces
{
    public interface IPlayer
    {
        int Lives { get; set; }
        Tank Tank { get; set; }
    }
}
