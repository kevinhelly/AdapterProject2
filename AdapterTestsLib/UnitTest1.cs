using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductLib;

namespace AdapterTestsLib
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ProductTest()
        {
            Product p = new Product();
            p.Title = "Fiskdansen 2";
            p.UnitPrice = 200;
            p.BarCode = "|||  ||  ||||| ||";

            var result = p;

            string expectedTitle = "Fiskdansen 2";
            decimal expectedUnitPrice = 200;
            string expectedBarCode = "|||  ||  ||||| ||";

            Assert.AreEqual(expectedTitle, result.Title);
            Assert.AreEqual(expectedUnitPrice, result.UnitPrice);
            Assert.AreEqual(expectedBarCode, result.BarCode);
        }
        [TestMethod]
        public void SomeExternalVendorProductTest()
        {

            string expectedDescription = "Fiskdansen 2";
            int expectedPricePerUnit = 200;
            string expectedEANCode = "|||  ||  ||||| ||";

            Assert.AreEqual(expectedDescription, "");
            Assert.AreEqual(expectedPricePerUnit, 0);
            Assert.AreEqual(expectedEANCode, "");
        }
    }
}
