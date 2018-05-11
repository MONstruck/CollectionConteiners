using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CollectionConteiners;
namespace CollectionConteinersTests
{
    [TestClass]
    class PositionTest
    {
        [TestMethod]
        public void createPointList_0()
        {

            Position position = new Position();
            position.createPointList(1);
            Assert.AreEqual(0, position.PointsList[0]);
        }
        [TestMethod]
        public void AutoGenereted1DPosition()
        {

            Position position = new Position();
            position.AutoGenereted1DPosition(1);
            Assert.IsNotNull(position.PointsList[0]);
        }
        [TestMethod]
        public void AutoGenereted2DPosition()
        {

            Position position = new Position();
            position.AutoGenereted2DPosition(1);
            Assert.IsNotNull(position.PointsList[0]);
        }
        [TestMethod]
        public void AutoGenereted3DPosition()
        {

            Position position = new Position();
            position.AutoGenereted3DPosition(1);
            Assert.IsNotNull(position.PointsList[0]);
        }
    }
}
