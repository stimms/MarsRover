using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MarsRover;

namespace MarsRoverTests
{
    [TestClass]
    public class StringMoveParserTests
    {
        [TestMethod]
        public void ReturnsMovesForOneLeft()
        {
            StringMoveParser parser = new StringMoveParser();
            List<IMove> moves = parser.GetMoves("L");
            Assert.AreEqual(1, moves.Count);
        }

        [TestMethod]
        public void ReturnsTwoMovesForTwoLeft()
        {
            StringMoveParser parser = new StringMoveParser();
            List<IMove> moves = parser.GetMoves("LL");
            Assert.AreEqual(2, moves.Count);
        }

        [TestMethod]
        public void ReturnsForOneLeft()
        {
            StringMoveParser parser = new StringMoveParser();
            List<IMove> moves = parser.GetMoves("L");
            Assert.IsInstanceOfType(moves.First(), typeof(LeftTurn));
        }

        [TestMethod]
        public void ReturnsMovesForOneRight()
        {
            StringMoveParser parser = new StringMoveParser();
            List<IMove> moves = parser.GetMoves("R");
            Assert.AreEqual(1, moves.Count);
        }

        [TestMethod]
        public void ReturnsTwoMovesForTwoRight()
        {
            StringMoveParser parser = new StringMoveParser();
            List<IMove> moves = parser.GetMoves("RR");
            Assert.AreEqual(2, moves.Count);
        }

        [TestMethod]
        public void ReturnsForOneRight()
        {
            StringMoveParser parser = new StringMoveParser();
            List<IMove> moves = parser.GetMoves("R");
            Assert.IsInstanceOfType(moves.First(), typeof(RightTurn));
        }

        [TestMethod]
        public void ReturnsTurnsInRightOrder()
        {
            StringMoveParser parser = new StringMoveParser();
            List<IMove> moves = parser.GetMoves("LR");
            Assert.IsInstanceOfType(moves.First(), typeof(LeftTurn));
            Assert.IsInstanceOfType(moves.Skip(1).First(), typeof(RightTurn));
        }
    }
}
