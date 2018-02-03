using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.ChainOfResponsibility
{
    public class Manager : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if(purchase.Quantity>100 &&purchase.Quantity<500)
            {
                Console.WriteLine("Processed by manager");
            }
            else if(this.nextApprover!=null)
            {
                this.nextApprover.ProcessRequest(purchase);
            }
        }
    }
}
