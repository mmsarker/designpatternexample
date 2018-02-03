using Mizan.Practice.Patterns.StatePattern.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.StatePattern.State
{
    public class NoCardState : ATMState
    {
        public override void Handle(ATM atm)
        {
            Console.WriteLine("Welcome to this ATM. Please insert your card." );
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Thanks for inserting your card");
            atm.CurrentState = new CardValidatedState();
        }
    }
}
