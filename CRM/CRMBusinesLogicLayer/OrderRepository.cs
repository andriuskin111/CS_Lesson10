using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBusinesLogicLayer
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if (orderId == 1)
            {
                Customer customer = new Customer();
                Product product = new Product();              
                     
                order.Customer = customer.Retrieve(1);
                order.OrderDate = new DateTime(2020 - 01 - 20);
                order.ShippingAddress = "Gedimino pr 8, Vilnius, Lithuania";
                order.OrderItems.Add(new Product()); 
            }

            return order;
        }
    }
}
