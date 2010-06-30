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
                case Direction.N:
                    direction = Direction.W;
                    break;
                case Direction.S:
                    direction = Direction.E;
                    break;
                case Direction.E:
                    direction = Direction.N;
                    break;
                case Direction.W:
                    direction = Direction.S;
                    break;
                default:
                    throw new InvalidMoveException();
            }
        }
    }
}
