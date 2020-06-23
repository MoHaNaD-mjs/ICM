

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICM.BL
{
    public class Customer
    {
        public Customer():this(0)
        {

        }
        public Customer(int customerId)
        {
            CustomerID = customerId;
            paymentsStatements = new List<PaymentsStatement>();
        }

        public List<PaymentsStatement> paymentsStatements { get; set; }
        public int CustomerID { get; private set; }

        public string EmailAddress { get; set; }
        public int? PhoneNumber { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public int CustomerType { get; set; }

        public static int InstanceCount { get; set; }

        public string FullName 
        { get
            {
                string fullName = FirstName;
                if (!string.IsNullOrWhiteSpace(MiddleName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += " ";
                    }
                    fullName += MiddleName; 
                }
                if (!string.IsNullOrWhiteSpace(LastName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += " ";
                    }
                    fullName += LastName;
                }
                return fullName;
            }
          }


        /// <summary>
        /// Validates the customer data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }


    }
}
