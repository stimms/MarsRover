﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

using MarsRover;

namespace MarsRoverTests
{
    [TestClass]
    public class RightTurnTests
    {

        //only 16 possible states - might as well model check

        [TestMethod]
        public void OneRightFromNorth()
        {
            RightTurn RightTurn = new RightTurn();
            Direction direction = Direction.N;
            Point location = new Point(0, 0);
            RightTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.E, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void TwoRightFromNorth()
        {
            RightTurn RightTurn = new RightTurn();
            Direction direction = Direction.N;
            Point location = new Point(0, 0);
            RightTurn.ExecuteMove(ref direction, ref location);
            RightTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.S, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void ThreeRightFromNorth()
        {
            RightTurn RightTurn = new RightTurn();
            Direction direction = Direction.N;
            Point location = new Point(0, 0);
            RightTurn.ExecuteMove(ref direction, ref location);
            RightTurn.ExecuteMove(ref direction, ref location);
            RightTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.W, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void FourRightFromNorth()
        {
            RightTurn RightTurn = new RightTurn();
            Direction direction = Direction.N;
            Point location = new Point(0, 0);
            RightTurn.ExecuteMove(ref direction, ref location);
            RightTurn.ExecuteMove(ref direction, ref location);
            RightTurn.ExecuteMove(ref direction, ref location);
            RightTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.N, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void OneRightFromEast()
        {
            RightTurn RightTurn = new RightTurn();
            Direction direction = Direction.E;
            Point location = new Point(0, 0);
            RightTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.S, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void TwoRightFromEast()
        {
            RightTurn RightTurn = new RightTurn();
            Direction direction = Direction.E;
            Point location = new Point(0, 0);
            RightTurn.ExecuteMove(ref direction, ref location);
            RightTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.W, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void ThreeRightFromEast()
        {
            RightTurn RightTurn = new RightTurn();
            Direction direction = Direction.E;
            Point location = new Point(0, 0);
            RightTurn.ExecuteMove(ref direction, ref location);
            RightTurn.ExecuteMove(ref direction, ref location);
            RightTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.N, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void FourRightFromEast()
        {
            RightTurn RightTurn = new RightTurn();
            Direction direction = Direction.E;
            Point location = new Point(0, 0);
            RightTurn.ExecuteMove(ref direction, ref location);
            RightTurn.ExecuteMove(ref direction, ref location);
            RightTurn.ExecuteMove(ref direction, ref location);
            RightTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.E, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void OneRightFromSouth()
        {
            RightTurn RightTurn = new RightTurn();
            Direction direction = Direction.S;
            Point location = new Point(0, 0);
            RightTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.W, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void TwoRightFromSouth()
        {
            RightTurn RightTurn = new RightTurn();
            Direction direction = Direction.S;
            Point location = new Point(0, 0);
            RightTurn.ExecuteMove(ref direction, ref location);
            RightTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.N, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void ThreeRightFromSouth()
        {
            RightTurn RightTurn = new RightTurn();
            Direction direction = Direction.S;
            Point location = new Point(0, 0);
            RightTurn.ExecuteMove(ref direction, ref location);
            RightTurn.ExecuteMove(ref direction, ref location);
            RightTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.E, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void FourRightFromSouth()
        {
            RightTurn RightTurn = new RightTurn();
            Direction direction = Direction.S;
            Point location = new Point(0, 0);
            RightTurn.ExecuteMove(ref direction, ref location);
            RightTurn.ExecuteMove(ref direction, ref location);
            RightTurn.ExecuteMove(ref direction, ref location);
            RightTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.S, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void OneRightFromWest()
        {
            RightTurn RightTurn = new RightTurn();
            Direction direction = Direction.W;
            Point location = new Point(0, 0);
            RightTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.N, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void TwoRightFromWest()
        {
            RightTurn RightTurn = new RightTurn();
            Direction direction = Direction.W;
            Point location = new Point(0, 0);
            RightTurn.ExecuteMove(ref direction, ref location);
            RightTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.E, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void ThreeRightFromWest()
        {
            RightTurn RightTurn = new RightTurn();
            Direction direction = Direction.W;
            Point location = new Point(0, 0);
            RightTurn.ExecuteMove(ref direction, ref location);
            RightTurn.ExecuteMove(ref direction, ref location);
            RightTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.S, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

        [TestMethod]
        public void FourRightFromWest()
        {
            RightTurn RightTurn = new RightTurn();
            Direction direction = Direction.W;
            Point location = new Point(0, 0);
            RightTurn.ExecuteMove(ref direction, ref location);
            RightTurn.ExecuteMove(ref direction, ref location);
            RightTurn.ExecuteMove(ref direction, ref location);
            RightTurn.ExecuteMove(ref direction, ref location);
            Assert.AreEqual(Direction.W, direction);
            Assert.AreEqual(new Point(0, 0), location);
        }

    }
}
