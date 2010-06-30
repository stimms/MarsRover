using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover
{
    public interface IDirectionParser
    {
        Direction GetDirection(string location);
    }
}
