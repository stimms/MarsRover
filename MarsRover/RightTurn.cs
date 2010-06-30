using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MarsRover
{
    public class RightTurn:IMove
    {
        public void ExecuteMove(ref Direction direction, ref Point location)
        {
            switch (direction)
            {
                case Direction.North:
                    direction = Direction.East;
                    break;
                case Direction.South:
                    direction = Direction.West;
                    break;
                case Direction.East:
                    direction = Direction.South;
                    break;
                case Direction.West:
                    direction = Direction.North;
                    break;
                default:
                    throw new InvalidMoveException();
            }
        }
    }
}
