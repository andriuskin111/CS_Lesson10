using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBusinesLogicLayer
{
    public class CustomerRepository
    {
        

        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "hjgjgj@gmail.com";
                customer.FirstName = "vasia";
                customer.LastName = "Petrov";
            }

            return customer;
        }
    }
}
