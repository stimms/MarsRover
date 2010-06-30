using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MarsRover
{
    public interface IGrid
    {
        bool IsValidLocation(Point location);
    }
}
