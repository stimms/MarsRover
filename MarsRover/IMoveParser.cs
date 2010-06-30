using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover
{
    interface IMoveParser
    {
        List<IMove> GetMoves(string moves);
    }
}
