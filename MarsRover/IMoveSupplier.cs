using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover
{
    public interface IMoveSupplier
    {
        void Init(string moves);
        IMove NextMove();
        bool HasNextMove();
    }
}
