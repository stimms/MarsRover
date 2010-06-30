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
            Direction direction = Direction.N;
            Point location = new Point(1, 1);
            move.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.N, direction);
            Assert.AreEqual(new Point(1, 2), location);
        }

        [TestMethod]
        public void MoveSouth()
        {
            IMove move = new Move();
            Direction direction = Direction.S;
            Point location = new Point(1, 1);
            move.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.S, direction);
            Assert.AreEqual(new Point(1, 0), location);
        }

        [TestMethod]
        public void MoveEast()
        {
            IMove move = new Move();
            Direction direction = Direction.E;
            Point location = new Point(1, 1);
            move.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.E, direction);
            Assert.AreEqual(new Point(2, 1), location);
        }

        [TestMethod]
        public void MoveWest()
        {
            IMove move = new Move();
            Direction direction = Direction.W;
            Point location = new Point(1, 1);
            move.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.W, direction);
            Assert.AreEqual(new Point(0, 1), location);
        }
    }
}
