using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICM.BL
{
    public class Product
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;

        }
        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? CurrentPrice { get; set; }

        public int? InterestRate { get; set; }
        public int? SalePrice { get; set; }

        /// <summary>
        /// Validate the Product data.
        /// </summary>
        /// <returns></returns>
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
  
            return isValid;
        }
    }
}
