using System;
using System.Collections.Generic;
using ICM.BL;
using ICM.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ICM.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            // Arrange
            var changedItems = new List<ILoggabale>();

            var customer = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "مهند",
                MiddleName="جابر",
                LastName = "العنزي",
                //paymentsStatements = null
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
            changedItems.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with Steel Head",
                CurrentPrice = 6M
            };
            changedItems.Add(product);

            // Act
            LoggingService.WriteToFile(changedItems);

            // Assert
            // Nothing here to assert
        }
    }
}
