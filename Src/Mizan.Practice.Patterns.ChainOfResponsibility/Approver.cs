using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.ChainOfResponsibility
{
    public abstract class Approver
    {
        protected Approver nextApprover { get; set; }
        public abstract void ProcessRequest(Purchase purchase);
        public void SetNextApprover(Approver approver)
        {
            this.nextApprover = approver;
        }
    }
}
