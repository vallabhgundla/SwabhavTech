using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShoppingCartLib.Model;
using System;

namespace ShoppingCartLib.Test
{
    [TestClass]
    public class UnitTest1
    {   

        [TestMethod]

        public void ProductCreate()
        {
            Product p = new Product(101, "Book", 250, .50f);
            Assert.AreEqual<int>(p.ID, 101);
            Assert.AreEqual<string>(p.Name, "Book");
            Assert.AreEqual<double>(p.Price, 250);
            Assert.AreEqual<float>(p.Discnt, .50f);
        }
       
    }
}
