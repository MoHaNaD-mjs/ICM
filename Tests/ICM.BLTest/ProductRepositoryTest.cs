using System;
using ICM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ICM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod()]
        public void RetrieveTest()
        {
            //-- Arrange
            var productRepository = new ProductRepository();
            var expected = new Product(2)
            {
            ProductName = "جوال",
            ProductDescription = "جوال ايفون 7",
            CurrentPrice = 3000,
            InterestRate = 50,
            SalePrice = 4500
        };

            //-- Act
            var actual = productRepository.Retrieve(2);

            //-- Assert
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.InterestRate, actual.InterestRate);
            Assert.AreEqual(expected.SalePrice, actual.SalePrice);
        }
    }
}
