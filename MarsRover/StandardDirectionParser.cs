using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarsRover
{
    public class StandardDirectionParser:IDirectionParser
    {
        public Direction GetDirection(string location)
        {

            string direction = location.Split(' ').Skip(2).First();
            switch (direction)
            {
                case "N":
                case "n":
                    return Direction.N;
                    break;
                case "S":
                case "s":
                    return Direction.S;
                    break;
                case "E":
                case "e":
                    return Direction.E;
                    break;
                case "W":
                case "w":
                    return Direction.W;
                    break;
                default:
                    throw new InvalidLocationException();
            }

            
        }
    }
}
