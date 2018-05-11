using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CollectionConteiners;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
namespace CollectionConteinersTests

{
    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        public void CreatePositionList_0()
        {
         
            Matrix matrix = new Matrix();
            matrix.CreatePositionList(1);
          
            
            Assert.IsNotNull(matrix.PositionList[0]);
        }
    }
}
