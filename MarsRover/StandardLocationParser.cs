using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MarsRover
{
    public class StandardLocationParser:ILocationParser
    {
        public Point GetLocation(string location)
        {
            return new Point(Int32.Parse(location.Split(' ').First()), Int32.Parse(location.Split(' ').Skip(1).First()));
        }
    }
}
