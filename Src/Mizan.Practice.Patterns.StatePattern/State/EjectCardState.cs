using Mizan.Practice.Patterns.StatePattern.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.StatePattern.State
{
    public class EjectCardState : ATMState
    {
        public override void Handle(ATM atm)
        {
            Console.WriteLine("Please take your card..");
            atm.CurrentState = new NoCardState();
        }
    }
}
