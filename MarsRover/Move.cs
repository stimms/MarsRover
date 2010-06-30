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
                case Direction.North:
                    location = new Point(location.X, location.Y + 1);
                    break;
                case Direction.South:
                    location = new Point(location.X, location.Y - 1);
                    break;
                case Direction.East:
                    location = new Point(location.X + 1, location.Y);
                    break;
                case Direction.West:
                    location = new Point(location.X - 1, location.Y);
                    break;
                default:
                    throw new InvalidMoveException();
            }
        }
    }
}
