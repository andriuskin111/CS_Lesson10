using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRMBusinesLogicLayer;

namespace CRM.test
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void TestuojamArFullNameGrazinaFullName()
        {
            // Arrange
            Customer customer = new Customer();

            // Act
            customer.FirstName = "Vasia";
            customer.LastName = "Petrov";
            string fullName = customer.FullName;

            // Assert
            Assert.AreEqual(fullName, "Petrov,Vasia");
        }

        [TestMethod]
        public void TestuojamArFullNameGrazinaFullNameKaiFirstNameTuscias()
        {
            // Arrange
            Customer customer = new Customer();

            // Act
            customer.LastName = "Petrov";
            string fullName = customer.FullName;

            // Assert
            Assert.AreEqual(fullName, "Petrov,");
        }

        [TestMethod]
        public void TestuojamArFullNameGrazinaFullNameKaiLasttNameTuscias()
        {
            // Arrange
            Customer customer = new Customer();

            // Act
            customer.FirstName = "Vasia";
            string fullName = customer.FullName;

            // Assert
            Assert.AreEqual(fullName, ",Vasia");
        }

        [TestMethod]
        public void TestuojamArFullNameGrazinaFullNameKaiFirstNAmeIrLasttNameTuscias()
        {
            // Arrange
            Customer customer = new Customer();

            // Act
            string fullName = customer.FullName;
            
            // Assert
            Assert.AreEqual(fullName, ",");
        }

        [TestMethod]
        public void ValidateValid()
        {
            // Arrange
            Customer customer = new Customer
            {
                FirstName = "vasia",
                LastName = "Lastname",
                EmailAddress = "gmail.com"
            };

            bool expected = true;

            // Act
            var actual = customer.Validate();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
