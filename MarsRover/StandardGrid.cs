using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace MarsRover
{
    public class StandardGrid:IGrid
    {
        private int width;
        private int height;

        public void InitiGrid(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public bool IsValidLocation(Point location)
        {
            if (location.X < 0 || location.Y < 0)
                return false;
            if (location.X > width)
            {
                return false;
            }
            if (location.Y > height)
            {
                return false;
            }
            return true;
        }
    }
}
