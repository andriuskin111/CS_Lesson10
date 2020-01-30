using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBusinesLogicLayer
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 1)
            {
                product.ProductName = "Alus";
                product.ProductDescription = "Svyturio Extra";
                product.ProductCurrentPrice = 1.5m;
            }

            return product;
        }
    }
}
