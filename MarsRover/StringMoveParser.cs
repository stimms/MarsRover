using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover
{
    public class StringMoveParser:IMoveParser
    {
        public List<IMove> GetMoves(string moves)
        {
            List<IMove> returnValue = new List<IMove>();
            char[] tokens = moves.ToCharArray();
            foreach (char c in tokens)
            {
                switch (c)
                {
                    case 'L':
                        returnValue.Add(new LeftTurn());
                        break;
                    case 'R':
                        returnValue.Add(new RightTurn());
                        break;
                    default:
                        throw new InvalidMoveException();
                }
            }
            return returnValue;
        }
    }
}
