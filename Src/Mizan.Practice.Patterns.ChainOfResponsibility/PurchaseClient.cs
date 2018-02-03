using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.ChainOfResponsibility
{
    public class PurchaseClient
    {
        public void Purchase()
        {            
            Approver employee = new Employee();
            Approver manager = new Manager();
            Approver director = new Director();

            employee.SetNextApprover(manager);
            manager.SetNextApprover(director);
            
            employee.ProcessRequest(new Purchase(100));
            employee.ProcessRequest(new Purchase(400));
            employee.ProcessRequest(new Purchase(600));            
        }
    }
}
