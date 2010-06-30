using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MarsRover;
using System.Drawing;

namespace MarsRoverTests
{
    [TestClass]
    public class StandardGridTests
    {
        [TestMethod]
        public void TestLegal()
        {
            IGrid grid = new StandardGrid();
            grid.InitiGrid(4, 4);
            Assert.IsTrue(grid.IsValidLocation(new Point(1, 1)));
        }

        [TestMethod]
        public void TestIllegalNegativeXLocation()
        {
            IGrid grid = new StandardGrid();
            grid.InitiGrid(4, 4);
            Assert.IsFalse(grid.IsValidLocation(new Point(-1, 1)));
        }

        [TestMethod]
        public void TestIllegalNegativeYLocation()
        {
            IGrid grid = new StandardGrid();
            grid.InitiGrid(4, 4);
            Assert.IsFalse(grid.IsValidLocation(new Point(1, -1)));
        }

        [TestMethod]
        public void TestIllegalPositiveXLocation()
        {
            IGrid grid = new StandardGrid();
            grid.InitiGrid(4, 4);
            Assert.IsFalse(grid.IsValidLocation(new Point(5, 1)));
        }

        [TestMethod]
        public void TestIllegalPositiveYLocation()
        {
            IGrid grid = new StandardGrid();
            grid.InitiGrid(4, 4);
            Assert.IsFalse(grid.IsValidLocation(new Point(1, 5)));
        }

        [TestMethod]
        public void TestIllegalPositiveXYLocation()
        {
            IGrid grid = new StandardGrid();
            grid.InitiGrid(4, 4);
            Assert.IsFalse(grid.IsValidLocation(new Point(5, 5)));
        }
    }
}
