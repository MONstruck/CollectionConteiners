using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CollectionConteiners;
namespace CollectionConteinersTests
{
    [TestClass]
    public class CollectionContainerTest
    {
        [TestMethod]
        public void Create_ColectionContainer_0()
        {
            ContainersCollection containersCollection = new ContainersCollection();
            containersCollection.CreateContainerList(1);
            Assert.IsNotNull(containersCollection.ContainerList[0]);
            
        }
        [TestMethod]
        public void AutomaticPoint()
        {
            ContainersCollection containersCollection = new ContainersCollection();
            containersCollection.Automatic(1, 1, 1, 1);
            Assert.IsNotNull(containersCollection.PointsList[0]);
        }
        [TestMethod]
        public void AutomaticPosition()
        {
            ContainersCollection containersCollection = new ContainersCollection();
            containersCollection.Automatic(1, 1, 1, 1);
            Assert.IsNotNull(containersCollection.PositionList[0]);
        }
        [TestMethod]
        public void AutomaticMatrix()
        {
            ContainersCollection containersCollection = new ContainersCollection();
            containersCollection.Automatic(1, 1, 1, 1);
            Assert.IsNotNull(containersCollection.MatrixList[0]);
        }
        [TestMethod]
        public void AutomaticContainer()
        {
            ContainersCollection containersCollection = new ContainersCollection();
            containersCollection.Automatic(1,1,1,1);
            Assert.IsNotNull(containersCollection.ContainerList[0]);
        }
        
    }
}
