using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void SayHelloTest()
        {
            // Arrange
            var currentProject = new Product();
            currentProject.ProductName = "Apple MacBook";
            currentProject.ProductId = 5;
            currentProject.Description = "A premium laptop computer";
            var expected = "Hello Apple MacBook A premium laptop computer 5";
            // Act 
            var actual = currentProject.SayHello();
            // Assert

            Assert.AreEqual(expected, actual);
        }
    }
}