using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICM.BL
{
   public class OrderRepository
    {
        // <summary>
        // Retrieve one Order.
        // </summary>
        // <returns></returns>
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);
            if (orderId == 10) 
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 14, 10, 00, 00,
                    new TimeSpan(7, 0, 0));
            }

            return order;
        }

        // <summary>
        // Retrieve all Order.
        // </summary>
        // <returns></returns>
        public List<Order> Retrieve()
        {


            return new List<Order>();
        }

        // <summary>
        // Saves the current Order
        // </summary>
        // <returns></returns>
        public bool Save(Order order)
        {
            return true;
        }
        
    }
}
