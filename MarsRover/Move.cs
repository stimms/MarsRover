using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;

namespace MarsRover
{
    public class Move:IMove
    {
        public void ExecuteMove(ref Direction direction, ref Point location)
        {
            switch (direction)
            {
                case Direction.N:
                    location = new Point(location.X, location.Y + 1);
                    break;
                case Direction.S:
                    location = new Point(location.X, location.Y - 1);
                    break;
                case Direction.E:
                    location = new Point(location.X + 1, location.Y);
                    break;
                case Direction.W:
                    location = new Point(location.X - 1, location.Y);
                    break;
                default:
                    throw new InvalidMoveException();
            }
        }
    }
}
