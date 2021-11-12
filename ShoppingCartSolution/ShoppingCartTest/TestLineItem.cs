using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartLib.Model;
using System;

namespace ShoppingCartTest
{
    [TestClass]
    public class TestLineItem
    {
        [TestMethod]
        public void TestLineItem1()
        {
            LineItem lineItem = new LineItem(504, new Product(101, "Laptop", 30000, 0.5f), 1);
            Assert.IsTrue(lineItem.Quantity == 1);
            Assert.AreEqual<Product>(lineItem.Product);
        }
        [TestMethod]
        public void TestDiscountPrice()
        {
            LineItem lineItem = new LineItem(504, new Product(101, "Laptop", 15000, 0.5f), 3);
            Assert.AreEqual<double>(lineItem.Calculate(), 22500);
        }
    }
}
