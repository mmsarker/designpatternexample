using Mizan.Practice.Patterns.StatePattern.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mizan.Practice.Patterns.StatePattern.State
{
    public class CardValidatedState : ATMState
    {
        public override void Handle(ATM atm)
        {
            Console.WriteLine("Please enter your pin number");
            var pinNumber = Console.ReadLine();
            if(pinNumber == "1234")
            {
                atm.CurrentState = new WithDrawState();
            }
            else
            {
                atm.CurrentState = new InvalidPinState();
            }
        }
    }
}
