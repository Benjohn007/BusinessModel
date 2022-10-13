using Acmm.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Acmm.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveValid()
        {
            // Arrange
            var customerRepository = new CustomerRepository();
            var expected = new Customer()
            {
                
                EmailAddress = "Benjamin@ben.com",
                LastName = "Benjamin",
                FirstName = "John"

            };
            //Act
            var actual = customerRepository.Retrieve(1);

            //Assert
            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        }
        
    }
}
