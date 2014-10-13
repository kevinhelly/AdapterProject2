using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductAdapterLib;
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
            SomeExternalVendorProduct sevp = new SomeExternalVendorProduct();
            sevp.Description = "Fiskdansen 2";
            sevp.EANCode = "|||  ||  ||||| ||";
            sevp.PricePerUnit = 200;

            IProduct ip = new SomeExternalVendorProductAdapter(sevp);

            Assert.AreEqual(ip.BarCode, sevp.EANCode);
            Assert.AreEqual(ip.Title,sevp.Description);
            Assert.AreEqual(ip.UnitPrice, sevp.PricePerUnit);
        }
    }
}
