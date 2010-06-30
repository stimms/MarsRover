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
    public class StandardLocationParserTests
    {
        [TestMethod]
        public void Parse11()
        {
            ILocationParser parser = new StandardLocationParser();
            Assert.AreEqual(new Point(1,1), parser.GetLocation("1 1 N"));
        }

        [TestMethod]
        public void Parse22()
        {
            ILocationParser parser = new StandardLocationParser();
            Assert.AreEqual(new Point(2, 2), parser.GetLocation("2 2 N"));
        }

        [TestMethod]
        public void Parse23()
        {
            ILocationParser parser = new StandardLocationParser();
            Assert.AreEqual(new Point(2, 3), parser.GetLocation("2 3 N"));
        }
    }
}
