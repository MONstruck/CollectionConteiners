using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CollectionConteiners;

namespace CollectionConteinersTests
{
    [TestClass]
    public class PointTests
    {
        [TestMethod]
        public void AutoGenereted1DPointRandom()
        {
            Point point = new Point();
            point.AutoGenereted1DPoint();
            Assert.IsNotNull(point);
        }
        [TestMethod]
        public void AutoGenereted2DPointRandom()
        {
            Point point = new Point();
            point.AutoGenereted2DPoint();
            Assert.IsNotNull(point);
        }
        [TestMethod]
        public void AutoGenereted3DPointRandom()
        {
            Point point = new Point();
            point.AutoGenereted3DPoint();
            Assert.IsNotNull(point);
        }
     
    }
}
