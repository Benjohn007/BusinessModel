using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acmm.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        { 
        //create the instance of the customer class
        //pass in the request id
        Customer customer = new Customer();
        //code that retrive the defined customer 

        //Temporary hard-coded values to return
        //a populated customer
        if(customerId == 1)
        {
           customer.EmailAddress = "Benjamin@ben.com";
           customer.LastName = "Benjamin";
           customer.FirstName = "John";
        }
        return customer;

        }

        public bool Save(Customer customer)
        {
            //code that saves the passed in customer

            return true;
        }
    }
}
