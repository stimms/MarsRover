using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MarsRover
{
    public class LeftTurn: IMove
    {
        public void ExecuteMove(ref Direction direction, ref Point location)
        {
            switch (direction)
            {
                case Direction.North:
                    direction = Direction.West;
                    break;
                case Direction.South:
                    direction = Direction.East;
                    break;
                case Direction.East:
                    direction = Direction.North;
                    break;
                case Direction.West:
                    direction = Direction.South;
                    break;
                default:
                    throw new InvalidMoveException();
            }
        }
    }
}
