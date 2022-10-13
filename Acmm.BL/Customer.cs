using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acmm.BL
{
    public class Customer
    {
        public string EmailAddress { get; set; }

        public int CustomerID { get; private set; }

        public string FirstName { get; set; }

        private string _lastName;
        public string LastName
        {
            get
            { return _lastName;}
            set
            { _lastName = value; }
        }
        public string FullNAme
        {
            get
            {
               string fullName = LastName;
                if (!string.IsNullOrEmpty(FirstName))
                {
                    if (!string.IsNullOrEmpty(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName; 
                }
                return fullName;
            }
        }
    }
}
