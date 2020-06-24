using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICM.BL
{
   public class ProductRepository
    {

        /// <summary>
        /// Retrieve one Product.
        /// </summary>
        /// <returns></returns>
        public Product Retrieve(int ProductId)
        {
            Product product = new Product(ProductId);
            if (ProductId == 2)
            {
                product.ProductName = "جوال";
                product.ProductDescription = "جوال ايفون 7";
                product.CurrentPrice =3000;
                product.InterestRate = 50;
                product.SalePrice = 4500;
            }
            Object mybject = new object();
            Console.WriteLine($"Object: {mybject.ToString()}");
            Console.WriteLine($"Product: {product.ToString()}");
            return product;
        }

        ///// <summary>
        ///// Retrieve all Product.
        ///// </summary>
        ///// <returns></returns>
        public List<Product> Retrieve()
        {


            return new List<Product>();
        }

        /// <summary>
        /// Saves the current Product
        /// </summary>
        /// <returns></returns>
        public bool Save(Product product)
        {
            var success = true;
            if (product.HasChanges) 
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {
                        //Call an Insert Stored Procedure
                    }
                    else
                    {
                        // Call an Update Stored Procdure
                    }
                }
                else 
                {
                    success = false;
                }
            }
            return success;
        }
        
    }
}
