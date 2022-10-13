using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acmm.BL
{
    public class Order
    {
        public Order()
        {

        }

        public Order (int orderId)
        {
            OrderId = orderId;
        }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }


        //Validate order
        public bool Validate()
        {
           var isValid = true;
            if (OrderDate != null)
                isValid = false;
            return isValid;
        }
    }
}
