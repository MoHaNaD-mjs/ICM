using System;
using ICM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ICM.BLTest
{
    [TestClass]
    public class CustomerTest
    {
        [TestMethod]
        public void FullNameTestValid()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "مهند",
                MiddleName="جابر",
                LastName = "العنزي"
            };
            string expected = "مهند جابر العنزي";
            //-- Act
            string actual = customer.FullName;
            //-- Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void FullNameFirstNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                FirstName = "مهند"

            };
            string expected = "مهند";
            //-- Act
            string actual = customer.FullName;
            //-- Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FullNameMiddleNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
                
                MiddleName = "جابر"
                
            };
            string expected = "جابر";
            //-- Act
            string actual = customer.FullName;
            //-- Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void FullNameLastNameEmpty()
        {
            //-- Arrange
            Customer customer = new Customer
            {
              
                LastName = "العنزي"
            };
            string expected = "العنزي";
            //-- Act
            string actual = customer.FullName;
            //-- Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void StaticTest()
        {
            //-- Arrange
            var c1 = new Customer();
            c1.FirstName = "مهند";
            Customer.InstanceCount += 1;
            var c2 = new Customer();
            c2.FirstName = "صالح";
            Customer.InstanceCount += 1;
            var c3 = new Customer();
            c3.FirstName = "محمد";
            Customer.InstanceCount += 1;
           
            //-- Act
          
            //-- Assert
            Assert.AreEqual(3, Customer.InstanceCount);

        }
        [TestMethod]
        public void ValidateValid() 
        {
            //arrange
            var customer = new Customer();
            customer.FirstName = "مهند";
            customer.MiddleName = "جابر";
            customer.LastName = "العنزي";
            customer.EmailAddress = "mohanadmjs9990@gmail.com";

            var expected = true;
            //act
            var actual = customer.Validate();
            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void ValidateMissingLastNameValid()
        {
            //arrange
            var customer = new Customer();
            customer.FirstName = "مهند";
            customer.MiddleName = "جابر";
            //customer.LastName = "العنزي";
            customer.EmailAddress = "mohanadmjs9990@gmail.com";

            var expected = false;
            //act
            var actual = customer.Validate();
            //assert
            Assert.AreEqual(expected, actual);

        }
    }
    }
