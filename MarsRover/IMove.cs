using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;

namespace MarsRover
{
    public interface IMove
    {
        void ExecuteMove(ref Direction direction, ref Point location);
    }
}
