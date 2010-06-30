using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;   

namespace MarsRover
{
    public class Rover
    {
        public Direction Direction { get; set; }

        private Point _location;
        public Point Location
        {
            get
            {
                return _location;
            }
            set
            {
                if (value.X < 0 || value.Y < 0)
                    throw new InvalidLocationException();
                _location = value;
            }
        }

        public Rover(Direction direction, Point location, IGrid grid, IMoveSupplier moveSupplier)
        {
            this.Direction = direction;
            this.Location = location;
        }

    }
}
