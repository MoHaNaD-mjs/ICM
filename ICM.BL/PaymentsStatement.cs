using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICM.BL
{
   public class PaymentsStatement
    {
        public PaymentsStatement()
        {

        }
        public PaymentsStatement(int paymentId)
        {
            PaymentId = paymentId;
        }
        public int PaymentId { get; private set; }
        public string Notes { get; set; }
        public decimal? Payment { get; set; }
        public DateTimeOffset DateOfPayment { get; set; }
        public String ProductName { get; set; }

        public bool Validate()
        {
            var isvalid = true;
            if (Payment == 0) isvalid = false;

            return isvalid;
        }
    }
}
