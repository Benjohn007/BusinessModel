using Acmm.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Acmm.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            //Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
                CurrentPrice = 15.96M,
                ProductDescription = "Assorted size set" +
                    " of 4 Bright Yellow mini Sunflower",
                ProductName = "Sunflower",
            };
            //--Act
            var actual = productRepository.Retrieve(2);
            //Assert
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }
        
    }
}
