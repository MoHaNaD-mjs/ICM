using System;
using System.Collections.Generic;
using ICM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ICM.BLTest
{
    [TestClass]
    public class CustomerRepositoryTest
    {
        [TestMethod]
        public void RetrieveExisingWithPaymentStatment()
        {
            //-- Arrange
            var cutomerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                EmailAddress = "Mohanadmjs9990@gmail.com",
                FirstName = "مهند",
                MiddleName = "جابر",
                LastName = "العنزي",
                PhoneNumber=0508628022,
                paymentsStatements = new List<PaymentsStatement>
                        {
                            new PaymentsStatement()
                            {
                                Payment = 300,
                                ProductName = "جوال",
                                Notes = "تحويل الأهلي",
                                DateOfPayment = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                                                                new TimeSpan(7, 0, 0))
                             },
                             new PaymentsStatement()
                             {

                                Payment = 500,
                                ProductName = "جوال",
                                Notes = "كاش",
                                DateOfPayment = new DateTimeOffset(DateTime.Now.Year,5 , 15, 10, 00, 00,
                                                new TimeSpan(7, 0, 0))
                             }
    }

            };
            //-- Act
            var actual = cutomerRepository.Retrieve(1);

            //-- Assert
            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            Assert.AreEqual(expected.MiddleName, actual.MiddleName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
            Assert.AreEqual(expected.PhoneNumber, actual.PhoneNumber);

            for (int i = 0; i < 1; i++)
            {
                Assert.AreEqual(expected.paymentsStatements[i].Payment, actual.paymentsStatements[i].Payment);
                Assert.AreEqual(expected.paymentsStatements[i].ProductName, actual.paymentsStatements[i].ProductName);
                Assert.AreEqual(expected.paymentsStatements[i].Notes, actual.paymentsStatements[i].Notes);
                Assert.AreEqual(expected.paymentsStatements[i].DateOfPayment, actual.paymentsStatements[i].DateOfPayment);
                
            }
        }
            [TestMethod]
        public void RetrieveValid()
        {
            //-- Arrange

            var customerRepository = new CustomerRepository();
            var expected = new Customer(1)
            {
                FirstName = "مهند",
                MiddleName = "جابر",
                LastName = "العنزي",
                EmailAddress = "Mohanadmjs9990@gmail.com"
            };
            //-- Act
            var actual = customerRepository.Retrieve(1);
            //-- Assert
            Assert.AreEqual(expected.CustomerID, actual.CustomerID);
            Assert.AreEqual(expected.FirstName, actual.FirstName);
            Assert.AreEqual(expected.MiddleName, actual.MiddleName);
            Assert.AreEqual(expected.LastName, actual.LastName);
            Assert.AreEqual(expected.EmailAddress, actual.EmailAddress);
        }
    }
}
