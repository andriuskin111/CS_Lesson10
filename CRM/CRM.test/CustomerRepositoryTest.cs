using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRMBusinesLogicLayer;


namespace CRM.test
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange
            CustomerRepository customerRepository = new CustomerRepository();
            Customer expected = new Customer(1)
            {
                EmailAddress = "hjgjgj@gmail.com",
                FirstName = "vasia",
                LastName = "Petrov"
            };

            // Act
            string actualEmail = customerRepository.Retrieve(1).EmailAddress;
            string actualFirstName = customerRepository.Retrieve(1).FirstName;
            string actualLastName = customerRepository.Retrieve(1).LastName;


            // Assert
            Assert.AreEqual(expected.EmailAddress, actualEmail);
            Assert.AreEqual(expected.FirstName, actualFirstName);
            Assert.AreEqual(expected.LastName, actualLastName);
        }
    }
}
