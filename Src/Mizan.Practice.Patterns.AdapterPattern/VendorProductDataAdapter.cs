using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Mizan.Practice.Patterns.AdapterPattern
{
    public class VendorProductDataAdapter : IProductDataAdapter
    {
        public List<Product> GetProducts()
        {
            var vendorProductDataAdaptee = new VendorProductDataAdaptee();
            var products = vendorProductDataAdaptee.GetProducts();
            return products.Select(x => new Product
            {
                Name = x
            }).ToList();
            
        }
    }
}
