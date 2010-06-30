using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace MarsRover
{
    public class Rover
    {
        private Direction _direction;
        public Direction Direction
        {
            get { return _direction; }
            set { _direction = value; }
        }

        private IGrid grid { get; set; }

        private IMoveSupplier moveSupplier { get; set; }

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
            this.grid = grid;
            this.moveSupplier = moveSupplier;
        }

        public void ExecuteMoves()
        {
            while (moveSupplier.HasNextMove())
            {
                moveSupplier.NextMove().ExecuteMove(ref _direction, ref _location);
                if (!grid.IsValidLocation(_location))
                {
                    throw new InvalidLocationException();
                }
            }
        }

    }
}
