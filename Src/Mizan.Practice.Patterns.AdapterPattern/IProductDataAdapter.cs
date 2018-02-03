using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.AdapterPattern
{
    public interface IProductDataAdapter
    {
        List<Product> GetProducts();
    }
}
