using Acmm.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Acmm.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
       /* public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins, Bilbo";

            //-- Act
            string actual = customer.FullNAme;

            //--Assert
            Assert.AreEqual(expected, actual);
        }*/

        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                //FirstName = "Bilbo",
                LastName = "Baggins"
            };
            string expected = "Baggins";

            //-- Act
            string actual = customer.FullNAme;

            //--Assert
            Assert.AreEqual(expected, actual);
        }

        public void FullNameFirstNameEmpty2()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "Bilbo",
                //LastName = "Baggins"
            };
            string expected = "Bilbo";

            //-- Act
            string actual = customer.FullNAme;

            //--Assert
            Assert.AreEqual(expected, actual);
            
        }
    }
}
