using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MarsRover;

namespace MarsRoverTests
{
    [TestClass]
    public class StandardMoveSupplierTests
    {
        [TestMethod]
        public void TestEmptyMoves()
        {
            IMoveParser parser = new StringMoveParser();
            IMoveSupplier supplier = new StandardMoveSupplier(parser);
            supplier.Init("");
            Assert.IsFalse(supplier.HasNextMove());
        }

        [TestMethod]
        public void TestOneMove()
        {
            IMoveParser parser = new StringMoveParser();
            IMoveSupplier supplier = new StandardMoveSupplier(parser);
            supplier.Init("L");
            Assert.IsTrue(supplier.HasNextMove());
            supplier.NextMove();
            Assert.IsFalse(supplier.HasNextMove());
        }

        [TestMethod]
        public void TestTwoMovesAreInCorrectOrder()
        {
            IMoveParser parser = new StringMoveParser();
            IMoveSupplier supplier = new StandardMoveSupplier(parser);
            supplier.Init("LR");
            Assert.IsTrue(supplier.HasNextMove());
            Assert.IsInstanceOfType(supplier.NextMove(), typeof(LeftTurn));
            Assert.IsInstanceOfType(supplier.NextMove(), typeof(RightTurn));
            Assert.IsFalse(supplier.HasNextMove());
        }
    }
}
