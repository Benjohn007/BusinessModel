using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acmm.BL
{
    public class ProductRepository
    {
        //Retrieve one product
        public Product Retrieve(int productId)
        {
            //create an instance of the product class
            //pass in the requested id
            Product product = new Product(productId);

            //code that retrieve the defined product

            // temporary hard-coded values to return
            // a populated product

            if(productId == 2)
            {
                product.ProductName = "Sunflower";
                product.ProductDescription = "Assorted size set" +
                    " of 4 Bright Yellow mini Sunflower";
                product.CurrentPrice = 15.96M;
            }
            return product; 
        }
        //save the cuurent product.
        public bool Save(Product product)
        {
            //code that saves the passed in product
            return true;
        }
    }
}
