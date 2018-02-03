using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.AdapterPattern
{
    public class VendorProductDataAdaptee
    {
        public List<string> GetProducts()
        {
            return new List<string> { "Product1", "Product2", "Product3" };
        }
    }
}
