using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBusinesLogicLayer
{
    public class Order
    {
        public int OrderId { get;  private set; }
        public Customer Customer { get; set; }
        public DateTime OrderDate { get ; set; }
        public string ShippingAddress { get; set; }
        public List<Product> OrderItems { get; set; }

        public Order()
        {
                
        }

        public Order( int orderId)
        {
            OrderId = orderId;     
        }

        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrEmpty(Customer.FullName)) isValid = false;
            if (string.IsNullOrEmpty(Customer.EmailAddress)) isValid = false;
            if (string.IsNullOrEmpty(Customer.HomeAddress)) isValid = false;
            if (string.IsNullOrEmpty(Customer.WorkAddress)) isValid = false;
            //if(DateTime.) isValid = false;
            if (string.IsNullOrEmpty(ShippingAddress)) isValid = false;
            if (OrderItems.Count < 1) isValid = false;

            return isValid;
        }
    }
}
