using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acmm.BL
{
    public class OrderRepository
    {
        //Retrieve one Order
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);
            
            //code that retrieves the defined order
            //Temporary hard-coded values to return
            //a populated order

            if(orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year,
                    4, 14, 10, 00, 00, new TimeSpan(7,0,0));
            }
            return order;
        }

        //Saves the current order
        public bool Save(Order order)
        {
            //Code that saves the passed in order
            return true;
        }
    }
}
