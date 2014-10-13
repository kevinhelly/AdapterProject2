using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdapterTestsLib
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            
            string expectedTitle = "Fiskdansen 2";
            decimal expectedUnitPrice = 200;
            string expectedBarCode = "|||  ||  ||||| ||";

            Assert.AreEqual(expectedTitle, "Fiskdansen 2");
            Assert.AreEqual(expectedUnitPrice, 200);
            Assert.AreEqual(expectedBarCode, "|||  ||  ||||| ||");
        }
    }
}
