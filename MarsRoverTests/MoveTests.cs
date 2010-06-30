using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;


using MarsRover;

namespace MarsRoverTests
{
    [TestClass]
    public class MoveTests
    {
        [TestMethod]
        public void MoveNorth()
        {
            IMove move = new Move();
            Direction direction = Direction.North;
            Point location = new Point(1, 1);
            move.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.North, direction);
            Assert.AreEqual(new Point(1, 2), location);
        }

        [TestMethod]
        public void MoveSouth()
        {
            IMove move = new Move();
            Direction direction = Direction.South;
            Point location = new Point(1, 1);
            move.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.South, direction);
            Assert.AreEqual(new Point(1, 0), location);
        }

        [TestMethod]
        public void MoveEast()
        {
            IMove move = new Move();
            Direction direction = Direction.East;
            Point location = new Point(1, 1);
            move.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.East, direction);
            Assert.AreEqual(new Point(2, 1), location);
        }

        [TestMethod]
        public void MoveWest()
        {
            IMove move = new Move();
            Direction direction = Direction.West;
            Point location = new Point(1, 1);
            move.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.West, direction);
            Assert.AreEqual(new Point(0, 1), location);
        }
    }
}
