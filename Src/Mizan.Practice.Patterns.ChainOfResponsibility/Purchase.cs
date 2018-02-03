using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.ChainOfResponsibility
{
    public class Purchase
    {
        public Purchase(int quantity)
        {
            this.Quantity = quantity;
        }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
    }
}
