using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            PaymentsStatementR = new PaymentsStatementRepository();
        }
        private PaymentsStatementRepository PaymentsStatementR { get; set; }

        /// <summary>
         /// Retrieve one customer.
       /// </summary>
        public Customer Retrieve(int customerId)
        {
            // Create the instance of the Customer class
            // Pass in the requested id
            Customer customer = new Customer(customerId);

            // Code that retrieves the defined customer

            // Temporary hard-coded values to return 
            // a populated customer
            if (customerId == 1)
            {
                customer.EmailAddress = "Mohanadmjs9990@gmail.com";
                customer.FirstName = "مهند";
                customer.MiddleName = "جابر";
                customer.LastName = "العنزي";
                customer.PhoneNumber = 0508628022;
                customer.paymentsStatements = PaymentsStatementR.RetrieveByCustomerId(customerId).
                                                ToList();
            }
           
            return customer;
        }

        /// <summary>
        /// Saves the current customer.
        /// </summary>
        /// <returns></returns>
        public bool Save(Customer customer)
        {
            // Code that saves the passed in customer

            return true;
        }

    }
}
