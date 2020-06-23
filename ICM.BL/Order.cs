using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICM.BL
{
    public class Order
    {
        public Order():this(0)
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }
        public int CustomerId { get; set; }//if you need
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        //public int ShippingAddressId { get; set; }
        public List<OrderItem> OrderItems { get; set; }



        // <summary>
        // Validate the Product data.
        // </summary>
        // <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }
    }
}
