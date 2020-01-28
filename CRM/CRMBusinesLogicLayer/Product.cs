using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBusinesLogicLayer
{
    public class Product
    {
        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductCurrentPrice { get; set; }

        public Product()
        {
                
        }

        public Product(int productId)
        {
            ProductId = productId;   
        }

        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(ProductName)) isValid = false;
            if (string.IsNullOrEmpty(ProductDescription)) isValid = false;
            if (ProductCurrentPrice < 0) isValid = false;

            return isValid;
        }
    }
}
