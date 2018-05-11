using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CollectionConteiners;
namespace CollectionConteinersTests
{
    [TestClass]
    public class ContainerTest
    {
        [TestMethod]
        public void CreateContainer_0()
        {
            Container container= new Container();
            container.CreateMatrixList(1);
            Assert.IsNotNull(container.MatrixList[0]);
        }
    }
}
