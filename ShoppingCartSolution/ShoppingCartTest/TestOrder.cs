using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartLib.Model;
using System;

namespace ShoppingCartTest
{
    [TestClass]
    public class TestOrder
    {
        Order order = new Order(1, new DateTime(2021, 02, 09));
        [TestMethod]
        public void TestOrderCheck()
        {
            order.AddItem(new LineItem(1, new Product(101, "Book", 50, 50f), 2));
            order.AddItem(new LineItem(1, new Product(101, "Book", 50, 50f), 2));
            Assert.AreEqual<int>(1, order.Items[0].Id);
            Assert.AreEqual<int>(2, order.Items[1].Id);
        }
        [TestMethod]
        public void NumberOfOrderItemsCheck()
        {
            order.AddItem(new LineItem(1, new Product(101, "Book", 50, 50f), 2));
            order.AddItem(new LineItem(1, new Product(101, "Book", 50, 50f), 2));
            Assert.AreEqual<int>(2, order.ItemCount);
        }
    }
}
