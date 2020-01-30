using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRMBusinesLogicLayer;

namespace CRM.test
{
    [TestClass]
    public class ProductTest
    {
        [TestMethod]
        public void ValidateValidWhenAllDataIsCorrect()
        {
            // Arrange
            Product product = new Product
            {
                ProductName = "Alus",
                ProductDescription = "Svyturio Extra",
                ProductCurrentPrice = 1.8m
            };

            bool expected = true;

            // Act
            bool actual = product.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateValidWhenNameIsEmpty()
        {
            // Arrange
            Product product = new Product
            {
                ProductName = "",
                ProductDescription = "Svyturio Extra",
                ProductCurrentPrice = 1.8m
            };

            bool expected = false;

            // Act
            bool actual = product.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateValidWhenDescriptionIsEmpty()
        {
            // Arrange
            Product product = new Product
            {
                ProductName = "Alus",
                ProductDescription = "",
                ProductCurrentPrice = 1.8m
            };

            bool expected = false;

            // Act
            bool actual = product.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateValidWhenPriceValueIsNegative()
        {
            // Arrange
            Product product = new Product
            {
                ProductName = "Alus",
                ProductDescription = "Svyturio Extra",
                ProductCurrentPrice = -1.8m
            };

            bool expected = false;

            // Act
            bool actual = product.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ValidateValidWhenAllDataIsEmpty()
        {
            // Arrange
            Product product = new Product
            {
                ProductName = "",
                ProductDescription = "",
            };

            bool expected = false;

            // Act
            bool actual = product.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
