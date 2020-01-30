using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRMBusinesLogicLayer;

namespace CRM.test
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange
            ProductRepository productRepository = new ProductRepository();
            Product expected = new Product(1)
            {
                ProductName = "Alus",
                ProductDescription = "Svyturio Extra",
                ProductCurrentPrice = 1.5m
            };

            // Act
            string actualName = productRepository.Retrieve(1).ProductName;
            string actualDescription = productRepository.Retrieve(1).ProductDescription;
            decimal actualCurrentPrice = productRepository.Retrieve(1).ProductCurrentPrice;


            // Assert
            Assert.AreEqual(expected.ProductName, actualName);
            Assert.AreEqual(expected.ProductDescription, actualDescription);
            Assert.AreEqual(expected.ProductCurrentPrice, actualCurrentPrice);
        }
    }
}
