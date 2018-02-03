using Mizan.Practice.Patterns.StatePattern.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.StatePattern.State
{
    public class InvalidPinState : ATMState
    {
        public override void Handle(ATM atm)
        {
            Console.WriteLine("Your entered PIN is not correct");
            Console.WriteLine("Please try again");
            atm.CurrentState = new CardValidatedState();
        }
    }
}
