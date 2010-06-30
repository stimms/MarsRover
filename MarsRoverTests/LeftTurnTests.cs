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
    public class LeftTurnTests
    {
        //only 16 possible states - might as well model check

        [TestMethod]
        public void OneLeftFromNorth()
        {
            LeftTurn leftTurn = new LeftTurn();
            Direction direction = Direction.N;
            Point location = new Point(0, 0);
            leftTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.W, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void TwoLeftFromNorth()
        {
            LeftTurn leftTurn = new LeftTurn();
            Direction direction = Direction.N;
            Point location = new Point(0, 0);
            leftTurn.ExecuteMove(ref direction, ref location);
            leftTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.S, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void ThreeLeftFromNorth()
        {
            LeftTurn leftTurn = new LeftTurn();
            Direction direction = Direction.N;
            Point location = new Point(0, 0);
            leftTurn.ExecuteMove(ref direction, ref location);
            leftTurn.ExecuteMove(ref direction, ref location);
            leftTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.E, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void FourLeftFromNorth()
        {
            LeftTurn leftTurn = new LeftTurn();
            Direction direction = Direction.N;
            Point location = new Point(0, 0);
            leftTurn.ExecuteMove(ref direction, ref location);
            leftTurn.ExecuteMove(ref direction, ref location);
            leftTurn.ExecuteMove(ref direction, ref location);
            leftTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.N, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void OneLeftFromEast()
        {
            LeftTurn leftTurn = new LeftTurn();
            Direction direction = Direction.E;
            Point location = new Point(0, 0);
            leftTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.N, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void TwoLeftFromEast()
        {
            LeftTurn leftTurn = new LeftTurn();
            Direction direction = Direction.E;
            Point location = new Point(0, 0);
            leftTurn.ExecuteMove(ref direction, ref location);
            leftTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.W, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void ThreeLeftFromEast()
        {
            LeftTurn leftTurn = new LeftTurn();
            Direction direction = Direction.E;
            Point location = new Point(0, 0);
            leftTurn.ExecuteMove(ref direction, ref location);
            leftTurn.ExecuteMove(ref direction, ref location);
            leftTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.S, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void FourLeftFromEast()
        {
            LeftTurn leftTurn = new LeftTurn();
            Direction direction = Direction.E;
            Point location = new Point(0, 0);
            leftTurn.ExecuteMove(ref direction, ref location);
            leftTurn.ExecuteMove(ref direction, ref location);
            leftTurn.ExecuteMove(ref direction, ref location);
            leftTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.E, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void OneLeftFromSouth()
        {
            LeftTurn leftTurn = new LeftTurn();
            Direction direction = Direction.S;
            Point location = new Point(0, 0);
            leftTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.E, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void TwoLeftFromSouth()
        {
            LeftTurn leftTurn = new LeftTurn();
            Direction direction = Direction.S;
            Point location = new Point(0, 0);
            leftTurn.ExecuteMove(ref direction, ref location);
            leftTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.N, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void ThreeLeftFromSouth()
        {
            LeftTurn leftTurn = new LeftTurn();
            Direction direction = Direction.S;
            Point location = new Point(0, 0);
            leftTurn.ExecuteMove(ref direction, ref location);
            leftTurn.ExecuteMove(ref direction, ref location);
            leftTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.W, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void FourLeftFromSouth()
        {
            LeftTurn leftTurn = new LeftTurn();
            Direction direction = Direction.S;
            Point location = new Point(0, 0);
            leftTurn.ExecuteMove(ref direction, ref location);
            leftTurn.ExecuteMove(ref direction, ref location);
            leftTurn.ExecuteMove(ref direction, ref location);
            leftTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.S, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void OneLeftFromWest()
        {
            LeftTurn leftTurn = new LeftTurn();
            Direction direction = Direction.W;
            Point location = new Point(0, 0);
            leftTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.S, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void TwoLeftFromWest()
        {
            LeftTurn leftTurn = new LeftTurn();
            Direction direction = Direction.W;
            Point location = new Point(0, 0);
            leftTurn.ExecuteMove(ref direction, ref location);
            leftTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.E, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void ThreeLeftFromWest()
        {
            LeftTurn leftTurn = new LeftTurn();
            Direction direction = Direction.W;
            Point location = new Point(0, 0);
            leftTurn.ExecuteMove(ref direction, ref location);
            leftTurn.ExecuteMove(ref direction, ref location);
            leftTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.N, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void FourLeftFromWest()
        {
            LeftTurn leftTurn = new LeftTurn();
            Direction direction = Direction.W;
            Point location = new Point(0, 0);
            leftTurn.ExecuteMove(ref direction, ref location);
            leftTurn.ExecuteMove(ref direction, ref location);
            leftTurn.ExecuteMove(ref direction, ref location);
            leftTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.W, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }
    }
}
