using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICM.BL
{
   public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }

        public int ProductId { get; set; }
        public int OrderItemId { get; set; }
        public int Quantity { get; set; }
        public decimal? PurchasePrice { get; set; }
        // public int MyProperty { get; set; }

        /// <summary>
        /// Retrieve one Order Item.
        /// </summary>
        /// <returns></returns>
        public OrderItem Retrieve(int OrderItemId)
        {


            return new OrderItem();
        }

        /// <summary>
        /// Retrieve all Order Item.
        /// </summary>
        /// <returns></returns>
        public List<OrderItem> Retrieve()
        {


            return new List<OrderItem>();
        }

        /// <summary>
        /// Saves the current Order Item.
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            return true;
        }
        /// <summary>
        /// Validate the Order Item.
        /// </summary>  
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (Quantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}
