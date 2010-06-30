using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using MarsRover;
using System.Drawing;

namespace MarsRoverTests
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class RoverTests
    {
        public RoverTests()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void InitRover()
        {
            Point location = new Point(0,0);
            Direction direction = Direction.North;
            Rover rover = new Rover(direction, location,null, null);
            Assert.AreEqual(location, rover.Location);
            Assert.AreEqual(direction, rover.Direction);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidLocationException))]
        public void InitRoverWithNegativeXCoordinate()
        {
            Point location = new Point(-1, 0);
            Direction direction = Direction.North;
            Rover rover = new Rover(direction, location,null, null);
            Assert.AreEqual(location, rover.Location);
            Assert.AreEqual(direction, rover.Direction);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidLocationException))]
        public void InitRoverWithNegativeYCoordinate()
        {
            Point location = new Point(0, -1);
            Direction direction = Direction.North;
            Rover rover = new Rover(direction, location,null,null);
            Assert.AreEqual(location, rover.Location);
            Assert.AreEqual(direction, rover.Direction);
        }
    }
}
