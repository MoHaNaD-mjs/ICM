using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICM.BL
{
   public class PaymentsStatementRepository
    {
        /// <summary>
        /// Retrieve one address.
        /// </summary>
        public PaymentsStatement Retrieve(int paymentId)
        {
            // Create the instance of the Address class
            // Pass in the requested Id
            PaymentsStatement payments = new PaymentsStatement(paymentId);

            // Code that retrieves the defined address

            // Temporary hard coded values to return 
            // a populated address
            if (paymentId == 1)
            {
                payments.Payment = 300;
                payments.ProductName = "جوال";
                payments.Notes = "تحويل الأهلي";
                payments.DateOfPayment=new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                    new TimeSpan(7, 0, 0));
                    
            }
            return payments;
        }

        public IEnumerable<PaymentsStatement> RetrieveByCustomerId(int customerId)
        {
            // Code that retrieves the defined addresses
            // for the customer.

          
            // Temporary hard-coded values to return 
            // a set of addresses for a customer
            var paymentsStatementList = new List<PaymentsStatement>();
            PaymentsStatement payment1 = new PaymentsStatement(1)
            {
                Payment = 300,
                ProductName = "جوال",
                Notes = "تحويل الأهلي",
                DateOfPayment = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                                new TimeSpan(7, 0, 0))
            
        };
            paymentsStatementList.Add(payment1);

            payment1 = new PaymentsStatement(2)
            {
                Payment = 500,
                ProductName = "جوال",
                Notes = "كاش",
                DateOfPayment = new DateTimeOffset(DateTime.Now.Year,5 , 15, 10, 00, 00,
                                new TimeSpan(7, 0, 0))
            };
            paymentsStatementList.Add(payment1);

            return paymentsStatementList;
        }

        /// <summary>
        /// Saves the current address.
        /// </summary>
        /// <returns></returns>
        public bool Save(PaymentsStatement address)
        {
            // Code that saves the passed in address

            return true;
        }
    }
}
