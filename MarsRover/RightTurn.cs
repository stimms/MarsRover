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
                case Direction.N:
                    direction = Direction.E;
                    break;
                case Direction.S:
                    direction = Direction.W;
                    break;
                case Direction.E:
                    direction = Direction.S;
                    break;
                case Direction.W:
                    direction = Direction.N;
                    break;
                default:
                    throw new InvalidMoveException();
            }
        }
    }
}
