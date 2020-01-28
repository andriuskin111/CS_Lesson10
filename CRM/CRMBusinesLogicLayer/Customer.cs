using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMBusinesLogicLayer
{
    public class Customer
    {       
        public int CustomerID { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string HomeAddress { get; set; }
        public string WorkAddress { get; set; }

        public Customer()
        {

        }

        public Customer(int customerId)
        {
            CustomerID = customerId;
        }

        public string FullName
        {
            get
            {
                if(FirstName == "" && LastName == "")
                {
                    return "";
                }
                else
                {
                    return LastName + "," + FirstName;
                }               
            }
        }

        public bool Validate()
        {
            bool isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(FirstName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public bool Save()
        {
            // Code that save the defined customer
            return true;
        }

        public Customer Retrieve(int customerId)
        {
            // Code that retrieve the defined customer
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            // Code that retrieve all customers
            return new List<Customer>();
        }
    }
}
