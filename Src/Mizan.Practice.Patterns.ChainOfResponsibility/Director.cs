using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.ChainOfResponsibility
{
    public class Director : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if(purchase.Quantity>500)
            {
                Console.WriteLine("Approved by director.");
            }
        }
    }
}
