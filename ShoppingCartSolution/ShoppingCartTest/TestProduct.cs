using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartLib.Model;
using System;

namespace ShoppingCartTest
{
    [TestClass]
    public class TestProduct
    {
        [TestMethod]
        public void TestMethod1()
        {
            Product p = new Product(101, "Biscuit", 100, 0.5f);
            Assert.AreEqual<int>(p.ID, 101);
            Assert.AreEqual<string>(p.Name, "Biscuit");
            Assert.AreEqual<double>(p.Price, 100);
            Assert.AreEqual<float>(p.Discnt, 0.5f);

        }
    }
}
