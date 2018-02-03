using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.AdapterPattern
{
    public class ProductDataClient
    {
        public void showPoducts()
        {
            IProductDataAdapter productDataAdapter = new VendorProductDataAdapter();
            var products = productDataAdapter.GetProducts();
            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
            }
        }
    }
}
