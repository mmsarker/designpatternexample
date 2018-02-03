using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.ChainOfResponsibility
{
    public class Employee : Approver
    {
        public override void ProcessRequest(Purchase purchase)
        {
            if(purchase.Quantity<=100)
            {
                Console.WriteLine("Approved by employee.");
            }
            else if(this.nextApprover!=null)
            {
                this.nextApprover.ProcessRequest(purchase);
            }
        }
    }
}
