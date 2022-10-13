using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acmm.BL
{
    public class Address
    {
        public Address()
        {

        }

        public Address(int addressId)
        {
            AddressId = AddressId;
        }
        public int AddressId { get; private set; }
        public int AddressType { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }
        public string PostalCode { get; private set; }
        public string State { get; private set; }
        public string StreetLin1 { get; private set; }
        public string StreetLine2 { get; private set; }

        public bool Validate()
        {
            var isvalid = true;

            if(PostalCode == null) isvalid = false;

            return isvalid;
        }
    }

}
