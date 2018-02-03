using Mizan.Practice.Patterns.StatePattern.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.StatePattern.State
{
    public class WithDrawState : ATMState
    {
        public override void Handle(ATM atm)
        {
            Console.WriteLine("Enter amount you want to withdraw");
            var amount = Console.ReadLine();
            decimal amt = Convert.ToDecimal(amount);
            Console.WriteLine("Processing...... Please wait.");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Done");
            atm.CurrentState = new EjectCardState();
        }
    }
}
