using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MarsRover;

namespace MarsRoverTests
{
    [TestClass]
    public class StandardDirectionParserTests
    {
        [TestMethod]
        public void ParsesNorth()
        {
            IDirectionParser parser = new StandardDirectionParser();
            Assert.AreEqual(Direction.N, parser.GetDirection("1 1 N"));
        }

        [TestMethod]
        public void ParsesSouth()
        {
            IDirectionParser parser = new StandardDirectionParser();
            Assert.AreEqual(Direction.S, parser.GetDirection("1 1 S"));
        }
        [TestMethod]
        public void ParsesEast()
        {
            IDirectionParser parser = new StandardDirectionParser();
            Assert.AreEqual(Direction.E, parser.GetDirection("1 1 E"));
        }
        [TestMethod]
        public void ParsesWest()
        {
            IDirectionParser parser = new StandardDirectionParser();
            Assert.AreEqual(Direction.W, parser.GetDirection("1 1 W"));
        }
    }
}
